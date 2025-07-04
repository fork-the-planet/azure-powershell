// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.Extensions;

    public partial class TriggerPropertiesRecurrence :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesRecurrence,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerPropertiesRecurrenceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrence"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrence __triggerRecurrence = new Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.TriggerRecurrence();

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).EndTime = value ?? default(global::System.DateTime); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string Frequency { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).Frequency; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).Frequency = value ?? null; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public int? Interval { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).Interval; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).Interval = value ?? default(int); }

        /// <summary>Internal Acessors for Schedule</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceSchedule Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal.Schedule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).Schedule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).Schedule = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceSchedule Schedule { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).Schedule; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).Schedule = value ?? null /* model class */; }

        /// <summary>Dictionary of <any></summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleAdditionalProperties ScheduleAdditionalProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).ScheduleAdditionalProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).ScheduleAdditionalProperty = value ?? null /* model class */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<int> ScheduleHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).ScheduleHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).ScheduleHour = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<int> ScheduleMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).ScheduleMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).ScheduleMinute = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<int> ScheduleMonthDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).ScheduleMonthDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).ScheduleMonthDay = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.IRecurrenceScheduleOccurrence> ScheduleMonthlyOccurrence { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).ScheduleMonthlyOccurrence; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).ScheduleMonthlyOccurrence = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public System.Collections.Generic.List<string> ScheduleWeekDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).ScheduleWeekDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).ScheduleWeekDay = value ?? null /* arrayOf */; }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).StartTime = value ?? default(global::System.DateTime); }

        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.PropertyOrigin.Inherited)]
        public string TimeZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).TimeZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal)__triggerRecurrence).TimeZone = value ?? null; }

        /// <summary>Creates an new <see cref="TriggerPropertiesRecurrence" /> instance.</summary>
        public TriggerPropertiesRecurrence()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__triggerRecurrence), __triggerRecurrence);
            await eventListener.AssertObjectIsValid(nameof(__triggerRecurrence), __triggerRecurrence);
        }
    }
    public partial interface ITriggerPropertiesRecurrence :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrence
    {

    }
    internal partial interface ITriggerPropertiesRecurrenceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.ITriggerRecurrenceInternal
    {

    }
}