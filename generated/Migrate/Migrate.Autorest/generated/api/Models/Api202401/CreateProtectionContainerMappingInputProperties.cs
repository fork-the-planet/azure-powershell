// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>Configure pairing input properties.</summary>
    public partial class CreateProtectionContainerMappingInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ICreateProtectionContainerMappingInputProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ICreateProtectionContainerMappingInputPropertiesInternal
    {

        /// <summary>Backing field for <see cref="PolicyId" /> property.</summary>
        private string _policyId;

        /// <summary>Applicable policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string PolicyId { get => this._policyId; set => this._policyId = value; }

        /// <summary>Backing field for <see cref="ProviderSpecificInput" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationProviderSpecificContainerMappingInput _providerSpecificInput;

        /// <summary>Provider specific input for pairing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationProviderSpecificContainerMappingInput ProviderSpecificInput { get => (this._providerSpecificInput = this._providerSpecificInput ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.ReplicationProviderSpecificContainerMappingInput()); set => this._providerSpecificInput = value; }

        /// <summary>Backing field for <see cref="TargetProtectionContainerId" /> property.</summary>
        private string _targetProtectionContainerId;

        /// <summary>The target unique protection container name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetProtectionContainerId { get => this._targetProtectionContainerId; set => this._targetProtectionContainerId = value; }

        /// <summary>
        /// Creates an new <see cref="CreateProtectionContainerMappingInputProperties" /> instance.
        /// </summary>
        public CreateProtectionContainerMappingInputProperties()
        {

        }
    }
    /// Configure pairing input properties.
    public partial interface ICreateProtectionContainerMappingInputProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>Applicable policy.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Applicable policy.",
        SerializedName = @"policyId",
        PossibleTypes = new [] { typeof(string) })]
        string PolicyId { get; set; }
        /// <summary>Provider specific input for pairing.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provider specific input for pairing.",
        SerializedName = @"providerSpecificInput",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationProviderSpecificContainerMappingInput) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationProviderSpecificContainerMappingInput ProviderSpecificInput { get; set; }
        /// <summary>The target unique protection container name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target unique protection container name.",
        SerializedName = @"targetProtectionContainerId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetProtectionContainerId { get; set; }

    }
    /// Configure pairing input properties.
    internal partial interface ICreateProtectionContainerMappingInputPropertiesInternal

    {
        /// <summary>Applicable policy.</summary>
        string PolicyId { get; set; }
        /// <summary>Provider specific input for pairing.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IReplicationProviderSpecificContainerMappingInput ProviderSpecificInput { get; set; }
        /// <summary>The target unique protection container name.</summary>
        string TargetProtectionContainerId { get; set; }

    }
}