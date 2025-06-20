// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.KeyVault.Inputs;

namespace Pulumi.AzureNative.KeyVault;

public static partial class NetworkRuleSetArgsExtensions
{
    public static global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs WithBypass(this global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.KeyVault.NetworkRuleBypassOptions> bypass)
    {
        @selfRef.Bypass = bypass;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs WithDefaultAction(this global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.KeyVault.NetworkRuleAction> defaultAction)
    {
        @selfRef.DefaultAction = defaultAction;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs WithIpRules(this global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.IPRuleArgs> ipRules)
    {
        @selfRef.IpRules = ipRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs WithIpRules(this global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.IPRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.IPRuleArgs>();
        @configure(@list);
        @selfRef.IpRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs WithIpRules(this global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.KeyVault.Inputs.IPRuleArgs>> @create)
    {
        @selfRef.IpRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs WithVirtualNetworkRules(this global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.VirtualNetworkRuleArgs> virtualNetworkRules)
    {
        @selfRef.VirtualNetworkRules = virtualNetworkRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs WithVirtualNetworkRules(this global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.VirtualNetworkRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.VirtualNetworkRuleArgs>();
        @configure(@list);
        @selfRef.VirtualNetworkRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs WithVirtualNetworkRules(this global::Pulumi.AzureNative.KeyVault.Inputs.NetworkRuleSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.KeyVault.Inputs.VirtualNetworkRuleArgs>> @create)
    {
        @selfRef.VirtualNetworkRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
