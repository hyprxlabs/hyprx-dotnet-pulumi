// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ApplicationAutoScaling.Inputs;

namespace Pulumi.AwsNative.ApplicationAutoScaling;

public static partial class ScalingPolicyPredictiveScalingPolicyConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs WithMaxCapacityBreachBehavior(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs @selfRef, global::System.String maxCapacityBreachBehavior)
    {
        @selfRef.MaxCapacityBreachBehavior = maxCapacityBreachBehavior;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs WithMaxCapacityBuffer(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs @selfRef, global::System.Int32 maxCapacityBuffer)
    {
        @selfRef.MaxCapacityBuffer = maxCapacityBuffer;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs WithMetricSpecifications(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricSpecificationArgs> metricSpecifications)
    {
        @selfRef.MetricSpecifications = metricSpecifications;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs WithMetricSpecifications(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricSpecificationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricSpecificationArgs>();
        @configure(@list);
        @selfRef.MetricSpecifications = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs WithMetricSpecifications(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingMetricSpecificationArgs>> @create)
    {
        @selfRef.MetricSpecifications = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs WithMode(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs @selfRef, global::System.String mode)
    {
        @selfRef.Mode = mode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs WithSchedulingBufferTime(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredictiveScalingPolicyConfigurationArgs @selfRef, global::System.Int32 schedulingBufferTime)
    {
        @selfRef.SchedulingBufferTime = schedulingBufferTime;
        return @selfRef;
    }

}
