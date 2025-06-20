// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class DataDriftMonitoringSignalArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithFeatureDataTypeOverride(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringFeatureDataType>> featureDataTypeOverride)
    {
        @selfRef.FeatureDataTypeOverride = featureDataTypeOverride;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithFeatureDataTypeOverride(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringFeatureDataType>>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringFeatureDataType>>();
        @configure(@dict);
        @selfRef.FeatureDataTypeOverride = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithFeatureDataTypeOverride(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringFeatureDataType>>> @create)
    {
        @selfRef.FeatureDataTypeOverride = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithFeatureImportanceSettings(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureImportanceSettingsArgs featureImportanceSettings)
    {
        @selfRef.FeatureImportanceSettings = featureImportanceSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithFeatureImportanceSettings(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureImportanceSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureImportanceSettingsArgs();
        @configure(@item);
        @selfRef.FeatureImportanceSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithMetricThresholds(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CategoricalDataDriftMetricThresholdArgs, global::Pulumi.AzureNative.MachineLearningServices.Inputs.NumericalDataDriftMetricThresholdArgs>> metricThresholds)
    {
        @selfRef.MetricThresholds = metricThresholds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithMetricThresholds(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CategoricalDataDriftMetricThresholdArgs, global::Pulumi.AzureNative.MachineLearningServices.Inputs.NumericalDataDriftMetricThresholdArgs>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CategoricalDataDriftMetricThresholdArgs, global::Pulumi.AzureNative.MachineLearningServices.Inputs.NumericalDataDriftMetricThresholdArgs>>();
        @configure(@list);
        @selfRef.MetricThresholds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithMetricThresholds(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CategoricalDataDriftMetricThresholdArgs, global::Pulumi.AzureNative.MachineLearningServices.Inputs.NumericalDataDriftMetricThresholdArgs>>> @create)
    {
        @selfRef.MetricThresholds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithNotificationTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>> notificationTypes)
    {
        @selfRef.NotificationTypes = notificationTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithNotificationTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>>();
        @configure(@list);
        @selfRef.NotificationTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithNotificationTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>>> @create)
    {
        @selfRef.NotificationTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Properties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Properties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs WithSignalType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.DataDriftMonitoringSignalArgs @selfRef, global::System.String signalType)
    {
        @selfRef.SignalType = signalType;
        return @selfRef;
    }

}
