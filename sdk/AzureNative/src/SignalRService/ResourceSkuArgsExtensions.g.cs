// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SignalRService.Inputs;

namespace Pulumi.AzureNative.SignalRService;

public static partial class ResourceSkuArgsExtensions
{
    public static global::Pulumi.AzureNative.SignalRService.Inputs.ResourceSkuArgs WithCapacity(this global::Pulumi.AzureNative.SignalRService.Inputs.ResourceSkuArgs @selfRef, global::System.Int32 capacity)
    {
        @selfRef.Capacity = capacity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.Inputs.ResourceSkuArgs WithName(this global::Pulumi.AzureNative.SignalRService.Inputs.ResourceSkuArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.Inputs.ResourceSkuArgs WithTier(this global::Pulumi.AzureNative.SignalRService.Inputs.ResourceSkuArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SignalRService.SignalRSkuTier> tier)
    {
        @selfRef.Tier = tier;
        return @selfRef;
    }

}
