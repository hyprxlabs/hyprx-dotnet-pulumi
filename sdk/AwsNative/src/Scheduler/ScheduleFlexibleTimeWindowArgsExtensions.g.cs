// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Scheduler.Inputs;

namespace Pulumi.AwsNative.Scheduler;

public static partial class ScheduleFlexibleTimeWindowArgsExtensions
{
    public static global::Pulumi.AwsNative.Scheduler.Inputs.ScheduleFlexibleTimeWindowArgs WithMaximumWindowInMinutes(this global::Pulumi.AwsNative.Scheduler.Inputs.ScheduleFlexibleTimeWindowArgs @selfRef, global::System.Double maximumWindowInMinutes)
    {
        @selfRef.MaximumWindowInMinutes = maximumWindowInMinutes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Scheduler.Inputs.ScheduleFlexibleTimeWindowArgs WithMode(this global::Pulumi.AwsNative.Scheduler.Inputs.ScheduleFlexibleTimeWindowArgs @selfRef, global::Pulumi.AwsNative.Scheduler.ScheduleFlexibleTimeWindowMode mode)
    {
        @selfRef.Mode = mode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Scheduler.Inputs.ScheduleFlexibleTimeWindowArgs WithMode(this global::Pulumi.AwsNative.Scheduler.Inputs.ScheduleFlexibleTimeWindowArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Scheduler.ScheduleFlexibleTimeWindowMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Scheduler.ScheduleFlexibleTimeWindowMode>();
        @configure(@item);
        @selfRef.Mode = @item;
        return @selfRef;
    }

}
