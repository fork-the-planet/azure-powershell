// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>The JSON object that contains the properties required to create a profile.</summary>
    public partial class ProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesInternal
    {

        /// <summary>Backing field for <see cref="ExtendedProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesExtendedProperties _extendedProperty;

        /// <summary>Key-Value pair representing additional properties for profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesExtendedProperties ExtendedProperty { get => (this._extendedProperty = this._extendedProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.ProfilePropertiesExtendedProperties()); }

        /// <summary>Backing field for <see cref="FrontDoorId" /> property.</summary>
        private string _frontDoorId;

        /// <summary>The Id of the frontdoor.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public string FrontDoorId { get => this._frontDoorId; }

        /// <summary>Backing field for <see cref="LogScrubbing" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbing _logScrubbing;

        /// <summary>Defines rules that scrub sensitive fields in the Azure Front Door profile logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbing LogScrubbing { get => (this._logScrubbing = this._logScrubbing ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.ProfileLogScrubbing()); set => this._logScrubbing = value; }

        /// <summary>List of log scrubbing rules applied to the Azure Front Door profile logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileScrubbingRules[] LogScrubbingRule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbingInternal)LogScrubbing).ScrubbingRule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbingInternal)LogScrubbing).ScrubbingRule = value ?? null /* arrayOf */; }

        /// <summary>State of the log scrubbing config. Default value is Enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileScrubbingState? LogScrubbingState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbingInternal)LogScrubbing).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbingInternal)LogScrubbing).State = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileScrubbingState)""); }

        /// <summary>Internal Acessors for ExtendedProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesExtendedProperties Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesInternal.ExtendedProperty { get => (this._extendedProperty = this._extendedProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.ProfilePropertiesExtendedProperties()); set { {_extendedProperty = value;} } }

        /// <summary>Internal Acessors for FrontDoorId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesInternal.FrontDoorId { get => this._frontDoorId; set { {_frontDoorId = value;} } }

        /// <summary>Internal Acessors for LogScrubbing</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbing Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesInternal.LogScrubbing { get => (this._logScrubbing = this._logScrubbing ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.ProfileLogScrubbing()); set { {_logScrubbing = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ResourceState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileResourceState? Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesInternal.ResourceState { get => this._resourceState; set { {_resourceState = value;} } }

        /// <summary>Backing field for <see cref="OriginResponseTimeoutSecond" /> property.</summary>
        private int? _originResponseTimeoutSecond;

        /// <summary>
        /// Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public int? OriginResponseTimeoutSecond { get => this._originResponseTimeoutSecond; set => this._originResponseTimeoutSecond = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileProvisioningState? _provisioningState;

        /// <summary>Provisioning status of the profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ResourceState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileResourceState? _resourceState;

        /// <summary>Resource status of the profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileResourceState? ResourceState { get => this._resourceState; }

        /// <summary>Creates an new <see cref="ProfileProperties" /> instance.</summary>
        public ProfileProperties()
        {

        }
    }
    /// The JSON object that contains the properties required to create a profile.
    public partial interface IProfileProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>Key-Value pair representing additional properties for profiles.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Key-Value pair representing additional properties for profiles.",
        SerializedName = @"extendedProperties",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesExtendedProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesExtendedProperties ExtendedProperty { get;  }
        /// <summary>The Id of the frontdoor.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The Id of the frontdoor.",
        SerializedName = @"frontDoorId",
        PossibleTypes = new [] { typeof(string) })]
        string FrontDoorId { get;  }
        /// <summary>List of log scrubbing rules applied to the Azure Front Door profile logs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of log scrubbing rules applied to the Azure Front Door profile logs.",
        SerializedName = @"scrubbingRules",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileScrubbingRules) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileScrubbingRules[] LogScrubbingRule { get; set; }
        /// <summary>State of the log scrubbing config. Default value is Enabled.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of the log scrubbing config. Default value is Enabled.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileScrubbingState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileScrubbingState? LogScrubbingState { get; set; }
        /// <summary>
        /// Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.",
        SerializedName = @"originResponseTimeoutSeconds",
        PossibleTypes = new [] { typeof(int) })]
        int? OriginResponseTimeoutSecond { get; set; }
        /// <summary>Provisioning status of the profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning status of the profile.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileProvisioningState? ProvisioningState { get;  }
        /// <summary>Resource status of the profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource status of the profile.",
        SerializedName = @"resourceState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileResourceState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileResourceState? ResourceState { get;  }

    }
    /// The JSON object that contains the properties required to create a profile.
    internal partial interface IProfilePropertiesInternal

    {
        /// <summary>Key-Value pair representing additional properties for profiles.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfilePropertiesExtendedProperties ExtendedProperty { get; set; }
        /// <summary>The Id of the frontdoor.</summary>
        string FrontDoorId { get; set; }
        /// <summary>Defines rules that scrub sensitive fields in the Azure Front Door profile logs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileLogScrubbing LogScrubbing { get; set; }
        /// <summary>List of log scrubbing rules applied to the Azure Front Door profile logs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.Api20240201.IProfileScrubbingRules[] LogScrubbingRule { get; set; }
        /// <summary>State of the log scrubbing config. Default value is Enabled.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileScrubbingState? LogScrubbingState { get; set; }
        /// <summary>
        /// Send and receive timeout on forwarding request to the origin. When timeout is reached, the request fails and returns.
        /// </summary>
        int? OriginResponseTimeoutSecond { get; set; }
        /// <summary>Provisioning status of the profile.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileProvisioningState? ProvisioningState { get; set; }
        /// <summary>Resource status of the profile.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Support.ProfileResourceState? ResourceState { get; set; }

    }
}