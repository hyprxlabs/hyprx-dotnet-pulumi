// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class ManagedNetworkSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs WithFirewallSku(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.FirewallSku> firewallSku)
    {
        @selfRef.FirewallSku = firewallSku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs WithIsolationMode(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.IsolationMode> isolationMode)
    {
        @selfRef.IsolationMode = isolationMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs WithOutboundRules(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.Object> outboundRules)
    {
        @selfRef.OutboundRules = outboundRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs WithOutboundRules(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Object>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.Object>();
        @configure(@dict);
        @selfRef.OutboundRules = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs WithOutboundRules(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.Object>> @create)
    {
        @selfRef.OutboundRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs WithStatus(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkProvisionStatusArgs status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs WithStatus(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkSettingsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkProvisionStatusArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.ManagedNetworkProvisionStatusArgs();
        @configure(@item);
        @selfRef.Status = @item;
        return @selfRef;
    }

}
