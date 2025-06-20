// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class FeatureAttributionDriftMonitoringSignalArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithFeatureDataTypeOverride(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringFeatureDataType>> featureDataTypeOverride)
    {
        @selfRef.FeatureDataTypeOverride = featureDataTypeOverride;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithFeatureDataTypeOverride(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringFeatureDataType>>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringFeatureDataType>>();
        @configure(@dict);
        @selfRef.FeatureDataTypeOverride = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithFeatureDataTypeOverride(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringFeatureDataType>>> @create)
    {
        @selfRef.FeatureDataTypeOverride = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithFeatureImportanceSettings(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureImportanceSettingsArgs featureImportanceSettings)
    {
        @selfRef.FeatureImportanceSettings = featureImportanceSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithFeatureImportanceSettings(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureImportanceSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureImportanceSettingsArgs();
        @configure(@item);
        @selfRef.FeatureImportanceSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithMetricThreshold(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionMetricThresholdArgs metricThreshold)
    {
        @selfRef.MetricThreshold = metricThreshold;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithMetricThreshold(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionMetricThresholdArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionMetricThresholdArgs();
        @configure(@item);
        @selfRef.MetricThreshold = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithNotificationTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>> notificationTypes)
    {
        @selfRef.NotificationTypes = notificationTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithNotificationTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>>();
        @configure(@list);
        @selfRef.NotificationTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithNotificationTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>>> @create)
    {
        @selfRef.NotificationTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithProductionData(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> productionData)
    {
        @selfRef.ProductionData = productionData;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithProductionData(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.ProductionData = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithProductionData(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.ProductionData = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Properties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Properties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs WithSignalType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.FeatureAttributionDriftMonitoringSignalArgs @selfRef, global::System.String signalType)
    {
        @selfRef.SignalType = signalType;
        return @selfRef;
    }

}
