// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.StorSimple.Inputs;

namespace Pulumi.AzureNative.StorSimple;

public static partial class ScheduleRecurrenceArgsExtensions
{
    public static global::Pulumi.AzureNative.StorSimple.Inputs.ScheduleRecurrenceArgs WithRecurrenceType(this global::Pulumi.AzureNative.StorSimple.Inputs.ScheduleRecurrenceArgs @selfRef, global::Pulumi.AzureNative.StorSimple.RecurrenceType recurrenceType)
    {
        @selfRef.RecurrenceType = recurrenceType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorSimple.Inputs.ScheduleRecurrenceArgs WithRecurrenceType(this global::Pulumi.AzureNative.StorSimple.Inputs.ScheduleRecurrenceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.StorSimple.RecurrenceType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.StorSimple.RecurrenceType>();
        @configure(@item);
        @selfRef.RecurrenceType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorSimple.Inputs.ScheduleRecurrenceArgs WithRecurrenceValue(this global::Pulumi.AzureNative.StorSimple.Inputs.ScheduleRecurrenceArgs @selfRef, global::System.Int32 recurrenceValue)
    {
        @selfRef.RecurrenceValue = recurrenceValue;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorSimple.Inputs.ScheduleRecurrenceArgs WithWeeklyDaysList(this global::Pulumi.AzureNative.StorSimple.Inputs.ScheduleRecurrenceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.StorSimple.DayOfWeek> weeklyDaysList)
    {
        @selfRef.WeeklyDaysList = weeklyDaysList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorSimple.Inputs.ScheduleRecurrenceArgs WithWeeklyDaysList(this global::Pulumi.AzureNative.StorSimple.Inputs.ScheduleRecurrenceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.StorSimple.DayOfWeek>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.StorSimple.DayOfWeek>();
        @configure(@list);
        @selfRef.WeeklyDaysList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorSimple.Inputs.ScheduleRecurrenceArgs WithWeeklyDaysList(this global::Pulumi.AzureNative.StorSimple.Inputs.ScheduleRecurrenceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.StorSimple.DayOfWeek>> @create)
    {
        @selfRef.WeeklyDaysList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
