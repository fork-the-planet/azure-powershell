// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Extensions;

    /// <summary>The response of a AutonomousDatabaseCharacterSet list operation.</summary>
    public partial class AutonomousDatabaseCharacterSetListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDatabaseCharacterSetListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDatabaseCharacterSetListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDatabaseCharacterSet> _value;

        /// <summary>The AutonomousDatabaseCharacterSet items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Origin(Microsoft.Azure.PowerShell.Cmdlets.Oracle.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDatabaseCharacterSet> Value { get => this._value; set => this._value = value; }

        /// <summary>
        /// Creates an new <see cref="AutonomousDatabaseCharacterSetListResult" /> instance.
        /// </summary>
        public AutonomousDatabaseCharacterSetListResult()
        {

        }
    }
    /// The response of a AutonomousDatabaseCharacterSet list operation.
    public partial interface IAutonomousDatabaseCharacterSetListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.IJsonSerializable
    {
        /// <summary>The link to the next page of items</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The link to the next page of items",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The AutonomousDatabaseCharacterSet items on this page</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The AutonomousDatabaseCharacterSet items on this page",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDatabaseCharacterSet) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDatabaseCharacterSet> Value { get; set; }

    }
    /// The response of a AutonomousDatabaseCharacterSet list operation.
    internal partial interface IAutonomousDatabaseCharacterSetListResultInternal

    {
        /// <summary>The link to the next page of items</summary>
        string NextLink { get; set; }
        /// <summary>The AutonomousDatabaseCharacterSet items on this page</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IAutonomousDatabaseCharacterSet> Value { get; set; }

    }
}