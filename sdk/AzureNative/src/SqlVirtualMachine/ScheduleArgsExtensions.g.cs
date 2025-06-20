// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SqlVirtualMachine.Inputs;

namespace Pulumi.AzureNative.SqlVirtualMachine;

public static partial class ScheduleArgsExtensions
{
    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.ScheduleArgs WithDayOfWeek(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.ScheduleArgs @selfRef, global::Pulumi.AzureNative.SqlVirtualMachine.AssessmentDayOfWeek dayOfWeek)
    {
        @selfRef.DayOfWeek = dayOfWeek;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.ScheduleArgs WithDayOfWeek(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.ScheduleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.SqlVirtualMachine.AssessmentDayOfWeek> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.SqlVirtualMachine.AssessmentDayOfWeek>();
        @configure(@item);
        @selfRef.DayOfWeek = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.ScheduleArgs WithEnable(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.ScheduleArgs @selfRef, bool enable = true)
    {
        @selfRef.Enable = enable;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.ScheduleArgs WithMonthlyOccurrence(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.ScheduleArgs @selfRef, global::System.Int32 monthlyOccurrence)
    {
        @selfRef.MonthlyOccurrence = monthlyOccurrence;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.ScheduleArgs WithStartTime(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.ScheduleArgs @selfRef, global::System.String startTime)
    {
        @selfRef.StartTime = startTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.ScheduleArgs WithWeeklyInterval(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.ScheduleArgs @selfRef, global::System.Int32 weeklyInterval)
    {
        @selfRef.WeeklyInterval = weeklyInterval;
        return @selfRef;
    }

}
