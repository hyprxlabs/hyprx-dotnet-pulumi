// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataBoxEdge.Inputs;

namespace Pulumi.AzureNative.DataBoxEdge;

public static partial class SkuArgsExtensions
{
    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.SkuArgs WithName(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.SkuArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataBoxEdge.SkuName> name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBoxEdge.Inputs.SkuArgs WithTier(this global::Pulumi.AzureNative.DataBoxEdge.Inputs.SkuArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataBoxEdge.SkuTier> tier)
    {
        @selfRef.Tier = tier;
        return @selfRef;
    }

}
