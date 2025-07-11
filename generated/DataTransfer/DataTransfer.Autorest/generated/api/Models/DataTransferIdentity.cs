// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace ADT.Models
{
    using static ADT.Runtime.Extensions;

    public partial class DataTransferIdentity :
        ADT.Models.IDataTransferIdentity,
        ADT.Models.IDataTransferIdentityInternal
    {

        /// <summary>Backing field for <see cref="ConnectionName" /> property.</summary>
        private string _connectionName;

        /// <summary>The name for the connection to perform the operation on.</summary>
        [ADT.Origin(ADT.PropertyOrigin.Owned)]
        public string ConnectionName { get => this._connectionName; set => this._connectionName = value; }

        /// <summary>Backing field for <see cref="FlowName" /> property.</summary>
        private string _flowName;

        /// <summary>The name for the flow to perform the operation on.</summary>
        [ADT.Origin(ADT.PropertyOrigin.Owned)]
        public string FlowName { get => this._flowName; set => this._flowName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [ADT.Origin(ADT.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="PipelineName" /> property.</summary>
        private string _pipelineName;

        /// <summary>The name for the pipeline to perform the operation on.</summary>
        [ADT.Origin(ADT.PropertyOrigin.Owned)]
        public string PipelineName { get => this._pipelineName; set => this._pipelineName = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [ADT.Origin(ADT.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [ADT.Origin(ADT.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Creates an new <see cref="DataTransferIdentity" /> instance.</summary>
        public DataTransferIdentity()
        {

        }
    }
    public partial interface IDataTransferIdentity :
        ADT.Runtime.IJsonSerializable
    {
        /// <summary>The name for the connection to perform the operation on.</summary>
        [ADT.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name for the connection to perform the operation on.",
        SerializedName = @"connectionName",
        PossibleTypes = new [] { typeof(string) })]
        string ConnectionName { get; set; }
        /// <summary>The name for the flow to perform the operation on.</summary>
        [ADT.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name for the flow to perform the operation on.",
        SerializedName = @"flowName",
        PossibleTypes = new [] { typeof(string) })]
        string FlowName { get; set; }
        /// <summary>Resource identity path</summary>
        [ADT.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name for the pipeline to perform the operation on.</summary>
        [ADT.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name for the pipeline to perform the operation on.",
        SerializedName = @"pipelineName",
        PossibleTypes = new [] { typeof(string) })]
        string PipelineName { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [ADT.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        [ADT.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription. The value must be an UUID.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }

    }
    internal partial interface IDataTransferIdentityInternal

    {
        /// <summary>The name for the connection to perform the operation on.</summary>
        string ConnectionName { get; set; }
        /// <summary>The name for the flow to perform the operation on.</summary>
        string FlowName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name for the pipeline to perform the operation on.</summary>
        string PipelineName { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>The ID of the target subscription. The value must be an UUID.</summary>
        string SubscriptionId { get; set; }

    }
}