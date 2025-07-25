// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Extensions;

    /// <summary>User resource properties used for updates.</summary>
    public partial class UserUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUserUpdateProperties,
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Models.IUserUpdatePropertiesInternal
    {

        /// <summary>Backing field for <see cref="AdditionalUsageQuota" /> property.</summary>
        private global::System.TimeSpan? _additionalUsageQuota;

        /// <summary>
        /// The amount of usage quota time the user gets in addition to the lab usage quota.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.LabServices.PropertyOrigin.Owned)]
        public global::System.TimeSpan? AdditionalUsageQuota { get => this._additionalUsageQuota; set => this._additionalUsageQuota = value; }

        /// <summary>Creates an new <see cref="UserUpdateProperties" /> instance.</summary>
        public UserUpdateProperties()
        {

        }
    }
    /// User resource properties used for updates.
    public partial interface IUserUpdateProperties :
        Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The amount of usage quota time the user gets in addition to the lab usage quota.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.LabServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The amount of usage quota time the user gets in addition to the lab usage quota.",
        SerializedName = @"additionalUsageQuota",
        PossibleTypes = new [] { typeof(global::System.TimeSpan) })]
        global::System.TimeSpan? AdditionalUsageQuota { get; set; }

    }
    /// User resource properties used for updates.
    internal partial interface IUserUpdatePropertiesInternal

    {
        /// <summary>
        /// The amount of usage quota time the user gets in addition to the lab usage quota.
        /// </summary>
        global::System.TimeSpan? AdditionalUsageQuota { get; set; }

    }
}