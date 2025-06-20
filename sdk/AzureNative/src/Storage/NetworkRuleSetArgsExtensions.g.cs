// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Storage.Inputs;

namespace Pulumi.AzureNative.Storage;

public static partial class NetworkRuleSetArgsExtensions
{
    public static global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs WithBypass(this global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Storage.Bypass> bypass)
    {
        @selfRef.Bypass = bypass;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs WithDefaultAction(this global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs @selfRef, global::Pulumi.AzureNative.Storage.DefaultAction defaultAction)
    {
        @selfRef.DefaultAction = defaultAction;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs WithDefaultAction(this global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Storage.DefaultAction> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Storage.DefaultAction>();
        @configure(@item);
        @selfRef.DefaultAction = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs WithIpRules(this global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.IPRuleArgs> ipRules)
    {
        @selfRef.IpRules = ipRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs WithIpRules(this global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.IPRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.IPRuleArgs>();
        @configure(@list);
        @selfRef.IpRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs WithIpRules(this global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Storage.Inputs.IPRuleArgs>> @create)
    {
        @selfRef.IpRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs WithResourceAccessRules(this global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.ResourceAccessRuleArgs> resourceAccessRules)
    {
        @selfRef.ResourceAccessRules = resourceAccessRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs WithResourceAccessRules(this global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.ResourceAccessRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.ResourceAccessRuleArgs>();
        @configure(@list);
        @selfRef.ResourceAccessRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs WithResourceAccessRules(this global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Storage.Inputs.ResourceAccessRuleArgs>> @create)
    {
        @selfRef.ResourceAccessRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs WithVirtualNetworkRules(this global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.VirtualNetworkRuleArgs> virtualNetworkRules)
    {
        @selfRef.VirtualNetworkRules = virtualNetworkRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs WithVirtualNetworkRules(this global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.VirtualNetworkRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Storage.Inputs.VirtualNetworkRuleArgs>();
        @configure(@list);
        @selfRef.VirtualNetworkRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs WithVirtualNetworkRules(this global::Pulumi.AzureNative.Storage.Inputs.NetworkRuleSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Storage.Inputs.VirtualNetworkRuleArgs>> @create)
    {
        @selfRef.VirtualNetworkRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
