// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.PowerShell;

    /// <summary>The description of the DigitalTwins service.</summary>
    [System.ComponentModel.TypeConverter(typeof(DigitalTwinsPatchDescriptionTypeConverter))]
    public partial class DigitalTwinsPatchDescription
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsPatchDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescription" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescription DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DigitalTwinsPatchDescription(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsPatchDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescription" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescription DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DigitalTwinsPatchDescription(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsPatchDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DigitalTwinsPatchDescription(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsIdentity1) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsIdentity1TypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsPatchPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsPatchDescriptionTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsPatchDescription"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DigitalTwinsPatchDescription(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Identity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).Identity = (Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsIdentity1) content.GetValueForProperty("Identity",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).Identity, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsIdentity1TypeConverter.ConvertFrom);
            }
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsPatchPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.DigitalTwinsPatchDescriptionTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("IdentityType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).IdentityType = (string) content.GetValueForProperty("IdentityType",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).IdentityType, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityPrincipalId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).IdentityPrincipalId = (string) content.GetValueForProperty("IdentityPrincipalId",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).IdentityPrincipalId, global::System.Convert.ToString);
            }
            if (content.Contains("IdentityTenantId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).IdentityTenantId = (string) content.GetValueForProperty("IdentityTenantId",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).IdentityTenantId, global::System.Convert.ToString);
            }
            if (content.Contains("PublicNetworkAccess"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).PublicNetworkAccess = (string) content.GetValueForProperty("PublicNetworkAccess",((Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescriptionInternal)this).PublicNetworkAccess, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DigitalTwinsPatchDescription" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DigitalTwinsPatchDescription" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Models.IDigitalTwinsPatchDescription FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.DigitalTwins.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// The description of the DigitalTwins service.
    [System.ComponentModel.TypeConverter(typeof(DigitalTwinsPatchDescriptionTypeConverter))]
    public partial interface IDigitalTwinsPatchDescription

    {

    }
}