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

using System.Text;
using Microsoft.Azure.Management.Monitor.Models;

namespace Microsoft.Azure.Commands.Insights.OutputClasses
{
    /// <summary>
    /// Wraps around the LogSettings
    /// </summary>
    public class PSLogSettings : PSDiagnosticDetailSettings
    {
        /// <summary>
        /// Initializes a new instance of the PSLogSettings class.
        /// </summary>
        public PSLogSettings(LogSettings logSettings)
        {
            if (logSettings != null)
            {
                this.Enabled = logSettings.Enabled;
                this.Category = logSettings.Category;
                this.RetentionPolicy = new PSRetentionPolicy(logSettings.RetentionPolicy);
            }
            this.CategoryType = PSDiagnosticSettingCategoryType.Logs;
        }

        public PSLogSettings() 
        {
        }

        /// <summary>
        /// A string representation of the PSLogSettings
        /// </summary>
        /// <returns>A string representation of the PSLogSettings</returns>
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine();
            output.AppendLine("Enabled         : " + Enabled);
            output.AppendLine("Category        : " + Category);
            output.Append("RetentionPolicy : " + RetentionPolicy.ToString(1));
            return output.ToString();
        }

        public LogSettings GetLogSetting()
        {
            return new LogSettings()
            {
                Enabled = this.Enabled,
                Category = this.Category,
                RetentionPolicy = this.RetentionPolicy
            };
        }
    }
}
