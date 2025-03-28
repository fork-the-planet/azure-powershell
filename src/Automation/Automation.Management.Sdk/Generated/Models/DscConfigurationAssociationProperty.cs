// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using System.Linq;

    /// <summary>
    /// The Dsc configuration property associated with the entity.
    /// </summary>
    public partial class DscConfigurationAssociationProperty
    {
        /// <summary>
        /// Initializes a new instance of the DscConfigurationAssociationProperty class.
        /// </summary>
        public DscConfigurationAssociationProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DscConfigurationAssociationProperty class.
        /// </summary>

        /// <param name="name">Gets or sets the name of the Dsc configuration.
        /// </param>
        public DscConfigurationAssociationProperty(string name = default(string))

        {
            this.Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets gets or sets the name of the Dsc configuration.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }
    }
}