// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class FeatureAttributionMetricThresholdArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionMetricThresholdArgs WithMetric(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionMetricThresholdArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.FeatureAttributionMetric> metric)
    {
        @selfRef.Metric = metric;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionMetricThresholdArgs WithThreshold(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionMetricThresholdArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.MonitoringThresholdArgs threshold)
    {
        @selfRef.Threshold = threshold;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionMetricThresholdArgs WithThreshold(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionMetricThresholdArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.MonitoringThresholdArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.MonitoringThresholdArgs();
        @configure(@item);
        @selfRef.Threshold = @item;
        return @selfRef;
    }

}
