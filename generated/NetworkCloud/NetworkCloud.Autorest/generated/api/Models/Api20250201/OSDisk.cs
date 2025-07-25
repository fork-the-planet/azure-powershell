// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>OsDisk represents configuration of the boot disk.</summary>
    public partial class OSDisk :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IOSDisk,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IOSDiskInternal
    {

        /// <summary>Backing field for <see cref="CreateOption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.OSDiskCreateOption? _createOption;

        /// <summary>The strategy for creating the OS disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.OSDiskCreateOption? CreateOption { get => this._createOption; set => this._createOption = value; }

        /// <summary>Backing field for <see cref="DeleteOption" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.OSDiskDeleteOption? _deleteOption;

        /// <summary>The strategy for deleting the OS disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.OSDiskDeleteOption? DeleteOption { get => this._deleteOption; set => this._deleteOption = value; }

        /// <summary>Backing field for <see cref="DiskSizeGb" /> property.</summary>
        private long _diskSizeGb;

        /// <summary>
        /// The size of the disk. Required if the createOption is Ephemeral. Allocations are measured in gibibytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public long DiskSizeGb { get => this._diskSizeGb; set => this._diskSizeGb = value; }

        /// <summary>Creates an new <see cref="OSDisk" /> instance.</summary>
        public OSDisk()
        {

        }
    }
    /// OsDisk represents configuration of the boot disk.
    public partial interface IOSDisk :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>The strategy for creating the OS disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The strategy for creating the OS disk.",
        SerializedName = @"createOption",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.OSDiskCreateOption) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.OSDiskCreateOption? CreateOption { get; set; }
        /// <summary>The strategy for deleting the OS disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The strategy for deleting the OS disk.",
        SerializedName = @"deleteOption",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.OSDiskDeleteOption) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.OSDiskDeleteOption? DeleteOption { get; set; }
        /// <summary>
        /// The size of the disk. Required if the createOption is Ephemeral. Allocations are measured in gibibytes.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The size of the disk. Required if the createOption is Ephemeral. Allocations are measured in gibibytes.",
        SerializedName = @"diskSizeGB",
        PossibleTypes = new [] { typeof(long) })]
        long DiskSizeGb { get; set; }

    }
    /// OsDisk represents configuration of the boot disk.
    internal partial interface IOSDiskInternal

    {
        /// <summary>The strategy for creating the OS disk.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.OSDiskCreateOption? CreateOption { get; set; }
        /// <summary>The strategy for deleting the OS disk.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.OSDiskDeleteOption? DeleteOption { get; set; }
        /// <summary>
        /// The size of the disk. Required if the createOption is Ephemeral. Allocations are measured in gibibytes.
        /// </summary>
        long DiskSizeGb { get; set; }

    }
}