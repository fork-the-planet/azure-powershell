// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class ScanningRule
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject container);

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

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json, ref bool returnNow);

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

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanningRule.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanningRule.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IScanningRule FromJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json ? new ScanningRule(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject into a new instance of <see cref="ScanningRule" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ScanningRule(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_fileExtension = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonArray>("fileExtensions"), out var __jsonFileExtensions) ? If( __jsonFileExtensions as Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<string>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : _fileExtension;}
            {_customFileExtension = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonArray>("customFileExtensions"), out var __jsonCustomFileExtensions) ? If( __jsonCustomFileExtensions as Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ICustomFileExtension>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__q, (__p)=>(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ICustomFileExtension) (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.CustomFileExtension.FromJson(__p) )) ))() : null : _customFileExtension;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="ScanningRule" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ScanningRule" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (null != this._fileExtension)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.XNodeArray();
                foreach( var __x in this._fileExtension )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("fileExtensions",__w);
            }
            if (null != this._customFileExtension)
            {
                var __r = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Json.XNodeArray();
                foreach( var __s in this._customFileExtension )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("customFileExtensions",__r);
            }
            AfterToJson(ref container);
            return container;
        }
    }
}