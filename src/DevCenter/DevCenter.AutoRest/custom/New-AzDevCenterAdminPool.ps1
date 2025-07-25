
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
Creates or updates a machine pool
.Description
Creates or updates a machine pool
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.IDevCenterIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPool
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDevCenterIdentity>: Identity Parameter
  [AttachedNetworkConnectionName <String>]: The name of the attached NetworkConnection.
  [CatalogName <String>]: The name of the Catalog.
  [DevBoxDefinitionName <String>]: The name of the Dev Box definition.
  [DevCenterName <String>]: The name of the devcenter.
  [EncryptionSetName <String>]: The name of the devcenter encryption set.
  [EnvironmentDefinitionName <String>]: The name of the Environment Definition.
  [EnvironmentTypeName <String>]: The name of the environment type.
  [GalleryName <String>]: The name of the gallery.
  [Id <String>]: Resource identity path
  [ImageName <String>]: The name of the image.
  [Location <String>]: The Azure region
  [MemberName <String>]: The name of a devcenter plan member.
  [NetworkConnectionName <String>]: Name of the Network Connection that can be applied to a Pool.
  [OperationId <String>]: The ID of an ongoing async operation
  [PlanName <String>]: The name of the devcenter plan.
  [PoolName <String>]: Name of the pool.
  [ProjectName <String>]: The name of the project.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [ScheduleName <String>]: The name of the schedule that uniquely identifies it.
  [SubscriptionId <String>]: The ID of the target subscription.
  [TaskName <String>]: The name of the Task.
  [VersionName <String>]: The version of the image.
.Link
https://learn.microsoft.com/powershell/module/az.devcenter/new-azdevcenteradminpool
#>
function New-AzDevCenterAdminPool {
  [OutputType([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api20240501Preview.IPool])]
  [CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
  [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.GenericBreakingChangeAttribute("MemberName and PlanName will be removed from InputObject", "15.0.0", "3.0.0", "2025/11/18")]
  param(
      [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
      [Alias('PoolName')]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
      [System.String]
      # Name of the pool.
      ${Name},
  
      [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
      [System.String]
      # The name of the project.
      ${ProjectName},
  
      [Parameter(ParameterSetName='CreateExpanded', Mandatory)]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
      [System.String]
      # The name of the resource group.
      # The name is case insensitive.
      ${ResourceGroupName},
  
      [Parameter(ParameterSetName='CreateExpanded')]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
      [System.String]
      # The ID of the target subscription.
      ${SubscriptionId},
  
      [Parameter(ParameterSetName='CreateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Path')]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.IDevCenterIdentity]
      # Identity Parameter
      # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
      ${InputObject},
  
      [Parameter(Mandatory)]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
      [System.String]
      # The geo-location where the resource lives
      ${Location},
  
      [Parameter(Mandatory)]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
      [System.String]
      # Name of a Dev Box definition in parent Project of this Pool
      ${DevBoxDefinitionName},
  
      [Parameter()]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
      [System.String]
      # The display name of the pool.
      ${DisplayName},
  
      [Parameter(Mandatory)]
      [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LocalAdminStatus])]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.LocalAdminStatus]
      # Indicates whether owners of Dev Boxes in this pool are added as local administrators on the Dev Box.
      ${LocalAdministrator},
      
      [Parameter()]
      [AllowEmptyCollection()]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
      [System.String[]]
      # The regions of the managed virtual network (required when managedNetworkType is Managed).
      ${ManagedVirtualNetworkRegion},
  
      [Parameter(Mandatory)]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
      [System.String]
      # Name of a Network Connection in parent Project of this Pool
      ${NetworkConnectionName},
  
      [Parameter()]
      [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.SingleSignOnStatus])]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.SingleSignOnStatus]
      # Indicates whether Dev Boxes in this pool are created with single sign on enabled.
      # The also requires that single sign on be enabled on the tenant.
      ${SingleSignOnStatus},
  
      [Parameter()]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
      [System.Int32]
      # The specified time in minutes to wait before stopping a Dev Box once disconnect is detected.
      ${StopOnDisconnectGracePeriodMinute},
  
      [Parameter()]
      [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.StopOnDisconnectEnableStatus])]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.StopOnDisconnectEnableStatus]
      # Whether the feature to stop the Dev Box on disconnect once the grace period has lapsed is enabled.
      ${StopOnDisconnectStatus},
  
      [Parameter()]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Models.Api40.ITrackedResourceTags]))]
      [System.Collections.Hashtable]
      # Resource tags.
      ${Tag},
  
      [Parameter()]
      [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.VirtualNetworkType])]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Body')]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Support.VirtualNetworkType]
      # Indicates whether the pool uses a Virtual Network managed by Microsoft or a customer provided network.
      ${VirtualNetworkType},
  
      [Parameter()]
      [Alias('AzureRMContext', 'AzureCredential')]
      [ValidateNotNull()]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Azure')]
      [System.Management.Automation.PSObject]
      # The DefaultProfile parameter is not functional.
      # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
      ${DefaultProfile},
  
      [Parameter()]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
      [System.Management.Automation.SwitchParameter]
      # Run the command as a job
      ${AsJob},
  
      [Parameter(DontShow)]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
      [System.Management.Automation.SwitchParameter]
      # Wait for .NET debugger to attach
      ${Break},
  
      [Parameter(DontShow)]
      [ValidateNotNull()]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SendAsyncStep[]]
      # SendAsync Pipeline Steps to be appended to the front of the pipeline
      ${HttpPipelineAppend},
  
      [Parameter(DontShow)]
      [ValidateNotNull()]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Runtime.SendAsyncStep[]]
      # SendAsync Pipeline Steps to be prepended to the front of the pipeline
      ${HttpPipelinePrepend},
  
      [Parameter()]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
      [System.Management.Automation.SwitchParameter]
      # Run the command asynchronously
      ${NoWait},
  
      [Parameter(DontShow)]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
      [System.Uri]
      # The URI for the proxy server to use
      ${Proxy},
  
      [Parameter(DontShow)]
      [ValidateNotNull()]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
      [System.Management.Automation.PSCredential]
      # Credentials for a proxy server to use for the remote call
      ${ProxyCredential},
  
      [Parameter(DontShow)]
      [Microsoft.Azure.PowerShell.Cmdlets.DevCenter.Category('Runtime')]
      [System.Management.Automation.SwitchParameter]
      # Use the default credentials for the proxy
      ${ProxyUseDefaultCredentials}
  )
    
    process {
        Az.DevCenter.internal\New-AzDevCenterAdminPool @PSBoundParameters
    }
}
    