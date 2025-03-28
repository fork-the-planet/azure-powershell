// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>Import Route Policy Configuration.</summary>
    public partial class ImportRoutePolicyInformation :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IImportRoutePolicyInformation,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IImportRoutePolicyInformationInternal
    {

        /// <summary>Backing field for <see cref="ImportIpv4RoutePolicyId" /> property.</summary>
        private string _importIpv4RoutePolicyId;

        /// <summary>Import IPv4 Route Policy Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string ImportIpv4RoutePolicyId { get => this._importIpv4RoutePolicyId; set => this._importIpv4RoutePolicyId = value; }

        /// <summary>Backing field for <see cref="ImportIpv6RoutePolicyId" /> property.</summary>
        private string _importIpv6RoutePolicyId;

        /// <summary>Import IPv6 Route Policy Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string ImportIpv6RoutePolicyId { get => this._importIpv6RoutePolicyId; set => this._importIpv6RoutePolicyId = value; }

        /// <summary>Creates an new <see cref="ImportRoutePolicyInformation" /> instance.</summary>
        public ImportRoutePolicyInformation()
        {

        }
    }
    /// Import Route Policy Configuration.
    public partial interface IImportRoutePolicyInformation :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable
    {
        /// <summary>Import IPv4 Route Policy Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Import IPv4 Route Policy Id.",
        SerializedName = @"importIpv4RoutePolicyId",
        PossibleTypes = new [] { typeof(string) })]
        string ImportIpv4RoutePolicyId { get; set; }
        /// <summary>Import IPv6 Route Policy Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Import IPv6 Route Policy Id.",
        SerializedName = @"importIpv6RoutePolicyId",
        PossibleTypes = new [] { typeof(string) })]
        string ImportIpv6RoutePolicyId { get; set; }

    }
    /// Import Route Policy Configuration.
    internal partial interface IImportRoutePolicyInformationInternal

    {
        /// <summary>Import IPv4 Route Policy Id.</summary>
        string ImportIpv4RoutePolicyId { get; set; }
        /// <summary>Import IPv6 Route Policy Id.</summary>
        string ImportIpv6RoutePolicyId { get; set; }

    }
}