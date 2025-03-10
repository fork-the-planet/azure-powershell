﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ActiveDirectory;
using Microsoft.Azure.Commands.Common.Authentication;
using Microsoft.Azure.Commands.Common.Authentication.Abstractions;
using Microsoft.Azure.Management.Authorization;
using Microsoft.Azure.Management.Authorization.Models;
using Microsoft.Rest.Azure.OData;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using ProjectResources = Microsoft.Azure.Commands.Resources.Properties.Resources;

namespace Microsoft.Azure.Commands.Resources.Models.Authorization
{
    public class AuthorizationClient
    {
        public IAuthorizationManagementClient AuthorizationManagementClient { get; set; }

        public ActiveDirectoryClient ActiveDirectoryClient { get; set; }

        static AuthorizationClient() { }

        /// <summary>
        /// Creates AuthorizationClient using AzureContext instance.
        /// </summary>
        /// <param name="context">The AzureContext instance</param>
        public AuthorizationClient(IAzureContext context)
        {
            ActiveDirectoryClient = new ActiveDirectoryClient(context);
            AuthorizationManagementClient = AzureSession.Instance.ClientFactory
                .CreateArmClient<AuthorizationManagementClient>
                (context, AzureEnvironment.Endpoint.ResourceManager);
        }

        /// <summary>
        /// Gets a single role definition by a fully qualified role Id
        /// </summary>
        /// <param name="roleId">Fully qualified roleId</param>
        public PSRoleDefinition GetRoleDefinition(string roleId)
        {
            return AuthorizationManagementClient.RoleDefinitions.GetById(roleId).ToPSRoleDefinition();
        }

        /// <summary>
        /// Gets a single role definition by the role Id guid.
        /// </summary>
        /// <param name="roleId">RoleId guid</param>
        /// <param name="scope">The scope of the role definition</param>
        public PSRoleDefinition GetRoleDefinition(Guid roleId, string scope)
        {
            return AuthorizationManagementClient.RoleDefinitions.Get(scope, roleId.ToString()).ToPSRoleDefinition();
        }

        /// <summary>
        /// Filters the existing role Definitions.
        /// If scopeAndBelow is true, Will fetch Roledefinitions with scopeAndBelow and provided name.
        /// Otherwise  will fetch Roledefinitions with provided name
        /// </summary>
        /// <param name="name">The role name</param>
        /// <param name="scope">The scope of the role definition</param>
        /// <param name="first"></param>
        /// <param name="skip"></param>
        /// <returns>The matched role Definitions</returns>
        public IEnumerable<PSRoleDefinition> FilterRoleDefinitions(string name, string scope, ulong first = ulong.MaxValue, ulong skip = 0)
        {
            ODataQuery<RoleDefinitionFilter> odataFilter = new ODataQuery<RoleDefinitionFilter>(item => item.RoleName == name);
            return AuthorizationManagementClient.RoleDefinitions.List(scope, odataFilter)
                  .Select(r => r.ToPSRoleDefinition());
        }

        public IEnumerable<PSRoleDefinition> FilterRoleDefinitions(FilterRoleDefinitionOptions options)
        {
            if (options.RoleDefinitionId != Guid.Empty)
            {
                return new List<PSRoleDefinition> { GetRoleDefinition(options.RoleDefinitionId, options.Scope) };
            }
            else if (options.CustomOnly)
            {
                // Special case - if custom only flag is specified then you don't need to lookup on a specific id or name since it will be a bit redundant
                return FilterRoleDefinitionsByCustom(options.Scope);
            }
            else
            {
                // If RoleDefinition name is not specified (null/empty), service will handle it and return all roles
                return FilterRoleDefinitions(options.RoleDefinitionName, options.Scope);
            }
        }


        /// <summary>
        /// Fetches all existing role Definitions under scope. Please notice that if scope is null, this method will not return custom role.
        /// </summary>
        /// <returns>role Definitions</returns>
        public IEnumerable<PSRoleDefinition> ListRoleDefinitionsForScope(string scope, ulong first = ulong.MaxValue, ulong skip = 0)
        {
            var odataQuery = new ODataQuery<RoleDefinitionFilter>();
            return AuthorizationManagementClient.RoleDefinitions.List(scope ?? string.Empty, odataQuery)
                .Select(r => r.ToPSRoleDefinition());
        }

        /// <summary>
        /// Filters the existing role Definitions by CustomRole.
        /// </summary>
        /// <returns>The custom role Definitions</returns>
        public IEnumerable<PSRoleDefinition> FilterRoleDefinitionsByCustom(string scope, ulong first = ulong.MaxValue, ulong skip = 0)
        {
            var odataQuery = new ODataQuery<RoleDefinitionFilter>(filter => filter.Type == AuthorizationClientExtensions.CustomRole);
            return AuthorizationManagementClient.RoleDefinitions.List(scope, odataQuery: odataQuery)
                .Select(r => r.ToPSRoleDefinition());
        }

        /// <summary>
        /// Creates new role assignment.
        /// </summary>
        /// <param name="parameters">The create parameters</param>
        /// <param name="roleAssignmentId">The name of the role assignment. It can be any valid GUID.</param>
        /// <returns>The created role assignment object</returns>
        public PSRoleAssignment CreateRoleAssignment(FilterRoleAssignmentsOptions parameters, Guid roleAssignmentId = default(Guid))
        {
            var assigneeID = parameters.ADObjectFilter?.Id;
            var assigneeObjectType = parameters.ADObjectFilter?.ObjectType;

            if (string.IsNullOrWhiteSpace(assigneeObjectType) || string.IsNullOrWhiteSpace(assigneeID))
            {
                try
                {
                    var assigneeObject = ActiveDirectoryClient.GetADObject(parameters.ADObjectFilter);
                    assigneeID = assigneeID ?? assigneeObject?.Id;
                    assigneeObjectType = assigneeObjectType ?? assigneeObject?.Type;
                }
                catch (Common.MSGraph.Version1_0.DirectoryObjects.Models.OdataErrorException) when (!string.IsNullOrEmpty(assigneeID))
                {
                    // If assigneeID is not null, swallow OdataErrorException
                }
            }

            string principalId = assigneeID;
            roleAssignmentId = roleAssignmentId == default(Guid) ? Guid.NewGuid() : roleAssignmentId;
            string scope = parameters.Scope;
            string roleDefinitionId = string.IsNullOrEmpty(parameters.RoleDefinitionName)
                ? AuthorizationHelper.ConstructFullyQualifiedRoleDefinitionIdFromScopeAndIdAsGuid(scope, parameters.RoleDefinitionId)
                : AuthorizationHelper.ConstructFullyQualifiedRoleDefinitionIdFromScopeAndIdAsGuid(scope, GetSingleRoleDefinitionByName(parameters.RoleDefinitionName, scope).Id);
            parameters.Description = string.IsNullOrWhiteSpace(parameters.Description) ? null : parameters.Description;
            parameters.Condition = string.IsNullOrWhiteSpace(parameters.Condition) ? null : parameters.Condition;
            parameters.ConditionVersion = string.IsNullOrWhiteSpace(parameters.ConditionVersion) ? null : parameters.ConditionVersion;

            var createParameters = new RoleAssignmentCreateParameters
            {
                PrincipalId = principalId,
                PrincipalType = assigneeObjectType,
                RoleDefinitionId = roleDefinitionId,
                Description = parameters.Description,
                Condition = parameters.Condition,
                ConditionVersion = parameters.ConditionVersion
            };

            return AuthorizationManagementClient.RoleAssignments.Create(parameters.Scope, roleAssignmentId.ToString(), createParameters).ToPSRoleAssignment(this, ActiveDirectoryClient);
        }

        /// <summary>
        /// Filters role assignments based on the passed options.
        /// </summary>
        /// <param name="options">The filtering options</param>
        /// <param name="currentSubscription">The current subscription</param>
        /// <param name="first"></param>
        /// <param name="skip"></param>
        /// <returns>The filtered role assignments</returns>
        public List<PSRoleAssignment> FilterRoleAssignments(FilterRoleAssignmentsOptions options, string currentSubscription, ulong first = ulong.MaxValue, ulong skip = 0)
        {
            List<PSRoleAssignment> result = new List<PSRoleAssignment>();
            string principalId = null;
            PSADObject adObject = null;
            ODataQuery<RoleAssignmentFilter> odataQuery = null;
            // Reference:
            // https://learn.microsoft.com/en-us/azure/role-based-access-control/role-assignments-list-rest
            // https://learn.microsoft.com/en-us/azure/role-based-access-control/elevate-access-global-admin#elevate-access-for-a-global-administrator-1
            // scope is path variable in REST API. When scope is '/', query '$filter=atScope()' is required, or else it will throw BadRequest.
            Boolean needsAtScope = "/".Equals(options.Scope) || options.AtScope;
            Boolean needsFilterPrincipalId = false;
            if (options.ADObjectFilter?.HasFilter ?? false)
            {
                if (string.IsNullOrEmpty(options.ADObjectFilter.Id) || options.ExpandPrincipalGroups || options.IncludeClassicAdministrators)
                {
                    adObject = ActiveDirectoryClient.GetADObject(options.ADObjectFilter);

                    if (adObject == null)
                    {
                        throw new KeyNotFoundException(ProjectResources.PrincipalNotFound);
                    }
                }

                // Filter first by principal
                if (options.ExpandPrincipalGroups)
                {
                    if (!(adObject is PSADUser))
                    {
                        throw new InvalidOperationException(ProjectResources.ExpandGroupsNotSupported);
                    }

                    principalId = adObject.Id.ToString();
                    if (needsAtScope)
                    {
                        odataQuery = new ODataQuery<RoleAssignmentFilter>(f => (f.AtScope() && f.AssignedTo(principalId)));
                    }
                    else
                    {
                        odataQuery = new ODataQuery<RoleAssignmentFilter>(f => f.AssignedTo(principalId));
                    }
                }
                else
                {
                    principalId = string.IsNullOrEmpty(options.ADObjectFilter.Id) ? adObject.Id.ToString() : options.ADObjectFilter.Id;
                    if (needsAtScope)
                    {
                        /* $filter = principalId + eq + '{objectId}' Lists role assignments for a specified user, group, or service principal.
                         * If you use atScope() and principalId+eq + '{objectId}' together, it will throw exception because the API doesn't allow it.
                         * objectId could represent a group, so can't use atScope() and assignedTo('{objectId}') as alternative,
                         * must filter after the results return from server.
                         */
                        odataQuery = new ODataQuery<RoleAssignmentFilter>(f => f.AtScope());
                        needsFilterPrincipalId = true;
                    }
                    else
                    {
                        odataQuery = new ODataQuery<RoleAssignmentFilter>(f => f.PrincipalId == principalId);
                    }
                }
            }
            else if (needsAtScope)
            {
                odataQuery = new ODataQuery<RoleAssignmentFilter>(f => f.AtScope());
            }

            // list role assignments by principalId and scope first
            var tempResult = string.IsNullOrEmpty(options.Scope) ?
                AuthorizationManagementClient.RoleAssignments.ListForSubscription(odataQuery) :
                AuthorizationManagementClient.RoleAssignments.ListForScope(options.Scope, odataQuery);

            // Filter out by RoleId
            var roleAssignments = tempResult.FilterRoleAssignmentsOnRoleId(AuthorizationHelper.ConstructFullyQualifiedRoleDefinitionIdFromSubscriptionAndIdAsGuid(currentSubscription, options.RoleDefinitionId)).ToList();

            // Filter out by RoleDefinitionName
            result.AddRange(roleAssignments.ToPSRoleAssignments(this, ActiveDirectoryClient, options.Scope ?? AuthorizationHelper.GetSubscriptionScope(currentSubscription)));

            if (!string.IsNullOrEmpty(options.RoleDefinitionName))
            {
                result = result.Where(r => r.RoleDefinitionName?.Equals(options.RoleDefinitionName, StringComparison.OrdinalIgnoreCase) ?? false).ToList();
            }

            if (needsFilterPrincipalId)
            {
                result = result.Where(r => r.ObjectId?.Equals(principalId, StringComparison.OrdinalIgnoreCase) ?? false).ToList();
            }

            if (options.IncludeClassicAdministrators)
            {
                // Get classic administrator access assignments
                var classicAdministratorsSubscription = currentSubscription;
                if (options.Scope != null)
                {
                    classicAdministratorsSubscription = AuthorizationHelper.GetResourceSubscription(options.Scope) ?? currentSubscription;
                }

                List<ClassicAdministrator> classicAdministrators = new List<ClassicAdministrator>();
                if (currentSubscription != classicAdministratorsSubscription)
                {
                    var client = AzureSession.Instance.ClientFactory.CreateArmClient<AuthorizationManagementClient>(AzureRmProfileProvider.Instance.Profile.DefaultContext, AzureEnvironment.Endpoint.ResourceManager);
                    client.SubscriptionId = classicAdministratorsSubscription;
                    classicAdministrators = client.ClassicAdministrators.List().ToList();
                }
                else
                {
                    classicAdministrators = AuthorizationManagementClient.ClassicAdministrators.List().ToList();
                }

                List<PSRoleAssignment> classicAdministratorsAssignments = classicAdministrators.Select(a => a.ToPSRoleAssignment(classicAdministratorsSubscription)).ToList();

                // Filter by principal if provided
                if (options.ADObjectFilter.HasFilter)
                {
                    if (!(adObject is PSADUser))
                    {
                        throw new InvalidOperationException(ProjectResources.IncludeClassicAdminsNotSupported);
                    }

                    var userObject = adObject as PSADUser;
                    classicAdministratorsAssignments = classicAdministratorsAssignments.Where(c =>
                           c.DisplayName.Equals(userObject.UserPrincipalName, StringComparison.OrdinalIgnoreCase)).ToList();
                }

                result.AddRange(classicAdministratorsAssignments);
            }

            if (!string.IsNullOrEmpty(options.RoleAssignmentId))
            {
                result.RemoveAll(ra => !ra.RoleAssignmentId.EndsWith(options.RoleAssignmentId));
            }

            return result;
        }


        /// <summary>
        /// Updates a role assignment.
        /// </summary>
        /// <param name="roleAssignment">The role assignment to update.</param>
        /// <returns>The updated role assignment.</returns>
        public PSRoleAssignment UpdateRoleAssignment(PSRoleAssignment roleAssignment)
        {
            string principalType = null;

            // check added in case Set-AzRoleAssignment is called as a create operation but the user didn't add the object type
            if (string.IsNullOrEmpty(roleAssignment.ObjectType))
            {
                try
                {
                    var assignee = ActiveDirectoryClient.GetObjectByObjectId(roleAssignment.ObjectId);
                    principalType = assignee?.Type;
                }
                catch
                {
                    // Ignore
                }

            }
            else
            {
                principalType = roleAssignment.ObjectType;
            }

            string principalId = roleAssignment.ObjectId;
            var roleAssignmentId = roleAssignment.RoleAssignmentId.GuidFromFullyQualifiedId();
            string scope = roleAssignment.Scope;
            string roleDefinitionId = AuthorizationHelper.ConstructFullyQualifiedRoleDefinitionIdFromScopeAndIdAsGuid(scope, roleAssignment.RoleDefinitionId);
            var Description = string.IsNullOrWhiteSpace(roleAssignment.Description) ? null : roleAssignment.Description;
            var Condition = string.IsNullOrWhiteSpace(roleAssignment.Condition) ? null : roleAssignment.Condition;
            var ConditionVersion = string.IsNullOrWhiteSpace(roleAssignment.ConditionVersion) ? null : roleAssignment.ConditionVersion;
            var createParameters = new RoleAssignmentCreateParameters
            {
                PrincipalId = principalId.ToString(),
                RoleDefinitionId = roleDefinitionId,
                PrincipalType = principalType,
                Description = Description,
                Condition = Condition,
                ConditionVersion = ConditionVersion
            };

            return AuthorizationManagementClient.RoleAssignments.Create(scope, roleAssignmentId, createParameters).ToPSRoleAssignment(this, ActiveDirectoryClient);
        }

        /// <summary>
        /// Deletes a role assignments based on the used options.
        /// </summary>
        /// <param name="options">The role assignment filtering options</param>
        /// <param name="subscriptionId">Current subscription id</param>
        /// <returns>The deleted role assignments</returns>
        public IEnumerable<PSRoleAssignment> RemoveRoleAssignment(FilterRoleAssignmentsOptions options, string subscriptionId)
        {
            // Match role assignments at exact scope. Ideally, atmost 1 roleAssignment should match the criteria
            // but an edge case can have multiple role assignments to the same role or multiple role assignments to different roles, with same name.
            // The FilterRoleAssignments takes care of paging internally
            IEnumerable<PSRoleAssignment> roleAssignments = FilterRoleAssignments(options, currentSubscription: subscriptionId)
                                                .Where(ra => ra.Scope.TrimEnd('/').Equals(options.Scope.TrimEnd('/'), StringComparison.OrdinalIgnoreCase));

            if (roleAssignments == null || !roleAssignments.Any())
            {
                throw new KeyNotFoundException("The provided information does not map to a role assignment.");
            }
            else if (roleAssignments.Count() == 1)
            {
                AuthorizationManagementClient.RoleAssignments.DeleteById(roleAssignments.Single().RoleAssignmentId);
            }
            else if (roleAssignments.All(a => a.RoleDefinitionId == roleAssignments.First().RoleDefinitionId))
            {
                // All assignments are to the same roleDefinition Id.
                foreach (var assignment in roleAssignments)
                {
                    AuthorizationManagementClient.RoleAssignments.DeleteById(assignment.RoleAssignmentId);
                }
            }
            else
            {
                // Assignments to different roleDefintion Ids. This can happen only if roleDefinition name was provided and multiple roles exists with same name.
                throw new InvalidOperationException(string.Format(ProjectResources.MultipleRoleDefinitionsFoundWithSameName, options.RoleDefinitionName));
            }

            return roleAssignments;
        }

        public PSRoleDefinition GetSingleRoleDefinitionByName(string name, string scope)
        {
            IEnumerable<PSRoleDefinition> roles = FilterRoleDefinitions(name, scope);

            if (roles == null || !roles.Any())
            {
                throw new KeyNotFoundException(string.Format(ProjectResources.RoleDefinitionNotFound, name));
            }
            else if (roles.Count() > 1)
            {
                throw new InvalidOperationException(string.Format(ProjectResources.MultipleRoleDefinitionsFoundWithSameName, name));
            }

            return roles.First();
        }

        /// <summary>
        /// Deletes a role definition based on the id.
        /// </summary>
        /// <param name="roleDefinitionId">The role definition id to delete</param>
        /// <param name="scope">The scope of the role definition</param>
        /// <returns>The deleted role definition.</returns>
        public PSRoleDefinition RemoveRoleDefinition(Guid roleDefinitionId, string scope)
        {
            PSRoleDefinition roleDefinition = this.GetRoleDefinition(roleDefinitionId, scope);
            if (roleDefinition != null)
            {
                return AuthorizationManagementClient.RoleDefinitions.Delete(scope, roleDefinitionId.ToString()).ToPSRoleDefinition();
            }
            else
            {
                throw new KeyNotFoundException(string.Format(ProjectResources.RoleDefinitionWithIdNotFound, roleDefinitionId));
            }
        }

        /// <summary>
        /// Deletes a role definition based on the name.
        /// </summary>
        /// <param name="roleDefinitionName">The role definition name.</param>
        /// <param name="scope">The scope of the role definition</param>
        /// <returns>The deleted role definition.</returns>
        public PSRoleDefinition RemoveRoleDefinition(string roleDefinitionName, string scope)
        {
            PSRoleDefinition roleDefinition = this.GetSingleRoleDefinitionByName(roleDefinitionName, scope);
            return AuthorizationManagementClient.RoleDefinitions.Delete(scope, roleDefinition.Id).ToPSRoleDefinition();
        }

        public PSRoleDefinition RemoveRoleDefinition(FilterRoleDefinitionOptions options)
        {
            if (options.RoleDefinitionId != Guid.Empty)
            {
                return this.RemoveRoleDefinition(options.RoleDefinitionId, options.Scope);
            }
            else if (!string.IsNullOrEmpty(options.RoleDefinitionName))
            {
                return this.RemoveRoleDefinition(options.RoleDefinitionName, options.Scope);
            }
            else
            {
                throw new InvalidOperationException("RoleDefinition Name or Id should be specified.");
            }
        }

        /// <summary>
        /// Updates a role definiton.
        /// </summary>
        /// <param name="roleDefinition">The role definition to update.</param>
        /// <returns>The updated role definition.</returns>
        public PSRoleDefinition UpdateRoleDefinition(PSRoleDefinition roleDefinition)
        {
            Guid roleDefinitionId;
            if (!Guid.TryParse(roleDefinition.Id, out roleDefinitionId))
            {
                throw new InvalidOperationException(ProjectResources.RoleDefinitionIdShouldBeAGuid);
            }

            ValidateRoleDefinition(roleDefinition);

            PSRoleDefinition fetchedRoleDefinition = null;
            foreach (String scope in roleDefinition.AssignableScopes)
            {
                try
                {
                    fetchedRoleDefinition = this.GetRoleDefinition(roleDefinitionId, scope);
                }
                catch
                {
                }
                if (fetchedRoleDefinition != null)
                {
                    break;
                }
            }

            if (fetchedRoleDefinition == null)
            {
                throw new KeyNotFoundException(string.Format(ProjectResources.RoleDefinitionWithIdNotFound, roleDefinition.Id));
            }

            return this.CreateOrUpdateRoleDefinition(roleDefinitionId, roleDefinition);
        }

        /// <summary>
        /// Creates a new role definition.
        /// </summary>
        /// <param name="roleDefinition">The role definition to create.</param>
        /// <param name="roleDefinitionId">The role definition id to create.</param>
        /// <returns>The created role definition.</returns>
        public PSRoleDefinition CreateRoleDefinition(PSRoleDefinition roleDefinition, Guid roleDefinitionId = default(Guid))
        {
            ValidateRoleDefinition(roleDefinition);

            roleDefinitionId = roleDefinitionId == default(Guid) ? Guid.NewGuid() : roleDefinitionId;
            return this.CreateOrUpdateRoleDefinition(roleDefinitionId, roleDefinition);
        }

        /// <summary>
        /// Filters deny assignments based on the passed options.
        /// </summary>
        /// <param name="options">The filtering options</param>
        /// <param name="currentSubscription">The current subscription</param>
        /// <returns>The filtered deny assignments</returns>
        public List<PSDenyAssignment> FilterDenyAssignments(FilterDenyAssignmentsOptions options, string currentSubscription)
        {
            // Get a specified deny assignment by DenyAssignmentId
            if (!string.IsNullOrEmpty(options.DenyAssignmentId) &&
                (Guid.Empty != options.DenyAssignmentId.GetGuidFromId()))
            {
                var scope = !string.IsNullOrEmpty(options.Scope) ? options.Scope : AuthorizationHelper.GetScopeFromFullyQualifiedId(options.DenyAssignmentId) ?? AuthorizationHelper.GetSubscriptionScope(currentSubscription);
                return new List<PSDenyAssignment>
                {
                    AuthorizationManagementClient.DenyAssignments.Get(scope, options.DenyAssignmentId.GuidFromFullyQualifiedId()).ToPSDenyAssignment(ActiveDirectoryClient)
                };
            }

            // Filter deny assignments by given assumptions
            string principalId = null;
            PSADObject adObject = null;
            ODataQuery<DenyAssignmentFilter> odataQuery = null;

            if (!string.IsNullOrEmpty(options.DenyAssignmentName))
            {
                odataQuery = new ODataQuery<DenyAssignmentFilter>(item => item.DenyAssignmentName == options.DenyAssignmentName);
            }
            else if (options.ADObjectFilter.HasFilter)
            {
                if (string.IsNullOrEmpty(options.ADObjectFilter.Id))
                {
                    adObject = ActiveDirectoryClient.GetADObject(options.ADObjectFilter);

                    if (adObject == null)
                    {
                        throw new KeyNotFoundException(ProjectResources.PrincipalNotFound);
                    }
                }

                // Filter first by principal
                if (options.ExpandPrincipalGroups)
                {
                    try
                    {
                        adObject = adObject ?? ActiveDirectoryClient.GetObjectByObjectId(options.ADObjectFilter.Id);
                    }
                    catch (Common.MSGraph.Version1_0.DirectoryObjects.Models.OdataErrorException oe) when (OdataHelper.IsAuthorizationDeniedException(oe))
                    {
                        throw new InvalidOperationException(ProjectResources.InSufficientGraphPermission);
                    }
                    if (!(adObject is PSADUser))
                    {
                        throw new InvalidOperationException(ProjectResources.ExpandGroupsNotSupported);
                    }

                    principalId = adObject.Id.ToString();
                    odataQuery = new ODataQuery<DenyAssignmentFilter>(f => f.AssignedTo(principalId));
                }
                else
                {
                    principalId = string.IsNullOrEmpty(options.ADObjectFilter.Id) ? adObject.Id.ToString() : options.ADObjectFilter.Id;
                    odataQuery = new ODataQuery<DenyAssignmentFilter>(f => f.PrincipalId == principalId);
                }
            }

            return this.FilterDenyAssignmentsByScope(options, odataQuery, currentSubscription);
        }

        private List<PSDenyAssignment> FilterDenyAssignmentsByScope(FilterDenyAssignmentsOptions options, ODataQuery<DenyAssignmentFilter> odataQuery, string currentSubscription)
        {
            if (!string.IsNullOrEmpty(options.Scope))
            {
                return AuthorizationManagementClient.DenyAssignments.ListForScope(options.Scope, odataQuery).ToPSDenyAssignments(ActiveDirectoryClient).ToList();
            }

            return AuthorizationManagementClient.DenyAssignments.List(odataQuery).ToPSDenyAssignments(ActiveDirectoryClient).ToList();
        }

        private PSRoleDefinition CreateOrUpdateRoleDefinition(Guid roleDefinitionId, PSRoleDefinition roleDefinition)
        {
            PSRoleDefinition roleDef = null;
            var parameters = new RoleDefinition()
            {
                AssignableScopes = roleDefinition.AssignableScopes,
                Description = roleDefinition.Description,
                Permissions = ToRoleDefinitionPermissions(roleDefinition),
                RoleName = roleDefinition.Name,
                RoleType = "CustomRole"
            };

            try
            {
                roleDef = AuthorizationManagementClient.RoleDefinitions.CreateOrUpdate(
                    roleDefinition.AssignableScopes.First(), roleDefinitionId.ToString(), parameters).ToPSRoleDefinition();
            }
            catch (Hyak.Common.CloudException ce)
            {
                if (ce.Response.StatusCode == HttpStatusCode.Unauthorized &&
                    ce.Error.Code.Equals("TenantNotAllowed", StringComparison.InvariantCultureIgnoreCase))
                {
                    throw new InvalidOperationException("The tenant is not currently authorized to create/update Custom role definition. Please refer to http://aka.ms/customrolespreview for more details");
                }

                throw;
            }

            return roleDef;
        }

        private IList<Permission> ToRoleDefinitionPermissions(PSRoleDefinition role)
        {
            IList<Permission> permissions = new List<Permission>();

            if (role != null)
            {
                permissions.Add(new Permission(
                    role.Actions != null ? new List<string>(role.Actions) : new List<string>(),
                    role.NotActions != null ? new List<string>(role.NotActions) : new List<string>(),
                    role.DataActions != null ? new List<string>(role.DataActions) : new List<string>(),
                    role.NotDataActions != null ? new List<string>(role.NotDataActions) : new List<string>(),
                    role.Condition,
                    role.ConditionVersion));
            }

            return permissions;
        }

        private static void ValidateRoleDefinition(PSRoleDefinition roleDefinition)
        {
            if (string.IsNullOrWhiteSpace(roleDefinition.Name))
            {
                throw new ArgumentException(ProjectResources.InvalidRoleDefinitionName);
            }

            if (string.IsNullOrWhiteSpace(roleDefinition.Description))
            {
                throw new ArgumentException(ProjectResources.InvalidRoleDefinitionDescription);
            }

            if (roleDefinition.AssignableScopes == null || !roleDefinition.AssignableScopes.Any() || roleDefinition.AssignableScopes.Any(s => string.IsNullOrWhiteSpace(s)))
            {
                throw new ArgumentException(ProjectResources.InvalidAssignableScopes);
            }

            if ((roleDefinition.Actions == null || !roleDefinition.Actions.Any()) && (roleDefinition.DataActions == null || !roleDefinition.DataActions.Any()))
            {
                throw new ArgumentException(ProjectResources.InvalidActions);
            }

        }

        public static void ValidateScope(string scope, bool allowEmpty)
        {
            if (allowEmpty && string.IsNullOrEmpty(scope))
                return;

            if (scope.Length == 0 || !scope.StartsWith("/"))
            {
                throw new ArgumentException(string.Format(ProjectResources.ScopeShouldBeginWithSubscriptionsOrProviders, scope));
            }

            // "/" is a valid scope.
            if (string.Compare(scope, "/") == 0)
            {
                return;
            }

            // Allow scopes ending with "/" to keep it consistent with REST and CLI
            scope = scope.TrimEnd('/');

            var parts = scope.Substring(1).Split('/');   // Skip the leading '/'

            if (parts.Contains(string.Empty))
            {
                throw new ArgumentException(string.Format(ProjectResources.ScopeShouldHaveNoEmptyPart, scope));
            }

            int count = parts.Count();

            if (count % 2 != 0)
            {
                throw new ArgumentException(string.Format(ProjectResources.ScopeShouldHaveEvenNumberOfParts, scope));
            }

            // For Scope that on tenant level, without subscriptions, should start with "providers"
            // in this case we only ensure that the number of parts is even.
            if (string.Compare(parts[0], "providers", true) == 0)
            {
                return;
            }
            else if (string.Compare(parts[0], "subscriptions", true) != 0)
            {
                throw new ArgumentException(string.Format(ProjectResources.ScopeShouldBeginWithSubscriptionsOrProviders, scope));
            }

            // Now check the case that scope begins with '/subscriptions'

            if (count >= 4 && string.Compare(parts[2], "resourceGroups", true) != 0)
            {
                throw new ArgumentException(string.Format(ProjectResources.ScopeShouldBeginWithSubscriptionsAndResourceGroups, scope));
            }

            if (count >= 6)
            {
                if (string.Compare(parts[4], "providers", true) != 0)
                {
                    throw new ArgumentException(string.Format(ProjectResources.ScopeShouldBeginWithSubscriptionsAndResourceGroupsAndProviders, scope));
                }

                if (count < 8)
                {
                    throw new ArgumentException(string.Format(ProjectResources.ScopeShouldHaveAtLeastOnePairOfResourceTypeAndName, scope));
                }
            }

        }
    }
}