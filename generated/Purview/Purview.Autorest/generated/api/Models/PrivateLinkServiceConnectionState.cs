// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>The private link service connection state.</summary>
    public partial class PrivateLinkServiceConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.IPrivateLinkServiceConnectionState,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.IPrivateLinkServiceConnectionStateInternal
    {

        /// <summary>Backing field for <see cref="ActionsRequired" /> property.</summary>
        private string _actionsRequired;

        /// <summary>The required actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string ActionsRequired { get => this._actionsRequired; set => this._actionsRequired = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>The status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="PrivateLinkServiceConnectionState" /> instance.</summary>
        public PrivateLinkServiceConnectionState()
        {

        }
    }
    /// The private link service connection state.
    public partial interface IPrivateLinkServiceConnectionState :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>The required actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The required actions.",
        SerializedName = @"actionsRequired",
        PossibleTypes = new [] { typeof(string) })]
        string ActionsRequired { get; set; }
        /// <summary>The description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The description.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The status.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.PSArgumentCompleterAttribute("Unknown", "Pending", "Approved", "Rejected", "Disconnected")]
        string Status { get; set; }

    }
    /// The private link service connection state.
    internal partial interface IPrivateLinkServiceConnectionStateInternal

    {
        /// <summary>The required actions.</summary>
        string ActionsRequired { get; set; }
        /// <summary>The description.</summary>
        string Description { get; set; }
        /// <summary>The status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Purview.PSArgumentCompleterAttribute("Unknown", "Pending", "Approved", "Rejected", "Disconnected")]
        string Status { get; set; }

    }
}