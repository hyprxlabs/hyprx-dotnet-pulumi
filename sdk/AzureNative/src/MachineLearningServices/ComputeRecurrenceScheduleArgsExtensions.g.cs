// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class ComputeRecurrenceScheduleArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs WithHours(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs @selfRef, global::System.Collections.Generic.List<global::System.Int32> hours)
    {
        @selfRef.Hours = hours;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs WithHours(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Int32>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Int32>();
        @configure(@list);
        @selfRef.Hours = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs WithHours(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Int32>> @create)
    {
        @selfRef.Hours = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs WithMinutes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs @selfRef, global::System.Collections.Generic.List<global::System.Int32> minutes)
    {
        @selfRef.Minutes = minutes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs WithMinutes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Int32>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Int32>();
        @configure(@list);
        @selfRef.Minutes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs WithMinutes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Int32>> @create)
    {
        @selfRef.Minutes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs WithMonthDays(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs @selfRef, global::System.Collections.Generic.List<global::System.Int32> monthDays)
    {
        @selfRef.MonthDays = monthDays;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs WithMonthDays(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Int32>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Int32>();
        @configure(@list);
        @selfRef.MonthDays = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs WithMonthDays(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Int32>> @create)
    {
        @selfRef.MonthDays = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs WithWeekDays(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.ComputeWeekDay>> weekDays)
    {
        @selfRef.WeekDays = weekDays;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs WithWeekDays(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.ComputeWeekDay>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.ComputeWeekDay>>();
        @configure(@list);
        @selfRef.WeekDays = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs WithWeekDays(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ComputeRecurrenceScheduleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.ComputeWeekDay>>> @create)
    {
        @selfRef.WeekDays = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
