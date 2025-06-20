// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Datadog.Inputs;

namespace Pulumi.AzureNative.Datadog;

public static partial class MonitoringTagRulesPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Datadog.Inputs.MonitoringTagRulesPropertiesArgs WithAutomuting(this global::Pulumi.AzureNative.Datadog.Inputs.MonitoringTagRulesPropertiesArgs @selfRef, bool automuting = true)
    {
        @selfRef.Automuting = automuting;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Datadog.Inputs.MonitoringTagRulesPropertiesArgs WithCustomMetrics(this global::Pulumi.AzureNative.Datadog.Inputs.MonitoringTagRulesPropertiesArgs @selfRef, bool customMetrics = true)
    {
        @selfRef.CustomMetrics = customMetrics;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Datadog.Inputs.MonitoringTagRulesPropertiesArgs WithLogRules(this global::Pulumi.AzureNative.Datadog.Inputs.MonitoringTagRulesPropertiesArgs @selfRef, global::Pulumi.AzureNative.Datadog.Inputs.LogRulesArgs logRules)
    {
        @selfRef.LogRules = logRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Datadog.Inputs.MonitoringTagRulesPropertiesArgs WithLogRules(this global::Pulumi.AzureNative.Datadog.Inputs.MonitoringTagRulesPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Datadog.Inputs.LogRulesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Datadog.Inputs.LogRulesArgs();
        @configure(@item);
        @selfRef.LogRules = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Datadog.Inputs.MonitoringTagRulesPropertiesArgs WithMetricRules(this global::Pulumi.AzureNative.Datadog.Inputs.MonitoringTagRulesPropertiesArgs @selfRef, global::Pulumi.AzureNative.Datadog.Inputs.MetricRulesArgs metricRules)
    {
        @selfRef.MetricRules = metricRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Datadog.Inputs.MonitoringTagRulesPropertiesArgs WithMetricRules(this global::Pulumi.AzureNative.Datadog.Inputs.MonitoringTagRulesPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Datadog.Inputs.MetricRulesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Datadog.Inputs.MetricRulesArgs();
        @configure(@item);
        @selfRef.MetricRules = @item;
        return @selfRef;
    }

}
