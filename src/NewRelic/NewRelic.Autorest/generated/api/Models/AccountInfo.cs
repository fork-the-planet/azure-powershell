// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Extensions;

    /// <summary>Account Info of the NewRelic account</summary>
    public partial class AccountInfo :
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IAccountInfo,
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.IAccountInfoInternal
    {

        /// <summary>Backing field for <see cref="AccountId" /> property.</summary>
        private string _accountId;

        /// <summary>Account id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Owned)]
        public string AccountId { get => this._accountId; set => this._accountId = value; }

        /// <summary>Backing field for <see cref="IngestionKey" /> property.</summary>
        private System.Security.SecureString _ingestionKey;

        /// <summary>ingestion key of account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Owned)]
        public System.Security.SecureString IngestionKey { get => this._ingestionKey; set => this._ingestionKey = value; }

        /// <summary>Backing field for <see cref="Region" /> property.</summary>
        private string _region;

        /// <summary>Region where New Relic account is present</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Owned)]
        public string Region { get => this._region; set => this._region = value; }

        /// <summary>Creates an new <see cref="AccountInfo" /> instance.</summary>
        public AccountInfo()
        {

        }
    }
    /// Account Info of the NewRelic account
    public partial interface IAccountInfo :
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.IJsonSerializable
    {
        /// <summary>Account id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Account id",
        SerializedName = @"accountId",
        PossibleTypes = new [] { typeof(string) })]
        string AccountId { get; set; }
        /// <summary>ingestion key of account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"ingestion key of account",
        SerializedName = @"ingestionKey",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString IngestionKey { get; set; }
        /// <summary>Region where New Relic account is present</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Region where New Relic account is present",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        string Region { get; set; }

    }
    /// Account Info of the NewRelic account
    internal partial interface IAccountInfoInternal

    {
        /// <summary>Account id</summary>
        string AccountId { get; set; }
        /// <summary>ingestion key of account</summary>
        System.Security.SecureString IngestionKey { get; set; }
        /// <summary>Region where New Relic account is present</summary>
        string Region { get; set; }

    }
}