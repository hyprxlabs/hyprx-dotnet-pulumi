// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Evidently.Inputs;

namespace Pulumi.AwsNative.Evidently;

public static partial class ExperimentMetricGoalObjectArgsExtensions
{
    public static global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs WithDesiredChange(this global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs @selfRef, global::Pulumi.AwsNative.Evidently.ExperimentMetricGoalObjectDesiredChange desiredChange)
    {
        @selfRef.DesiredChange = desiredChange;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs WithDesiredChange(this global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Evidently.ExperimentMetricGoalObjectDesiredChange> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Evidently.ExperimentMetricGoalObjectDesiredChange>();
        @configure(@item);
        @selfRef.DesiredChange = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs WithEntityIdKey(this global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs @selfRef, global::System.String entityIdKey)
    {
        @selfRef.EntityIdKey = entityIdKey;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs WithEventPattern(this global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs @selfRef, global::System.String eventPattern)
    {
        @selfRef.EventPattern = eventPattern;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs WithMetricName(this global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs @selfRef, global::System.String metricName)
    {
        @selfRef.MetricName = metricName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs WithUnitLabel(this global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs @selfRef, global::System.String unitLabel)
    {
        @selfRef.UnitLabel = unitLabel;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs WithValueKey(this global::Pulumi.AwsNative.Evidently.Inputs.ExperimentMetricGoalObjectArgs @selfRef, global::System.String valueKey)
    {
        @selfRef.ValueKey = valueKey;
        return @selfRef;
    }

}
