// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AppPlatform.Inputs;

namespace Pulumi.AzureNative.AppPlatform;

public static partial class SkuArgsExtensions
{
    public static global::Pulumi.AzureNative.AppPlatform.Inputs.SkuArgs WithCapacity(this global::Pulumi.AzureNative.AppPlatform.Inputs.SkuArgs @selfRef, global::System.Int32 capacity)
    {
        @selfRef.Capacity = capacity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.SkuArgs WithName(this global::Pulumi.AzureNative.AppPlatform.Inputs.SkuArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.SkuArgs WithTier(this global::Pulumi.AzureNative.AppPlatform.Inputs.SkuArgs @selfRef, global::System.String tier)
    {
        @selfRef.Tier = tier;
        return @selfRef;
    }

}
