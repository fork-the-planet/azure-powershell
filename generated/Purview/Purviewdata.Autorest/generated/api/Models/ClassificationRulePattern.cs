// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class ClassificationRulePattern :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IClassificationRulePattern,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IClassificationRulePatternInternal
    {

        /// <summary>Backing field for <see cref="Kind" /> property.</summary>
        private string _kind= @"Regex";

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Owned)]
        public string Kind { get => this._kind; }

        /// <summary>Internal Acessors for Kind</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IClassificationRulePatternInternal.Kind { get => this._kind; set { {_kind = value;} } }

        /// <summary>Creates an new <see cref="ClassificationRulePattern" /> instance.</summary>
        public ClassificationRulePattern()
        {

        }
    }
    public partial interface IClassificationRulePattern :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Read = true,
        Create = true,
        Update = true,
        Description = @"",
        SerializedName = @"kind",
        PossibleTypes = new [] { typeof(string) })]
        string Kind { get;  }

    }
    internal partial interface IClassificationRulePatternInternal

    {
        string Kind { get; set; }

    }
}