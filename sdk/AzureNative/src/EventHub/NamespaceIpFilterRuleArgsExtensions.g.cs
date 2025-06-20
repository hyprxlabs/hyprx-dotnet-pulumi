// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.EventHub;

public static partial class NamespaceIpFilterRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.EventHub.NamespaceIpFilterRuleArgs WithAction(this global::Pulumi.AzureNative.EventHub.NamespaceIpFilterRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.EventHub.IPAction> action)
    {
        @selfRef.Action = action;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceIpFilterRuleArgs WithFilterName(this global::Pulumi.AzureNative.EventHub.NamespaceIpFilterRuleArgs @selfRef, global::System.String filterName)
    {
        @selfRef.FilterName = filterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceIpFilterRuleArgs WithIpFilterRuleName(this global::Pulumi.AzureNative.EventHub.NamespaceIpFilterRuleArgs @selfRef, global::System.String ipFilterRuleName)
    {
        @selfRef.IpFilterRuleName = ipFilterRuleName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceIpFilterRuleArgs WithIpMask(this global::Pulumi.AzureNative.EventHub.NamespaceIpFilterRuleArgs @selfRef, global::System.String ipMask)
    {
        @selfRef.IpMask = ipMask;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceIpFilterRuleArgs WithNamespaceName(this global::Pulumi.AzureNative.EventHub.NamespaceIpFilterRuleArgs @selfRef, global::System.String namespaceName)
    {
        @selfRef.NamespaceName = namespaceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceIpFilterRuleArgs WithResourceGroupName(this global::Pulumi.AzureNative.EventHub.NamespaceIpFilterRuleArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
