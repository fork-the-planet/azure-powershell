// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of a lab.
    /// </summary>
    public partial class LabProperties
    {
        /// <summary>
        /// Initializes a new instance of the LabProperties class.
        /// </summary>
        public LabProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LabProperties class.
        /// </summary>

        /// <param name="defaultStorageAccount">The lab&#39;s default storage account.
        /// </param>

        /// <param name="defaultPremiumStorageAccount">The lab&#39;s default premium storage account.
        /// </param>

        /// <param name="artifactsStorageAccount">The lab&#39;s artifact storage account.
        /// </param>

        /// <param name="premiumDataDiskStorageAccount">The lab&#39;s premium data disk storage account.
        /// </param>

        /// <param name="vaultName">The lab&#39;s Key vault.
        /// </param>

        /// <param name="labStorageType">Type of storage used by the lab. It can be either Premium or Standard.
        /// Default is Premium.
        /// Possible values include: &#39;Standard&#39;, &#39;Premium&#39;</param>

        /// <param name="createdDate">The creation date of the lab.
        /// </param>

        /// <param name="premiumDataDisks">The setting to enable usage of premium data disks.
        /// When its value is &#39;Enabled&#39;, creation of standard or premium data disks is
        /// allowed.
        /// When its value is &#39;Disabled&#39;, only creation of standard data disks is
        /// allowed.
        /// Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;</param>

        /// <param name="provisioningState">The provisioning status of the resource.
        /// </param>

        /// <param name="uniqueIdentifier">The unique immutable identifier of a resource (Guid).
        /// </param>
        public LabProperties(string defaultStorageAccount = default(string), string defaultPremiumStorageAccount = default(string), string artifactsStorageAccount = default(string), string premiumDataDiskStorageAccount = default(string), string vaultName = default(string), string labStorageType = default(string), System.DateTime? createdDate = default(System.DateTime?), string premiumDataDisks = default(string), string provisioningState = default(string), string uniqueIdentifier = default(string))

        {
            this.DefaultStorageAccount = defaultStorageAccount;
            this.DefaultPremiumStorageAccount = defaultPremiumStorageAccount;
            this.ArtifactsStorageAccount = artifactsStorageAccount;
            this.PremiumDataDiskStorageAccount = premiumDataDiskStorageAccount;
            this.VaultName = vaultName;
            this.LabStorageType = labStorageType;
            this.CreatedDate = createdDate;
            this.PremiumDataDisks = premiumDataDisks;
            this.ProvisioningState = provisioningState;
            this.UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the lab&#39;s default storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defaultStorageAccount")]
        public string DefaultStorageAccount {get; private set; }

        /// <summary>
        /// Gets the lab&#39;s default premium storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defaultPremiumStorageAccount")]
        public string DefaultPremiumStorageAccount {get; private set; }

        /// <summary>
        /// Gets the lab&#39;s artifact storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "artifactsStorageAccount")]
        public string ArtifactsStorageAccount {get; private set; }

        /// <summary>
        /// Gets the lab&#39;s premium data disk storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "premiumDataDiskStorageAccount")]
        public string PremiumDataDiskStorageAccount {get; private set; }

        /// <summary>
        /// Gets the lab&#39;s Key vault.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vaultName")]
        public string VaultName {get; private set; }

        /// <summary>
        /// Gets or sets type of storage used by the lab. It can be either Premium or
        /// Standard. Default is Premium. Possible values include: &#39;Standard&#39;, &#39;Premium&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "labStorageType")]
        public string LabStorageType {get; set; }

        /// <summary>
        /// Gets the creation date of the lab.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "createdDate")]
        public System.DateTime? CreatedDate {get; private set; }

        /// <summary>
        /// Gets or sets the setting to enable usage of premium data disks.
        /// When its value is &#39;Enabled&#39;, creation of standard or premium data disks is
        /// allowed.
        /// When its value is &#39;Disabled&#39;, only creation of standard data disks is
        /// allowed. Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "premiumDataDisks")]
        public string PremiumDataDisks {get; set; }

        /// <summary>
        /// Gets or sets the provisioning status of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState {get; set; }

        /// <summary>
        /// Gets or sets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uniqueIdentifier")]
        public string UniqueIdentifier {get; set; }
    }
}