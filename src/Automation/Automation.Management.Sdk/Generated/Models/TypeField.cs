// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// Information about a field of a type.
    /// </summary>
    public partial class TypeField
    {
        /// <summary>
        /// Initializes a new instance of the TypeField class.
        /// </summary>
        public TypeField()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TypeField class.
        /// </summary>

        /// <param name="name">Gets or sets the name of the field.
        /// </param>

        /// <param name="type">Gets or sets the type of the field.
        /// </param>
        public TypeField(string name = default(string), string type = default(string))

        {
            this.Name = name;
            this.Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets or sets the name of the field.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets gets or sets the type of the field.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; set; }
    }
}