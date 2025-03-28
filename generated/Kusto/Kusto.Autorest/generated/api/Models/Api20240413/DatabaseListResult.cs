// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Extensions;

    /// <summary>The list Kusto databases operation response.</summary>
    public partial class DatabaseListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDatabaseListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDatabaseListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>Link to the next page of results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDatabase[] _value;

        /// <summary>The list of Kusto databases.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDatabase[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="DatabaseListResult" /> instance.</summary>
        public DatabaseListResult()
        {

        }
    }
    /// The list Kusto databases operation response.
    public partial interface IDatabaseListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IJsonSerializable
    {
        /// <summary>Link to the next page of results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Link to the next page of results",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>The list of Kusto databases.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of Kusto databases.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDatabase) })]
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDatabase[] Value { get; set; }

    }
    /// The list Kusto databases operation response.
    internal partial interface IDatabaseListResultInternal

    {
        /// <summary>Link to the next page of results</summary>
        string NextLink { get; set; }
        /// <summary>The list of Kusto databases.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20240413.IDatabase[] Value { get; set; }

    }
}