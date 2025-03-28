// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters for VirtualNetworkGatewayPolicyGroup.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class VirtualNetworkGatewayPolicyGroup : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayPolicyGroup class.
        /// </summary>
        public VirtualNetworkGatewayPolicyGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkGatewayPolicyGroup class.
        /// </summary>

        /// <param name="id">Resource ID.
        /// </param>

        /// <param name="name">The name of the resource that is unique within a resource group. This name
        /// can be used to access the resource.
        /// </param>

        /// <param name="etag">A unique read-only string that changes whenever the resource is updated.
        /// </param>

        /// <param name="provisioningState">The provisioning state of the VirtualNetworkGatewayPolicyGroup resource.
        /// Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;,
        /// &#39;Updating&#39;, &#39;Deleting&#39;</param>

        /// <param name="isDefault">Shows if this is a Default VirtualNetworkGatewayPolicyGroup or not.
        /// </param>

        /// <param name="priority">Priority for VirtualNetworkGatewayPolicyGroup.
        /// </param>

        /// <param name="policyMembers">Multiple PolicyMembers for VirtualNetworkGatewayPolicyGroup.
        /// </param>

        /// <param name="vngClientConnectionConfigurations">List of references to vngClientConnectionConfigurations.
        /// </param>
        public VirtualNetworkGatewayPolicyGroup(string id = default(string), string name = default(string), string etag = default(string), string provisioningState = default(string), bool? isDefault = default(bool?), int? priority = default(int?), System.Collections.Generic.IList<VirtualNetworkGatewayPolicyGroupMember> policyMembers = default(System.Collections.Generic.IList<VirtualNetworkGatewayPolicyGroupMember>), System.Collections.Generic.IList<SubResource> vngClientConnectionConfigurations = default(System.Collections.Generic.IList<SubResource>))

        : base(id)
        {
            this.Name = name;
            this.Etag = etag;
            this.ProvisioningState = provisioningState;
            this.IsDefault = isDefault;
            this.Priority = priority;
            this.PolicyMembers = policyMembers;
            this.VngClientConnectionConfigurations = vngClientConnectionConfigurations;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the name of the resource that is unique within a resource
        /// group. This name can be used to access the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource is
        /// updated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag {get; private set; }

        /// <summary>
        /// Gets the provisioning state of the VirtualNetworkGatewayPolicyGroup
        /// resource. Possible values include: &#39;Failed&#39;, &#39;Succeeded&#39;, &#39;Canceled&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets shows if this is a Default VirtualNetworkGatewayPolicyGroup or
        /// not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.isDefault")]
        public bool? IsDefault {get; set; }

        /// <summary>
        /// Gets or sets priority for VirtualNetworkGatewayPolicyGroup.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.priority")]
        public int? Priority {get; set; }

        /// <summary>
        /// Gets or sets multiple PolicyMembers for VirtualNetworkGatewayPolicyGroup.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.policyMembers")]
        public System.Collections.Generic.IList<VirtualNetworkGatewayPolicyGroupMember> PolicyMembers {get; set; }

        /// <summary>
        /// Gets list of references to vngClientConnectionConfigurations.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.vngClientConnectionConfigurations")]
        public System.Collections.Generic.IList<SubResource> VngClientConnectionConfigurations {get; private set; }
    }
}