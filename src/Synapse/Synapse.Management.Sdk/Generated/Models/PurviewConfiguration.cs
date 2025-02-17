// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Synapse.Models
{
    using System.Linq;

    /// <summary>
    /// Purview Configuration
    /// </summary>
    public partial class PurviewConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the PurviewConfiguration class.
        /// </summary>
        public PurviewConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PurviewConfiguration class.
        /// </summary>

        /// <param name="purviewResourceId">Purview Resource ID
        /// </param>
        public PurviewConfiguration(string purviewResourceId = default(string))

        {
            this.PurviewResourceId = purviewResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets purview Resource ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "purviewResourceId")]
        public string PurviewResourceId {get; set; }
    }
}