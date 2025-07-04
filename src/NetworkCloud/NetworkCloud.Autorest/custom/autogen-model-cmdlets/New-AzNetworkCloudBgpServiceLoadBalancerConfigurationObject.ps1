
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
Create an in-memory object for BgpServiceLoadBalancerConfiguration.
.Description
Create an in-memory object for BgpServiceLoadBalancerConfiguration.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.BgpServiceLoadBalancerConfiguration
.Link
https://learn.microsoft.com/powershell/module/Az.NetworkCloud/new-AzNetworkCloudBgpServiceLoadBalancerConfigurationObject
#>
function New-AzNetworkCloudBgpServiceLoadBalancerConfigurationObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.BgpServiceLoadBalancerConfiguration')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(HelpMessage="The association of IP address pools to the communities and peers, allowing for announcement of IPs.")]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBgpAdvertisement[]]
        $BgpAdvertisement,
        [Parameter(HelpMessage="The list of additional BgpPeer entities that the Kubernetes cluster will peer with. All peering must be explicitly defined.")]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IServiceLoadBalancerBgpPeer[]]
        $BgpPeer,
        [Parameter(HelpMessage="The indicator to specify if the load balancer peers with the network fabric.")]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.FabricPeeringEnabled])]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Support.FabricPeeringEnabled]
        $FabricPeeringEnabled,
        [Parameter(HelpMessage="The list of pools of IP addresses that can be allocated to load balancer services.")]
        [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IIPAddressPool[]]
        $IPAddressPool
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.BgpServiceLoadBalancerConfiguration]::New()

        if ($PSBoundParameters.ContainsKey('BgpAdvertisement')) {
            $Object.BgpAdvertisement = $BgpAdvertisement
        }
        if ($PSBoundParameters.ContainsKey('BgpPeer')) {
            $Object.BgpPeer = $BgpPeer
        }
        if ($PSBoundParameters.ContainsKey('FabricPeeringEnabled')) {
            $Object.FabricPeeringEnabled = $FabricPeeringEnabled
        }
        if ($PSBoundParameters.ContainsKey('IPAddressPool')) {
            $Object.IPAddressPool = $IPAddressPool
        }
        return $Object
    }
}

