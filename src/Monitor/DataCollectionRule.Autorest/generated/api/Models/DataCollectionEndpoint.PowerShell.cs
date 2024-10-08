// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.PowerShell;

    /// <summary>Definition of data collection endpoint.</summary>
    [System.ComponentModel.TypeConverter(typeof(DataCollectionEndpointTypeConverter))]
    public partial class DataCollectionEndpoint
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DataCollectionEndpoint(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ConfigurationAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ConfigurationAccess = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointConfigurationAccess) content.GetValueForProperty("ConfigurationAccess",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ConfigurationAccess, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointConfigurationAccessTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogsIngestion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).LogsIngestion = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointLogsIngestion) content.GetValueForProperty("LogsIngestion",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).LogsIngestion, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointLogsIngestionTypeConverter.ConvertFrom);
            }
            if (content.Contains("MetricsIngestion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetricsIngestion = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointMetricsIngestion) content.GetValueForProperty("MetricsIngestion",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetricsIngestion, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointMetricsIngestionTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkAcls"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).NetworkAcls = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointNetworkAcls) content.GetValueForProperty("NetworkAcls",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).NetworkAcls, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointNetworkAclsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FailoverConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).FailoverConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointFailoverConfiguration) content.GetValueForProperty("FailoverConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).FailoverConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointFailoverConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Metadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).Metadata = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointMetadata) content.GetValueForProperty("Metadata",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).Metadata, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointMetadataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("ImmutableId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ImmutableId = (string) content.GetValueForProperty("ImmutableId",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ImmutableId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkScopedResource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).PrivateLinkScopedResource = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IPrivateLinkScopedResource>) content.GetValueForProperty("PrivateLinkScopedResource",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).PrivateLinkScopedResource, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IPrivateLinkScopedResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.PrivateLinkScopedResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("MetadataProvisionedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetadataProvisionedBy = (string) content.GetValueForProperty("MetadataProvisionedBy",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetadataProvisionedBy, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationAccessEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ConfigurationAccessEndpoint = (string) content.GetValueForProperty("ConfigurationAccessEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ConfigurationAccessEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("LogIngestionEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).LogIngestionEndpoint = (string) content.GetValueForProperty("LogIngestionEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).LogIngestionEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("MetricIngestionEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetricIngestionEndpoint = (string) content.GetValueForProperty("MetricIngestionEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetricIngestionEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkAclsPublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).NetworkAclsPublicNetworkAccess = (string) content.GetValueForProperty("NetworkAclsPublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).NetworkAclsPublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("FailoverConfigurationActiveLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).FailoverConfigurationActiveLocation = (string) content.GetValueForProperty("FailoverConfigurationActiveLocation",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).FailoverConfigurationActiveLocation, global::System.Convert.ToString);
            }
            if (content.Contains("FailoverConfigurationLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).FailoverConfigurationLocation = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ILocationSpec>) content.GetValueForProperty("FailoverConfigurationLocation",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).FailoverConfigurationLocation, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ILocationSpec>(__y, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.LocationSpecTypeConverter.ConvertFrom));
            }
            if (content.Contains("MetadataProvisionedByResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetadataProvisionedByResourceId = (string) content.GetValueForProperty("MetadataProvisionedByResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetadataProvisionedByResourceId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DataCollectionEndpoint(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ConfigurationAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ConfigurationAccess = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointConfigurationAccess) content.GetValueForProperty("ConfigurationAccess",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ConfigurationAccess, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointConfigurationAccessTypeConverter.ConvertFrom);
            }
            if (content.Contains("LogsIngestion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).LogsIngestion = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointLogsIngestion) content.GetValueForProperty("LogsIngestion",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).LogsIngestion, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointLogsIngestionTypeConverter.ConvertFrom);
            }
            if (content.Contains("MetricsIngestion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetricsIngestion = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointMetricsIngestion) content.GetValueForProperty("MetricsIngestion",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetricsIngestion, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointMetricsIngestionTypeConverter.ConvertFrom);
            }
            if (content.Contains("NetworkAcls"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).NetworkAcls = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointNetworkAcls) content.GetValueForProperty("NetworkAcls",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).NetworkAcls, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointNetworkAclsTypeConverter.ConvertFrom);
            }
            if (content.Contains("FailoverConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).FailoverConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointFailoverConfiguration) content.GetValueForProperty("FailoverConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).FailoverConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointFailoverConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("Metadata"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).Metadata = (Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointMetadata) content.GetValueForProperty("Metadata",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).Metadata, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpointMetadataTypeConverter.ConvertFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("ImmutableId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ImmutableId = (string) content.GetValueForProperty("ImmutableId",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ImmutableId, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("PrivateLinkScopedResource"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).PrivateLinkScopedResource = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IPrivateLinkScopedResource>) content.GetValueForProperty("PrivateLinkScopedResource",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).PrivateLinkScopedResource, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IPrivateLinkScopedResource>(__y, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.PrivateLinkScopedResourceTypeConverter.ConvertFrom));
            }
            if (content.Contains("MetadataProvisionedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetadataProvisionedBy = (string) content.GetValueForProperty("MetadataProvisionedBy",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetadataProvisionedBy, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationAccessEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ConfigurationAccessEndpoint = (string) content.GetValueForProperty("ConfigurationAccessEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).ConfigurationAccessEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("LogIngestionEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).LogIngestionEndpoint = (string) content.GetValueForProperty("LogIngestionEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).LogIngestionEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("MetricIngestionEndpoint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetricIngestionEndpoint = (string) content.GetValueForProperty("MetricIngestionEndpoint",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetricIngestionEndpoint, global::System.Convert.ToString);
            }
            if (content.Contains("NetworkAclsPublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).NetworkAclsPublicNetworkAccess = (string) content.GetValueForProperty("NetworkAclsPublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).NetworkAclsPublicNetworkAccess, global::System.Convert.ToString);
            }
            if (content.Contains("FailoverConfigurationActiveLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).FailoverConfigurationActiveLocation = (string) content.GetValueForProperty("FailoverConfigurationActiveLocation",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).FailoverConfigurationActiveLocation, global::System.Convert.ToString);
            }
            if (content.Contains("FailoverConfigurationLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).FailoverConfigurationLocation = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ILocationSpec>) content.GetValueForProperty("FailoverConfigurationLocation",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).FailoverConfigurationLocation, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.ILocationSpec>(__y, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.LocationSpecTypeConverter.ConvertFrom));
            }
            if (content.Contains("MetadataProvisionedByResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetadataProvisionedByResourceId = (string) content.GetValueForProperty("MetadataProvisionedByResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpointInternal)this).MetadataProvisionedByResourceId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpoint" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpoint DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DataCollectionEndpoint(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.DataCollectionEndpoint"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpoint" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpoint DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DataCollectionEndpoint(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DataCollectionEndpoint" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DataCollectionEndpoint" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Models.IDataCollectionEndpoint FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Monitor.DataCollection.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// Definition of data collection endpoint.
    [System.ComponentModel.TypeConverter(typeof(DataCollectionEndpointTypeConverter))]
    public partial interface IDataCollectionEndpoint

    {

    }
}