// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Extensions;

    /// <summary>Properties specific to Endpoints</summary>
    public partial class EndpointProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IEndpointProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IEndpointPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Attribute" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes> _attribute;

        /// <summary>Additional attributes for the entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes> Attribute { get => this._attribute; set => this._attribute = value; }

        /// <summary>Backing field for <see cref="BranchId" /> property.</summary>
        private string _branchId;

        /// <summary>The ID of the branch this endpoint belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string BranchId { get => this._branchId; set => this._branchId = value; }

        /// <summary>Backing field for <see cref="CreatedAt" /> property.</summary>
        private string _createdAt;

        /// <summary>Timestamp indicating when the entity was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string CreatedAt { get => this._createdAt; }

        /// <summary>Backing field for <see cref="EndpointType" /> property.</summary>
        private string _endpointType;

        /// <summary>The type of the endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string EndpointType { get => this._endpointType; set => this._endpointType = value; }

        /// <summary>Backing field for <see cref="EntityId" /> property.</summary>
        private string _entityId;

        /// <summary>Unique identifier for the entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string EntityId { get => this._entityId; }

        /// <summary>Backing field for <see cref="EntityName" /> property.</summary>
        private string _entityName;

        /// <summary>Name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string EntityName { get => this._entityName; set => this._entityName = value; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IEndpointPropertiesInternal.CreatedAt { get => this._createdAt; set { {_createdAt = value;} } }

        /// <summary>Internal Acessors for EntityId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IEndpointPropertiesInternal.EntityId { get => this._entityId; set { {_entityId = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IEndpointPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProjectId" /> property.</summary>
        private string _projectId;

        /// <summary>The ID of the project this endpoint belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string ProjectId { get => this._projectId; set => this._projectId = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Origin(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Creates an new <see cref="EndpointProperties" /> instance.</summary>
        public EndpointProperties()
        {

        }
    }
    /// Properties specific to Endpoints
    public partial interface IEndpointProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.IJsonSerializable
    {
        /// <summary>Additional attributes for the entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Additional attributes for the entity",
        SerializedName = @"attributes",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes> Attribute { get; set; }
        /// <summary>The ID of the branch this endpoint belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the branch this endpoint belongs to",
        SerializedName = @"branchId",
        PossibleTypes = new [] { typeof(string) })]
        string BranchId { get; set; }
        /// <summary>Timestamp indicating when the entity was created</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Timestamp indicating when the entity was created",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedAt { get;  }
        /// <summary>The type of the endpoint</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of the endpoint",
        SerializedName = @"endpointType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("read_only", "read_write")]
        string EndpointType { get; set; }
        /// <summary>Unique identifier for the entity</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Unique identifier for the entity",
        SerializedName = @"entityId",
        PossibleTypes = new [] { typeof(string) })]
        string EntityId { get;  }
        /// <summary>Name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the resource",
        SerializedName = @"entityName",
        PossibleTypes = new [] { typeof(string) })]
        string EntityName { get; set; }
        /// <summary>The ID of the project this endpoint belongs to</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the project this endpoint belongs to",
        SerializedName = @"projectId",
        PossibleTypes = new [] { typeof(string) })]
        string ProjectId { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get;  }

    }
    /// Properties specific to Endpoints
    internal partial interface IEndpointPropertiesInternal

    {
        /// <summary>Additional attributes for the entity</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.Models.IAttributes> Attribute { get; set; }
        /// <summary>The ID of the branch this endpoint belongs to</summary>
        string BranchId { get; set; }
        /// <summary>Timestamp indicating when the entity was created</summary>
        string CreatedAt { get; set; }
        /// <summary>The type of the endpoint</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("read_only", "read_write")]
        string EndpointType { get; set; }
        /// <summary>Unique identifier for the entity</summary>
        string EntityId { get; set; }
        /// <summary>Name of the resource</summary>
        string EntityName { get; set; }
        /// <summary>The ID of the project this endpoint belongs to</summary>
        string ProjectId { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.NeonPostgres.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled")]
        string ProvisioningState { get; set; }

    }
}