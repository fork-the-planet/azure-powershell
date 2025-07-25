﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Insights.TransitionalClasses;
using System;

namespace Microsoft.Azure.Management.Monitor.Management.Models
{
    /// <summary>
    /// This class is intended to help in the transition between namespaces, since it will be a breaking change that needs to be announced and delayed 6 months.
    /// It is identical to the RuleCondition, but in the old namespace
    /// </summary>
    public class ThresholdRuleCondition : RuleCondition
    {
        /// <summary>
        /// Gets or sets the OperatorProperty of the ThresholdRuleCondition
        /// </summary>
        public ConditionOperator OperatorProperty { get; set; }

        /// <summary>
        /// Gets or sets the Threshold of the ThresholdRuleCondition
        /// </summary>
        public double Threshold { get; set; }

        /// <summary>
        /// Gets or sets the WindowsSize of the ThresholdRuleCondition
        /// </summary>
        public TimeSpan? WindowSize { get; set; }

        /// <summary>
        /// Gets or sets the TimeAggregation of the ThresholdRuleCondition
        /// </summary>
        public TimeAggregationOperator? TimeAggregation { get; set; }

        /// <summary>
        /// Initializes a new instance of the RuleCondition class.
        /// </summary>
        public ThresholdRuleCondition()
            : base()
        { }

        /// <summary>
        /// Initializes a new instance of the RuleCondition class.
        /// </summary>
        /// <param name="ruleCondition">The RuleCondition object</param>
        public ThresholdRuleCondition(Monitor.Models.ThresholdRuleCondition ruleCondition)
            : base()
        {
            if (ruleCondition != null)
            {
                this.DataSource = ruleCondition.DataSource != null ? new RuleDataSource(ruleCondition.DataSource) : null;
                this.OperatorProperty = TransitionHelpers.ConvertNamespace(ruleCondition.OperatorProperty);
                this.Threshold = ruleCondition.Threshold;
                this.WindowSize = ruleCondition.WindowSize;
                this.TimeAggregation = TransitionHelpers.ConvertNamespace(ruleCondition.TimeAggregation);
            }
        }
    }
}
