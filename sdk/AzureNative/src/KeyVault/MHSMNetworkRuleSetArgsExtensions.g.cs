// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.KeyVault.Inputs;

namespace Pulumi.AzureNative.KeyVault;

public static partial class MHSMNetworkRuleSetArgsExtensions
{
    public static global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs WithBypass(this global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.KeyVault.NetworkRuleBypassOptions> bypass)
    {
        @selfRef.Bypass = bypass;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs WithDefaultAction(this global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.KeyVault.NetworkRuleAction> defaultAction)
    {
        @selfRef.DefaultAction = defaultAction;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs WithIpRules(this global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.MHSMIPRuleArgs> ipRules)
    {
        @selfRef.IpRules = ipRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs WithIpRules(this global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.MHSMIPRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.MHSMIPRuleArgs>();
        @configure(@list);
        @selfRef.IpRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs WithIpRules(this global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.KeyVault.Inputs.MHSMIPRuleArgs>> @create)
    {
        @selfRef.IpRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs WithVirtualNetworkRules(this global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.MHSMVirtualNetworkRuleArgs> virtualNetworkRules)
    {
        @selfRef.VirtualNetworkRules = virtualNetworkRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs WithVirtualNetworkRules(this global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.MHSMVirtualNetworkRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.KeyVault.Inputs.MHSMVirtualNetworkRuleArgs>();
        @configure(@list);
        @selfRef.VirtualNetworkRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs WithVirtualNetworkRules(this global::Pulumi.AzureNative.KeyVault.Inputs.MHSMNetworkRuleSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.KeyVault.Inputs.MHSMVirtualNetworkRuleArgs>> @create)
    {
        @selfRef.VirtualNetworkRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
