// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class CustomMonitoringSignalArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithComponentId(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.String componentId)
    {
        @selfRef.ComponentId = componentId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithInputAssets(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.Object> inputAssets)
    {
        @selfRef.InputAssets = inputAssets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithInputAssets(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Object>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.Object>();
        @configure(@dict);
        @selfRef.InputAssets = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithInputAssets(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.Object>> @create)
    {
        @selfRef.InputAssets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithInputs(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.Object> inputs)
    {
        @selfRef.Inputs = inputs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithInputs(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Object>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.Object>();
        @configure(@dict);
        @selfRef.Inputs = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithInputs(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.Object>> @create)
    {
        @selfRef.Inputs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithMetricThresholds(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMetricThresholdArgs> metricThresholds)
    {
        @selfRef.MetricThresholds = metricThresholds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithMetricThresholds(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMetricThresholdArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMetricThresholdArgs>();
        @configure(@list);
        @selfRef.MetricThresholds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithMetricThresholds(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMetricThresholdArgs>> @create)
    {
        @selfRef.MetricThresholds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithNotificationTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>> notificationTypes)
    {
        @selfRef.NotificationTypes = notificationTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithNotificationTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>>();
        @configure(@list);
        @selfRef.NotificationTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithNotificationTypes(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.MonitoringNotificationType>>> @create)
    {
        @selfRef.NotificationTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Properties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Properties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs WithSignalType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.CustomMonitoringSignalArgs @selfRef, global::System.String signalType)
    {
        @selfRef.SignalType = signalType;
        return @selfRef;
    }

}
