// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ApplicationAutoScaling.Inputs;

namespace Pulumi.AwsNative.ApplicationAutoScaling;

public static partial class ScalingPolicyPredictiveScalingMetricArgsExtensions
{
    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricArgs WithDimensions(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricDimensionArgs> dimensions)
    {
        @selfRef.Dimensions = dimensions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricArgs WithDimensions(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricDimensionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricDimensionArgs>();
        @configure(@list);
        @selfRef.Dimensions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricArgs WithDimensions(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricDimensionArgs>> @create)
    {
        @selfRef.Dimensions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricArgs WithMetricName(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricArgs @selfRef, global::System.String metricName)
    {
        @selfRef.MetricName = metricName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricArgs WithNamespace(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricArgs @selfRef, global::System.String @namespace)
    {
        @selfRef.Namespace = @namespace;
        return @selfRef;
    }

}
