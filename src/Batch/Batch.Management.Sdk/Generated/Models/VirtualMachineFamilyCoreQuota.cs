// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// A VM Family and its associated core quota for the Batch account.
    /// </summary>
    public partial class VirtualMachineFamilyCoreQuota
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineFamilyCoreQuota class.
        /// </summary>
        public VirtualMachineFamilyCoreQuota()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineFamilyCoreQuota class.
        /// </summary>

        /// <param name="name">The Virtual Machine family name.
        /// </param>

        /// <param name="coreQuota">The core quota for the VM family for the Batch account.
        /// </param>
        public VirtualMachineFamilyCoreQuota(string name = default(string), int coreQuota = default(int))

        {
            this.Name = name;
            this.CoreQuota = coreQuota;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the Virtual Machine family name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; private set; }

        /// <summary>
        /// Gets the core quota for the VM family for the Batch account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "coreQuota")]
        public int CoreQuota {get; private set; }
    }
}