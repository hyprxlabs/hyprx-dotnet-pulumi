// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.EventHub;

public static partial class NamespaceVirtualNetworkRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.EventHub.NamespaceVirtualNetworkRuleArgs WithNamespaceName(this global::Pulumi.AzureNative.EventHub.NamespaceVirtualNetworkRuleArgs @selfRef, global::System.String namespaceName)
    {
        @selfRef.NamespaceName = namespaceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceVirtualNetworkRuleArgs WithResourceGroupName(this global::Pulumi.AzureNative.EventHub.NamespaceVirtualNetworkRuleArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceVirtualNetworkRuleArgs WithVirtualNetworkRuleName(this global::Pulumi.AzureNative.EventHub.NamespaceVirtualNetworkRuleArgs @selfRef, global::System.String virtualNetworkRuleName)
    {
        @selfRef.VirtualNetworkRuleName = virtualNetworkRuleName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceVirtualNetworkRuleArgs WithVirtualNetworkSubnetId(this global::Pulumi.AzureNative.EventHub.NamespaceVirtualNetworkRuleArgs @selfRef, global::System.String virtualNetworkSubnetId)
    {
        @selfRef.VirtualNetworkSubnetId = virtualNetworkSubnetId;
        return @selfRef;
    }

}
