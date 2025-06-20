// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Workloads;

public static partial class AlertArgsExtensions
{
    public static global::Pulumi.AzureNative.Workloads.AlertArgs WithAlertName(this global::Pulumi.AzureNative.Workloads.AlertArgs @selfRef, global::System.String alertName)
    {
        @selfRef.AlertName = alertName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.AlertArgs WithAlertRuleProperties(this global::Pulumi.AzureNative.Workloads.AlertArgs @selfRef, global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs alertRuleProperties)
    {
        @selfRef.AlertRuleProperties = alertRuleProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.AlertArgs WithAlertRuleProperties(this global::Pulumi.AzureNative.Workloads.AlertArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs();
        @configure(@item);
        @selfRef.AlertRuleProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.AlertArgs WithMonitorName(this global::Pulumi.AzureNative.Workloads.AlertArgs @selfRef, global::System.String monitorName)
    {
        @selfRef.MonitorName = monitorName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.AlertArgs WithProviderNames(this global::Pulumi.AzureNative.Workloads.AlertArgs @selfRef, global::System.Collections.Generic.List<global::System.String> providerNames)
    {
        @selfRef.ProviderNames = providerNames;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.AlertArgs WithProviderNames(this global::Pulumi.AzureNative.Workloads.AlertArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ProviderNames = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.AlertArgs WithProviderNames(this global::Pulumi.AzureNative.Workloads.AlertArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ProviderNames = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.AlertArgs WithProviderType(this global::Pulumi.AzureNative.Workloads.AlertArgs @selfRef, global::System.String providerType)
    {
        @selfRef.ProviderType = providerType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.AlertArgs WithResourceGroupName(this global::Pulumi.AzureNative.Workloads.AlertArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.AlertArgs WithTemplateName(this global::Pulumi.AzureNative.Workloads.AlertArgs @selfRef, global::System.String templateName)
    {
        @selfRef.TemplateName = templateName;
        return @selfRef;
    }

}
