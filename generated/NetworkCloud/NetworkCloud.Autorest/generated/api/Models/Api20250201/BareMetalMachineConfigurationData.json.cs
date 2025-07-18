// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Extensions;

    /// <summary>
    /// BareMetalMachineConfigurationData represents configuration for the bare metal machine.
    /// </summary>
    public partial class BareMetalMachineConfigurationData
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject into a new instance of <see cref="BareMetalMachineConfigurationData" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal BareMetalMachineConfigurationData(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_bmcCredentials = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject>("bmcCredentials"), out var __jsonBmcCredentials) ? Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.AdministrativeCredentials.FromJson(__jsonBmcCredentials) : BmcCredentials;}
            {_bmcConnectionString = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("bmcConnectionString"), out var __jsonBmcConnectionString) ? (string)__jsonBmcConnectionString : (string)BmcConnectionString;}
            {_bmcMacAddress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("bmcMacAddress"), out var __jsonBmcMacAddress) ? (string)__jsonBmcMacAddress : (string)BmcMacAddress;}
            {_bootMacAddress = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("bootMacAddress"), out var __jsonBootMacAddress) ? (string)__jsonBootMacAddress : (string)BootMacAddress;}
            {_machineDetail = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("machineDetails"), out var __jsonMachineDetails) ? (string)__jsonMachineDetails : (string)MachineDetail;}
            {_machineName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("machineName"), out var __jsonMachineName) ? (string)__jsonMachineName : (string)MachineName;}
            {_rackSlot = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNumber>("rackSlot"), out var __jsonRackSlot) ? (long)__jsonRackSlot : RackSlot;}
            {_serialNumber = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString>("serialNumber"), out var __jsonSerialNumber) ? (string)__jsonSerialNumber : (string)SerialNumber;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBareMetalMachineConfigurationData.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBareMetalMachineConfigurationData.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Models.Api20250201.IBareMetalMachineConfigurationData FromJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject json ? new BareMetalMachineConfigurationData(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="BareMetalMachineConfigurationData" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="BareMetalMachineConfigurationData" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._bmcCredentials ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) this._bmcCredentials.ToJson(null,serializationMode) : null, "bmcCredentials" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._bmcConnectionString)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._bmcConnectionString.ToString()) : null, "bmcConnectionString" ,container.Add );
            }
            AddIf( null != (((object)this._bmcMacAddress)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._bmcMacAddress.ToString()) : null, "bmcMacAddress" ,container.Add );
            AddIf( null != (((object)this._bootMacAddress)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._bootMacAddress.ToString()) : null, "bootMacAddress" ,container.Add );
            AddIf( null != (((object)this._machineDetail)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._machineDetail.ToString()) : null, "machineDetails" ,container.Add );
            AddIf( null != (((object)this._machineName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._machineName.ToString()) : null, "machineName" ,container.Add );
            AddIf( (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNumber(this._rackSlot), "rackSlot" ,container.Add );
            AddIf( null != (((object)this._serialNumber)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.NetworkCloud.Runtime.Json.JsonString(this._serialNumber.ToString()) : null, "serialNumber" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}