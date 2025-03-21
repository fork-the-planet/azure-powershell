// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.SignalR.Models
{
    using System.Linq;

    /// <summary>
    /// A class that describes the properties of the resource
    /// </summary>
    public partial class SignalRProperties
    {
        /// <summary>
        /// Initializes a new instance of the SignalRProperties class.
        /// </summary>
        public SignalRProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SignalRProperties class.
        /// </summary>

        /// <param name="provisioningState">Provisioning state of the resource.
        /// Possible values include: &#39;Unknown&#39;, &#39;Succeeded&#39;, &#39;Failed&#39;, &#39;Canceled&#39;,
        /// &#39;Running&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;, &#39;Moving&#39;</param>

        /// <param name="externalIP">The publicly accessible IP of the resource.
        /// </param>

        /// <param name="hostName">FQDN of the service instance.
        /// </param>

        /// <param name="publicPort">The publicly accessible port of the resource which is designed for
        /// browser/client side usage.
        /// </param>

        /// <param name="serverPort">The publicly accessible port of the resource which is designed for customer
        /// server side usage.
        /// </param>

        /// <param name="version">Version of the resource. Probably you need the same or higher version of
        /// client SDKs.
        /// </param>

        /// <param name="privateEndpointConnections">Private endpoint connections to the resource.
        /// </param>

        /// <param name="sharedPrivateLinkResources">The list of shared private link resources.
        /// </param>

        /// <param name="tls">TLS settings.
        /// </param>

        /// <param name="features">List of the featureFlags.
        /// FeatureFlags that are not included in the parameters for the update
        /// operation will not be modified.
        /// And the response will only include featureFlags that are explicitly set.
        /// When a featureFlag is not explicitly set, its globally default value will
        /// be used
        /// But keep in mind, the default value doesn&#39;t mean &#34;false&#34;. It varies in
        /// terms of different FeatureFlags.
        /// </param>

        /// <param name="cors">Cross-Origin Resource Sharing (CORS) settings.
        /// </param>

        /// <param name="upstream">Upstream settings when the service is in server-less mode.
        /// </param>

        /// <param name="networkAcLs">Network ACLs
        /// </param>
        public SignalRProperties(string provisioningState = default(string), string externalIP = default(string), string hostName = default(string), int? publicPort = default(int?), int? serverPort = default(int?), string version = default(string), System.Collections.Generic.IList<PrivateEndpointConnection> privateEndpointConnections = default(System.Collections.Generic.IList<PrivateEndpointConnection>), System.Collections.Generic.IList<SharedPrivateLinkResource> sharedPrivateLinkResources = default(System.Collections.Generic.IList<SharedPrivateLinkResource>), SignalRTlsSettings tls = default(SignalRTlsSettings), System.Collections.Generic.IList<SignalRFeature> features = default(System.Collections.Generic.IList<SignalRFeature>), SignalRCorsSettings cors = default(SignalRCorsSettings), ServerlessUpstreamSettings upstream = default(ServerlessUpstreamSettings), SignalRNetworkACLs networkAcLs = default(SignalRNetworkACLs))

        {
            this.ProvisioningState = provisioningState;
            this.ExternalIP = externalIP;
            this.HostName = hostName;
            this.PublicPort = publicPort;
            this.ServerPort = serverPort;
            this.Version = version;
            this.PrivateEndpointConnections = privateEndpointConnections;
            this.SharedPrivateLinkResources = sharedPrivateLinkResources;
            this.Tls = tls;
            this.Features = features;
            this.Cors = cors;
            this.Upstream = upstream;
            this.NetworkAcLs = networkAcLs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets provisioning state of the resource. Possible values include: &#39;Unknown&#39;, &#39;Succeeded&#39;, &#39;Failed&#39;, &#39;Canceled&#39;, &#39;Running&#39;, &#39;Creating&#39;, &#39;Updating&#39;, &#39;Deleting&#39;, &#39;Moving&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; private set; }

        /// <summary>
        /// Gets the publicly accessible IP of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "externalIP")]
        public string ExternalIP {get; private set; }

        /// <summary>
        /// Gets fQDN of the service instance.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "hostName")]
        public string HostName {get; private set; }

        /// <summary>
        /// Gets the publicly accessible port of the resource which is designed for
        /// browser/client side usage.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "publicPort")]
        public int? PublicPort {get; private set; }

        /// <summary>
        /// Gets the publicly accessible port of the resource which is designed for
        /// customer server side usage.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "serverPort")]
        public int? ServerPort {get; private set; }

        /// <summary>
        /// Gets version of the resource. Probably you need the same or higher version
        /// of client SDKs.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "version")]
        public string Version {get; private set; }

        /// <summary>
        /// Gets private endpoint connections to the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "privateEndpointConnections")]
        public System.Collections.Generic.IList<PrivateEndpointConnection> PrivateEndpointConnections {get; private set; }

        /// <summary>
        /// Gets the list of shared private link resources.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sharedPrivateLinkResources")]
        public System.Collections.Generic.IList<SharedPrivateLinkResource> SharedPrivateLinkResources {get; private set; }

        /// <summary>
        /// Gets or sets tLS settings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tls")]
        public SignalRTlsSettings Tls {get; set; }

        /// <summary>
        /// Gets or sets list of the featureFlags.
        /// FeatureFlags that are not included in the parameters for the update
        /// operation will not be modified.
        /// And the response will only include featureFlags that are explicitly set.
        /// When a featureFlag is not explicitly set, its globally default value will
        /// be used
        /// But keep in mind, the default value doesn&#39;t mean &#34;false&#34;. It varies in
        /// terms of different FeatureFlags.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "features")]
        public System.Collections.Generic.IList<SignalRFeature> Features {get; set; }

        /// <summary>
        /// Gets or sets cross-Origin Resource Sharing (CORS) settings.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "cors")]
        public SignalRCorsSettings Cors {get; set; }

        /// <summary>
        /// Gets or sets upstream settings when the service is in server-less mode.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "upstream")]
        public ServerlessUpstreamSettings Upstream {get; set; }

        /// <summary>
        /// Gets or sets network ACLs
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "networkACLs")]
        public SignalRNetworkACLs NetworkAcLs {get; set; }
    }
}