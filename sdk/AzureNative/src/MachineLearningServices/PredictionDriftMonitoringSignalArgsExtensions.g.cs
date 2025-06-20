// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class PredictionDriftMonitoringSignalArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithFeatureDataTypeOverride(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringFeatureDataType>> featureDataTypeOverride)
    {
        @selfRef.FeatureDataTypeOverride = featureDataTypeOverride;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithFeatureDataTypeOverride(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringFeatureDataType>>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringFeatureDataType>>();
        @configure(@dict);
        @selfRef.FeatureDataTypeOverride = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithFeatureDataTypeOverride(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringFeatureDataType>>> @create)
    {
        @selfRef.FeatureDataTypeOverride = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithMetricThresholds(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CategoricalPredictionDriftMetricThresholdArgs, global::Pulumi.AzureNative.MachineLearningServices.Inputs.NumericalPredictionDriftMetricThresholdArgs>> metricThresholds)
    {
        @selfRef.MetricThresholds = metricThresholds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithMetricThresholds(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CategoricalPredictionDriftMetricThresholdArgs, global::Pulumi.AzureNative.MachineLearningServices.Inputs.NumericalPredictionDriftMetricThresholdArgs>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CategoricalPredictionDriftMetricThresholdArgs, global::Pulumi.AzureNative.MachineLearningServices.Inputs.NumericalPredictionDriftMetricThresholdArgs>>();
        @configure(@list);
        @selfRef.MetricThresholds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithMetricThresholds(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CategoricalPredictionDriftMetricThresholdArgs, global::Pulumi.AzureNative.MachineLearningServices.Inputs.NumericalPredictionDriftMetricThresholdArgs>>> @create)
    {
        @selfRef.MetricThresholds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithNotificationTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>> notificationTypes)
    {
        @selfRef.NotificationTypes = notificationTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithNotificationTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>>();
        @configure(@list);
        @selfRef.NotificationTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithNotificationTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>>> @create)
    {
        @selfRef.NotificationTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Properties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Properties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs WithSignalType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PredictionDriftMonitoringSignalArgs @selfRef, global::System.String signalType)
    {
        @selfRef.SignalType = signalType;
        return @selfRef;
    }

}
