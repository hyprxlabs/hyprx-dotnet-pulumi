// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AutoScaling.Inputs;

namespace Pulumi.AwsNative.AutoScaling;

public static partial class ScalingPolicyTargetTrackingMetricDataQueryArgsExtensions
{
    public static global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs WithExpression(this global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs @selfRef, global::System.String expression)
    {
        @selfRef.Expression = expression;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs WithId(this global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs WithLabel(this global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs @selfRef, global::System.String label)
    {
        @selfRef.Label = label;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs WithMetricStat(this global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs @selfRef, global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricStatArgs metricStat)
    {
        @selfRef.MetricStat = metricStat;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs WithMetricStat(this global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricStatArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricStatArgs();
        @configure(@item);
        @selfRef.MetricStat = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs WithPeriod(this global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs @selfRef, global::System.Int32 period)
    {
        @selfRef.Period = period;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs WithReturnData(this global::Pulumi.AwsNative.AutoScaling.Inputs.ScalingPolicyTargetTrackingMetricDataQueryArgs @selfRef, bool returnData = true)
    {
        @selfRef.ReturnData = returnData;
        return @selfRef;
    }

}
