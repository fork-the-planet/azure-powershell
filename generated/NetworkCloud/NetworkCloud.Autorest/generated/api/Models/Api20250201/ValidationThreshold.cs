// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// ValidationThreshold indicates allowed machine and node hardware and deployment failures.
    /// </summary>
    public partial class ValidationThreshold :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IValidationThreshold,
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IValidationThresholdInternal
    {

        /// <summary>Backing field for <see cref="Grouping" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ValidationThresholdGrouping _grouping;

        /// <summary>Selection of how the type evaluation is applied to the cluster calculation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ValidationThresholdGrouping Grouping { get => this._grouping; set => this._grouping = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ValidationThresholdType _type;

        /// <summary>Selection of how the threshold should be evaluated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ValidationThresholdType Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private long _value;

        /// <summary>The numeric threshold value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Origin(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.PropertyOrigin.Owned)]
        public long Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="ValidationThreshold" /> instance.</summary>
        public ValidationThreshold()
        {

        }
    }
    /// ValidationThreshold indicates allowed machine and node hardware and deployment failures.
    public partial interface IValidationThreshold :
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.IJsonSerializable
    {
        /// <summary>Selection of how the type evaluation is applied to the cluster calculation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Selection of how the type evaluation is applied to the cluster calculation.",
        SerializedName = @"grouping",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ValidationThresholdGrouping) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ValidationThresholdGrouping Grouping { get; set; }
        /// <summary>Selection of how the threshold should be evaluated.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Selection of how the threshold should be evaluated.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ValidationThresholdType) })]
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ValidationThresholdType Type { get; set; }
        /// <summary>The numeric threshold value.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The numeric threshold value.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(long) })]
        long Value { get; set; }

    }
    /// ValidationThreshold indicates allowed machine and node hardware and deployment failures.
    internal partial interface IValidationThresholdInternal

    {
        /// <summary>Selection of how the type evaluation is applied to the cluster calculation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ValidationThresholdGrouping Grouping { get; set; }
        /// <summary>Selection of how the threshold should be evaluated.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.ValidationThresholdType Type { get; set; }
        /// <summary>The numeric threshold value.</summary>
        long Value { get; set; }

    }
}