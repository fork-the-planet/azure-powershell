
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create an in-memory object for ComputeStartStopSchedule.
.Description
Create an in-memory object for ComputeStartStopSchedule.
.Example
New-AzMLWorkspaceComputeStartStopScheduleObject

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ComputeStartStopSchedule
.Link
https://learn.microsoft.com/powershell/module/Az.MachineLearningServices/new-AzMLWorkspaceComputeStartStopScheduleObject
#>
function New-AzMLWorkspaceComputeStartStopScheduleObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20240401.ComputeStartStopSchedule])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputePowerAction])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputePowerAction]
    # [Required] The compute power action.
    ${Action},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # [Required] Specifies cron expression of schedule.
    #         The expression should follow NCronTab format.
    ${CronExpression},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # The start time in yyyy-MM-ddTHH:mm:ss format.
    ${CronStartTime},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # Specifies time zone in which the schedule runs.
    #         TimeZone should follow Windows time zone format.
    # Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11.
    ${CronTimeZone},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeRecurrenceFrequency])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeRecurrenceFrequency]
    # [Required] The frequency to trigger schedule.
    ${RecurrenceFrequency},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Int32]
    # [Required] Specifies schedule interval in conjunction with frequency.
    ${RecurrenceInterval},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # The start time in yyyy-MM-ddTHH:mm:ss format.
    ${RecurrenceStartTime},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # Specifies time zone in which the schedule runs.
    #         TimeZone should follow Windows time zone format.
    # Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11.
    ${RecurrenceTimeZone},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Int32[]]
    # [Required] List of hours for the schedule.
    ${ScheduleHour},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.String]
    # A system assigned id for the schedule.
    ${ScheduleId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Int32[]]
    # [Required] List of minutes for the schedule.
    ${ScheduleMinute},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [System.Int32[]]
    # List of month days for the schedule.
    ${ScheduleMonthDay},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleProvisioningState])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleProvisioningState]
    # The current deployment state of schedule.
    ${ScheduleProvisioningStatus},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleStatus]
    # Is the schedule enabled or disabled?.
    ${ScheduleStatus},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeWeekDay])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeWeekDay[]]
    # List of days for the schedule.
    ${ScheduleWeekDay},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ScheduleStatus]
    # Is the schedule enabled or disabled?.
    ${Status},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeTriggerType])]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ComputeTriggerType]
    # [Required] The schedule trigger type.
    ${TriggerType}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            __AllParameterSets = 'Az.MachineLearningServices.custom\New-AzMLWorkspaceComputeStartStopScheduleObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
