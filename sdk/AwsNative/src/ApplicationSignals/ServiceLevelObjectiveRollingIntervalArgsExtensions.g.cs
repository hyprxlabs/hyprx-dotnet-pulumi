// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ApplicationSignals.Inputs;

namespace Pulumi.AwsNative.ApplicationSignals;

public static partial class ServiceLevelObjectiveRollingIntervalArgsExtensions
{
    public static global::Pulumi.AwsNative.ApplicationSignals.Inputs.ServiceLevelObjectiveRollingIntervalArgs WithDuration(this global::Pulumi.AwsNative.ApplicationSignals.Inputs.ServiceLevelObjectiveRollingIntervalArgs @selfRef, global::System.Int32 duration)
    {
        @selfRef.Duration = duration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationSignals.Inputs.ServiceLevelObjectiveRollingIntervalArgs WithDurationUnit(this global::Pulumi.AwsNative.ApplicationSignals.Inputs.ServiceLevelObjectiveRollingIntervalArgs @selfRef, global::Pulumi.AwsNative.ApplicationSignals.ServiceLevelObjectiveDurationUnit durationUnit)
    {
        @selfRef.DurationUnit = durationUnit;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationSignals.Inputs.ServiceLevelObjectiveRollingIntervalArgs WithDurationUnit(this global::Pulumi.AwsNative.ApplicationSignals.Inputs.ServiceLevelObjectiveRollingIntervalArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ApplicationSignals.ServiceLevelObjectiveDurationUnit> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.ApplicationSignals.ServiceLevelObjectiveDurationUnit>();
        @configure(@item);
        @selfRef.DurationUnit = @item;
        return @selfRef;
    }

}
