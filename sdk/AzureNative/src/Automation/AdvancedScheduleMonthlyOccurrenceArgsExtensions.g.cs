// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Automation.Inputs;

namespace Pulumi.AzureNative.Automation;

public static partial class AdvancedScheduleMonthlyOccurrenceArgsExtensions
{
    public static global::Pulumi.AzureNative.Automation.Inputs.AdvancedScheduleMonthlyOccurrenceArgs WithDay(this global::Pulumi.AzureNative.Automation.Inputs.AdvancedScheduleMonthlyOccurrenceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Automation.ScheduleDay> day)
    {
        @selfRef.Day = day;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.AdvancedScheduleMonthlyOccurrenceArgs WithOccurrence(this global::Pulumi.AzureNative.Automation.Inputs.AdvancedScheduleMonthlyOccurrenceArgs @selfRef, global::System.Int32 occurrence)
    {
        @selfRef.Occurrence = occurrence;
        return @selfRef;
    }

}
