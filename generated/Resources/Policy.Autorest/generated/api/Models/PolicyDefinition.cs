// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Policy.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Extensions;

    /// <summary>The policy definition.</summary>
    public partial class PolicyDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinition,
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionInternal
    {

        /// <summary>The policy definition description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public string Description { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).Description; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).Description = value ?? null; }

        /// <summary>The display name of the policy definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.FormatTable(Index = 2)]
        public string DisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).DisplayName = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The ID of the policy definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public string Id { get => this._id; }

        /// <summary>
        /// The policy definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesMetadata Metadata { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).Metadata; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).Metadata = value ?? null /* model class */; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionProperties Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.PolicyDefinitionProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionInternal.SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.SystemData()); set { {_systemData = value;} } }

        /// <summary>Internal Acessors for SystemDataCreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionInternal.SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).CreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataCreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionInternal.SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).CreatedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataCreatedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionInternal.SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).CreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).CreatedByType = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionInternal.SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).LastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).LastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>Internal Acessors for SystemDataLastModifiedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionInternal.SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).LastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).LastModifiedBy = value ?? null; }

        /// <summary>Internal Acessors for SystemDataLastModifiedByType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionInternal.SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).LastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).LastModifiedByType = value ?? null; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>
        /// The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public string Mode { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).Mode; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).Mode = value ?? null; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the policy definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.FormatTable(Index = 0)]
        public string Name { get => this._name; }

        /// <summary>
        /// The parameter definitions for parameters used in the policy rule. The keys are the parameter names.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterDefinitions Parameter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).Parameter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).Parameter = value ?? null /* model class */; }

        /// <summary>The policy rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesPolicyRule PolicyRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).PolicyRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).PolicyRule = value ?? null /* model class */; }

        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.FormatTable(Index = 1)]
        public string PolicyType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).PolicyType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).PolicyType = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionProperties _property;

        /// <summary>The policy definition properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.PolicyDefinitionProperties()); set => this._property = value; }

        /// <summary>Backing field for <see cref="SystemData" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemData _systemData;

        /// <summary>The system metadata relating to this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemData SystemData { get => (this._systemData = this._systemData ?? new Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.SystemData()); }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).CreatedAt; }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).CreatedBy; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).CreatedByType; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).LastModifiedAt; }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).LastModifiedBy; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemDataInternal)SystemData).LastModifiedByType; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the resource (Microsoft.Authorization/policyDefinitions).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public string Type { get => this._type; }

        /// <summary>The policy definition version in #.#.# format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public string Version { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).Version; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).Version = value ?? null; }

        /// <summary>A list of available versions for this policy definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Origin(Microsoft.Azure.PowerShell.Cmdlets.Policy.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.DoNotFormat]
        public System.Collections.Generic.List<string> Versions { get => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).Versions; set => ((Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesInternal)Property).Versions = value ?? null /* arrayOf */; }

        /// <summary>Creates an new <see cref="PolicyDefinition" /> instance.</summary>
        public PolicyDefinition()
        {

        }
    }
    /// The policy definition.
    public partial interface IPolicyDefinition :
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.IJsonSerializable
    {
        /// <summary>The policy definition description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The policy definition description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The display name of the policy definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The display name of the policy definition.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The ID of the policy definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The ID of the policy definition.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>
        /// The policy definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The policy definition metadata.  Metadata is an open ended object and is typically a collection of key value pairs.",
        SerializedName = @"metadata",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesMetadata) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesMetadata Metadata { get; set; }
        /// <summary>
        /// The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(string) })]
        string Mode { get; set; }
        /// <summary>The name of the policy definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The name of the policy definition.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>
        /// The parameter definitions for parameters used in the policy rule. The keys are the parameter names.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The parameter definitions for parameters used in the policy rule. The keys are the parameter names.",
        SerializedName = @"parameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterDefinitions) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterDefinitions Parameter { get; set; }
        /// <summary>The policy rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The policy rule.",
        SerializedName = @"policyRule",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesPolicyRule) })]
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesPolicyRule PolicyRule { get; set; }
        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.",
        SerializedName = @"policyType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Policy.PSArgumentCompleterAttribute("NotSpecified", "BuiltIn", "Custom", "Static")]
        string PolicyType { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource creation (UTC).",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataCreatedAt { get;  }
        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity that created the resource.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataCreatedBy { get;  }
        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that created the resource.",
        SerializedName = @"createdByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Policy.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataCreatedByType { get;  }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The timestamp of resource last modification (UTC)",
        SerializedName = @"lastModifiedAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? SystemDataLastModifiedAt { get;  }
        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The identity that last modified the resource.",
        SerializedName = @"lastModifiedBy",
        PossibleTypes = new [] { typeof(string) })]
        string SystemDataLastModifiedBy { get;  }
        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of identity that last modified the resource.",
        SerializedName = @"lastModifiedByType",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Policy.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataLastModifiedByType { get;  }
        /// <summary>The type of the resource (Microsoft.Authorization/policyDefinitions).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The type of the resource (Microsoft.Authorization/policyDefinitions).",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }
        /// <summary>The policy definition version in #.#.# format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The policy definition version in #.#.# format.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }
        /// <summary>A list of available versions for this policy definition.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Policy.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of available versions for this policy definition.",
        SerializedName = @"versions",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> Versions { get; set; }

    }
    /// The policy definition.
    internal partial interface IPolicyDefinitionInternal

    {
        /// <summary>The policy definition description.</summary>
        string Description { get; set; }
        /// <summary>The display name of the policy definition.</summary>
        string DisplayName { get; set; }
        /// <summary>The ID of the policy definition.</summary>
        string Id { get; set; }
        /// <summary>
        /// The policy definition metadata. Metadata is an open ended object and is typically a collection of key value pairs.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesMetadata Metadata { get; set; }
        /// <summary>
        /// The policy definition mode. Some examples are All, Indexed, Microsoft.KeyVault.Data.
        /// </summary>
        string Mode { get; set; }
        /// <summary>The name of the policy definition.</summary>
        string Name { get; set; }
        /// <summary>
        /// The parameter definitions for parameters used in the policy rule. The keys are the parameter names.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IParameterDefinitions Parameter { get; set; }
        /// <summary>The policy rule.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionPropertiesPolicyRule PolicyRule { get; set; }
        /// <summary>
        /// The type of policy definition. Possible values are NotSpecified, BuiltIn, Custom, and Static.
        /// </summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Policy.PSArgumentCompleterAttribute("NotSpecified", "BuiltIn", "Custom", "Static")]
        string PolicyType { get; set; }
        /// <summary>The policy definition properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.IPolicyDefinitionProperties Property { get; set; }
        /// <summary>The system metadata relating to this resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Policy.Models.ISystemData SystemData { get; set; }
        /// <summary>The timestamp of resource creation (UTC).</summary>
        global::System.DateTime? SystemDataCreatedAt { get; set; }
        /// <summary>The identity that created the resource.</summary>
        string SystemDataCreatedBy { get; set; }
        /// <summary>The type of identity that created the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Policy.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataCreatedByType { get; set; }
        /// <summary>The timestamp of resource last modification (UTC)</summary>
        global::System.DateTime? SystemDataLastModifiedAt { get; set; }
        /// <summary>The identity that last modified the resource.</summary>
        string SystemDataLastModifiedBy { get; set; }
        /// <summary>The type of identity that last modified the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Policy.PSArgumentCompleterAttribute("User", "Application", "ManagedIdentity", "Key")]
        string SystemDataLastModifiedByType { get; set; }
        /// <summary>The type of the resource (Microsoft.Authorization/policyDefinitions).</summary>
        string Type { get; set; }
        /// <summary>The policy definition version in #.#.# format.</summary>
        string Version { get; set; }
        /// <summary>A list of available versions for this policy definition.</summary>
        System.Collections.Generic.List<string> Versions { get; set; }

    }
}