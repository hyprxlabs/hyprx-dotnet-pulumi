// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ElasticSan.Inputs;

namespace Pulumi.AzureNative.ElasticSan;

public static partial class VirtualNetworkRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.ElasticSan.Inputs.VirtualNetworkRuleArgs WithAction(this global::Pulumi.AzureNative.ElasticSan.Inputs.VirtualNetworkRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ElasticSan.Action> action)
    {
        @selfRef.Action = action;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ElasticSan.Inputs.VirtualNetworkRuleArgs WithVirtualNetworkResourceId(this global::Pulumi.AzureNative.ElasticSan.Inputs.VirtualNetworkRuleArgs @selfRef, global::System.String virtualNetworkResourceId)
    {
        @selfRef.VirtualNetworkResourceId = virtualNetworkResourceId;
        return @selfRef;
    }

}
