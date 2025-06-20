// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoT.Inputs;

namespace Pulumi.AwsNative.IoT;

public static partial class SecurityProfileBehaviorCriteriaArgsExtensions
{
    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs WithComparisonOperator(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs @selfRef, global::Pulumi.AwsNative.IoT.SecurityProfileBehaviorCriteriaComparisonOperator comparisonOperator)
    {
        @selfRef.ComparisonOperator = comparisonOperator;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs WithComparisonOperator(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.SecurityProfileBehaviorCriteriaComparisonOperator> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.IoT.SecurityProfileBehaviorCriteriaComparisonOperator>();
        @configure(@item);
        @selfRef.ComparisonOperator = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs WithConsecutiveDatapointsToAlarm(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs @selfRef, global::System.Int32 consecutiveDatapointsToAlarm)
    {
        @selfRef.ConsecutiveDatapointsToAlarm = consecutiveDatapointsToAlarm;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs WithConsecutiveDatapointsToClear(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs @selfRef, global::System.Int32 consecutiveDatapointsToClear)
    {
        @selfRef.ConsecutiveDatapointsToClear = consecutiveDatapointsToClear;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs WithDurationSeconds(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs @selfRef, global::System.Int32 durationSeconds)
    {
        @selfRef.DurationSeconds = durationSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs WithMlDetectionConfig(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs @selfRef, global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMachineLearningDetectionConfigArgs mlDetectionConfig)
    {
        @selfRef.MlDetectionConfig = mlDetectionConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs WithMlDetectionConfig(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMachineLearningDetectionConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMachineLearningDetectionConfigArgs();
        @configure(@item);
        @selfRef.MlDetectionConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs WithStatisticalThreshold(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs @selfRef, global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileStatisticalThresholdArgs statisticalThreshold)
    {
        @selfRef.StatisticalThreshold = statisticalThreshold;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs WithStatisticalThreshold(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileStatisticalThresholdArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileStatisticalThresholdArgs();
        @configure(@item);
        @selfRef.StatisticalThreshold = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs WithValue(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs @selfRef, global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricValueArgs value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs WithValue(this global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileBehaviorCriteriaArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricValueArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoT.Inputs.SecurityProfileMetricValueArgs();
        @configure(@item);
        @selfRef.Value = @item;
        return @selfRef;
    }

}
