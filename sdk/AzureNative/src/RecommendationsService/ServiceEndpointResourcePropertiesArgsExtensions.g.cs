// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RecommendationsService.Inputs;

namespace Pulumi.AzureNative.RecommendationsService;

public static partial class ServiceEndpointResourcePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.RecommendationsService.Inputs.ServiceEndpointResourcePropertiesArgs WithPreAllocatedCapacity(this global::Pulumi.AzureNative.RecommendationsService.Inputs.ServiceEndpointResourcePropertiesArgs @selfRef, global::System.Int32 preAllocatedCapacity)
    {
        @selfRef.PreAllocatedCapacity = preAllocatedCapacity;
        return @selfRef;
    }

}
