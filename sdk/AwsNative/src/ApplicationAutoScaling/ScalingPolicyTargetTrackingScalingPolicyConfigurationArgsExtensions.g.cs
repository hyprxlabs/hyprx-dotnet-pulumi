// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ApplicationAutoScaling.Inputs;

namespace Pulumi.AwsNative.ApplicationAutoScaling;

public static partial class ScalingPolicyTargetTrackingScalingPolicyConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs WithCustomizedMetricSpecification(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs @selfRef, global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyCustomizedMetricSpecificationArgs customizedMetricSpecification)
    {
        @selfRef.CustomizedMetricSpecification = customizedMetricSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs WithCustomizedMetricSpecification(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyCustomizedMetricSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyCustomizedMetricSpecificationArgs();
        @configure(@item);
        @selfRef.CustomizedMetricSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs WithDisableScaleIn(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs @selfRef, bool disableScaleIn = true)
    {
        @selfRef.DisableScaleIn = disableScaleIn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs WithPredefinedMetricSpecification(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs @selfRef, global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredefinedMetricSpecificationArgs predefinedMetricSpecification)
    {
        @selfRef.PredefinedMetricSpecification = predefinedMetricSpecification;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs WithPredefinedMetricSpecification(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredefinedMetricSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyPredefinedMetricSpecificationArgs();
        @configure(@item);
        @selfRef.PredefinedMetricSpecification = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs WithScaleInCooldown(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs @selfRef, global::System.Int32 scaleInCooldown)
    {
        @selfRef.ScaleInCooldown = scaleInCooldown;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs WithScaleOutCooldown(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs @selfRef, global::System.Int32 scaleOutCooldown)
    {
        @selfRef.ScaleOutCooldown = scaleOutCooldown;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs WithTargetValue(this global::Pulumi.AwsNative.ApplicationAutoScaling.Inputs.ScalingPolicyTargetTrackingScalingPolicyConfigurationArgs @selfRef, global::System.Double targetValue)
    {
        @selfRef.TargetValue = targetValue;
        return @selfRef;
    }

}
