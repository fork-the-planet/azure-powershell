// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>The properties of topic space.</summary>
    public partial class TopicSpaceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ITopicSpaceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ITopicSpacePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description for the Topic Space resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.ITopicSpacePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the TopicSpace resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="TopicTemplate" /> property.</summary>
        private System.Collections.Generic.List<string> _topicTemplate;

        /// <summary>
        /// The topic filters in the topic space.
        /// Example: "topicTemplates": [
        /// "devices/foo/bar",
        /// "devices/topic1/+",
        /// "devices/${principal.name}/${principal.attributes.keyName}" ].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> TopicTemplate { get => this._topicTemplate; set => this._topicTemplate = value; }

        /// <summary>Creates an new <see cref="TopicSpaceProperties" /> instance.</summary>
        public TopicSpaceProperties()
        {

        }
    }
    /// The properties of topic space.
    public partial interface ITopicSpaceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>Description for the Topic Space resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description for the Topic Space resource.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Provisioning state of the TopicSpace resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the TopicSpace resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("Creating", "Updating", "Deleting", "Succeeded", "Canceled", "Failed", "Deleted")]
        string ProvisioningState { get;  }
        /// <summary>
        /// The topic filters in the topic space.
        /// Example: "topicTemplates": [
        /// "devices/foo/bar",
        /// "devices/topic1/+",
        /// "devices/${principal.name}/${principal.attributes.keyName}" ].
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The topic filters in the topic space.
        Example: ""topicTemplates"": [
                      ""devices/foo/bar"",
                      ""devices/topic1/+"",
                      ""devices/${principal.name}/${principal.attributes.keyName}"" ].",
        SerializedName = @"topicTemplates",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> TopicTemplate { get; set; }

    }
    /// The properties of topic space.
    internal partial interface ITopicSpacePropertiesInternal

    {
        /// <summary>Description for the Topic Space resource.</summary>
        string Description { get; set; }
        /// <summary>Provisioning state of the TopicSpace resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PSArgumentCompleterAttribute("Creating", "Updating", "Deleting", "Succeeded", "Canceled", "Failed", "Deleted")]
        string ProvisioningState { get; set; }
        /// <summary>
        /// The topic filters in the topic space.
        /// Example: "topicTemplates": [
        /// "devices/foo/bar",
        /// "devices/topic1/+",
        /// "devices/${principal.name}/${principal.attributes.keyName}" ].
        /// </summary>
        System.Collections.Generic.List<string> TopicTemplate { get; set; }

    }
}