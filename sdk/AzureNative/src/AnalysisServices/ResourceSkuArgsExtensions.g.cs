// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AnalysisServices.Inputs;

namespace Pulumi.AzureNative.AnalysisServices;

public static partial class ResourceSkuArgsExtensions
{
    public static global::Pulumi.AzureNative.AnalysisServices.Inputs.ResourceSkuArgs WithCapacity(this global::Pulumi.AzureNative.AnalysisServices.Inputs.ResourceSkuArgs @selfRef, global::System.Int32 capacity)
    {
        @selfRef.Capacity = capacity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AnalysisServices.Inputs.ResourceSkuArgs WithName(this global::Pulumi.AzureNative.AnalysisServices.Inputs.ResourceSkuArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AnalysisServices.Inputs.ResourceSkuArgs WithTier(this global::Pulumi.AzureNative.AnalysisServices.Inputs.ResourceSkuArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AnalysisServices.SkuTier> tier)
    {
        @selfRef.Tier = tier;
        return @selfRef;
    }

}
