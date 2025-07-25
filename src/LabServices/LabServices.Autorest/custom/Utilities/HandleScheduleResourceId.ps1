# ----------------------------------------------------------------------------------
#
# Copyright Microsoft Corporation
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ----------------------------------------------------------------------------------

#This script uses regex to confirm lab plan resource Id
[Microsoft.Azure.PowerShell.Cmdlets.LabServices.DoNotExportAttribute()]
param(
    [Parameter()]
    [System.String]
    $ResourceId
)

$VerificationRegex = Join-Path $PSScriptRoot 'VerificationRegex.ps1'

. $VerificationRegex

if ($ResourceId -match $scheduleRegex){
    return @{
        "SubscriptionId" = $($Matches['subscriptionId'])
        "ResourceGroupName" = $($Matches['resourceGroupName'])
        "LabName" = $($Matches['labName'])
        "ScheduleName" = $($Matches['scheduleName'])
    }
} else {
    #Can't throw or error build will fail.
  return $null
}

