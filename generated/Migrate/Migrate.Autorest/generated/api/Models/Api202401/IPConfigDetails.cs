// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    public partial class IPConfigDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IIPConfigDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IIPConfigDetailsInternal
    {

        /// <summary>Backing field for <see cref="IPAddressType" /> property.</summary>
        private string _iPAddressType;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string IPAddressType { get => this._iPAddressType; set => this._iPAddressType = value; }

        /// <summary>Backing field for <see cref="IsPrimary" /> property.</summary>
        private bool? _isPrimary;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public bool? IsPrimary { get => this._isPrimary; set => this._isPrimary = value; }

        /// <summary>Backing field for <see cref="IsSeletedForFailover" /> property.</summary>
        private bool? _isSeletedForFailover;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public bool? IsSeletedForFailover { get => this._isSeletedForFailover; set => this._isSeletedForFailover = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="RecoveryIPAddressType" /> property.</summary>
        private string _recoveryIPAddressType;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryIPAddressType { get => this._recoveryIPAddressType; set => this._recoveryIPAddressType = value; }

        /// <summary>Backing field for <see cref="RecoveryLbBackendAddressPoolId" /> property.</summary>
        private string[] _recoveryLbBackendAddressPoolId;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] RecoveryLbBackendAddressPoolId { get => this._recoveryLbBackendAddressPoolId; set => this._recoveryLbBackendAddressPoolId = value; }

        /// <summary>Backing field for <see cref="RecoveryPublicIPAddressId" /> property.</summary>
        private string _recoveryPublicIPAddressId;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryPublicIPAddressId { get => this._recoveryPublicIPAddressId; set => this._recoveryPublicIPAddressId = value; }

        /// <summary>Backing field for <see cref="RecoveryStaticIPAddress" /> property.</summary>
        private string _recoveryStaticIPAddress;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoveryStaticIPAddress { get => this._recoveryStaticIPAddress; set => this._recoveryStaticIPAddress = value; }

        /// <summary>Backing field for <see cref="RecoverySubnetName" /> property.</summary>
        private string _recoverySubnetName;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string RecoverySubnetName { get => this._recoverySubnetName; set => this._recoverySubnetName = value; }

        /// <summary>Backing field for <see cref="StaticIPAddress" /> property.</summary>
        private string _staticIPAddress;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string StaticIPAddress { get => this._staticIPAddress; set => this._staticIPAddress = value; }

        /// <summary>Backing field for <see cref="SubnetName" /> property.</summary>
        private string _subnetName;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string SubnetName { get => this._subnetName; set => this._subnetName = value; }

        /// <summary>Backing field for <see cref="TfoLbBackendAddressPoolId" /> property.</summary>
        private string[] _tfoLbBackendAddressPoolId;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] TfoLbBackendAddressPoolId { get => this._tfoLbBackendAddressPoolId; set => this._tfoLbBackendAddressPoolId = value; }

        /// <summary>Backing field for <see cref="TfoPublicIPAddressId" /> property.</summary>
        private string _tfoPublicIPAddressId;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TfoPublicIPAddressId { get => this._tfoPublicIPAddressId; set => this._tfoPublicIPAddressId = value; }

        /// <summary>Backing field for <see cref="TfoStaticIPAddress" /> property.</summary>
        private string _tfoStaticIPAddress;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TfoStaticIPAddress { get => this._tfoStaticIPAddress; set => this._tfoStaticIPAddress = value; }

        /// <summary>Backing field for <see cref="TfoSubnetName" /> property.</summary>
        private string _tfoSubnetName;

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TfoSubnetName { get => this._tfoSubnetName; set => this._tfoSubnetName = value; }

        /// <summary>Creates an new <see cref="IPConfigDetails" /> instance.</summary>
        public IPConfigDetails()
        {

        }
    }
    public partial interface IIPConfigDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"ipAddressType",
        PossibleTypes = new [] { typeof(string) })]
        string IPAddressType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isPrimary",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsPrimary { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"isSeletedForFailover",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSeletedForFailover { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoveryIPAddressType",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryIPAddressType { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoveryLBBackendAddressPoolIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] RecoveryLbBackendAddressPoolId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoveryPublicIPAddressId",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryPublicIPAddressId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoveryStaticIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string RecoveryStaticIPAddress { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"recoverySubnetName",
        PossibleTypes = new [] { typeof(string) })]
        string RecoverySubnetName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"staticIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string StaticIPAddress { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"subnetName",
        PossibleTypes = new [] { typeof(string) })]
        string SubnetName { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tfoLBBackendAddressPoolIds",
        PossibleTypes = new [] { typeof(string) })]
        string[] TfoLbBackendAddressPoolId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tfoPublicIPAddressId",
        PossibleTypes = new [] { typeof(string) })]
        string TfoPublicIPAddressId { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tfoStaticIPAddress",
        PossibleTypes = new [] { typeof(string) })]
        string TfoStaticIPAddress { get; set; }

        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"tfoSubnetName",
        PossibleTypes = new [] { typeof(string) })]
        string TfoSubnetName { get; set; }

    }
    internal partial interface IIPConfigDetailsInternal

    {
        string IPAddressType { get; set; }

        bool? IsPrimary { get; set; }

        bool? IsSeletedForFailover { get; set; }

        string Name { get; set; }

        string RecoveryIPAddressType { get; set; }

        string[] RecoveryLbBackendAddressPoolId { get; set; }

        string RecoveryPublicIPAddressId { get; set; }

        string RecoveryStaticIPAddress { get; set; }

        string RecoverySubnetName { get; set; }

        string StaticIPAddress { get; set; }

        string SubnetName { get; set; }

        string[] TfoLbBackendAddressPoolId { get; set; }

        string TfoPublicIPAddressId { get; set; }

        string TfoStaticIPAddress { get; set; }

        string TfoSubnetName { get; set; }

    }
}