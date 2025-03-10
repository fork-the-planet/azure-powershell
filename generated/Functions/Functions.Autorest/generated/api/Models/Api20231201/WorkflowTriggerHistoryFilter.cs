// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>The workflow trigger history filter.</summary>
    public partial class WorkflowTriggerHistoryFilter :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryFilter,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IWorkflowTriggerHistoryFilterInternal
    {

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus? _status;

        /// <summary>The status of workflow trigger history.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus? Status { get => this._status; set => this._status = value; }

        /// <summary>Creates an new <see cref="WorkflowTriggerHistoryFilter" /> instance.</summary>
        public WorkflowTriggerHistoryFilter()
        {

        }
    }
    /// The workflow trigger history filter.
    public partial interface IWorkflowTriggerHistoryFilter :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>The status of workflow trigger history.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of workflow trigger history.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus? Status { get; set; }

    }
    /// The workflow trigger history filter.
    internal partial interface IWorkflowTriggerHistoryFilterInternal

    {
        /// <summary>The status of workflow trigger history.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Support.WorkflowStatus? Status { get; set; }

    }
}