// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class ResourceRangeArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.ResourceRangeArgs WithMax(this global::Pulumi.AzureNative.Compute.Inputs.ResourceRangeArgs @selfRef, global::System.Int32 max)
    {
        @selfRef.Max = max;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.ResourceRangeArgs WithMin(this global::Pulumi.AzureNative.Compute.Inputs.ResourceRangeArgs @selfRef, global::System.Int32 min)
    {
        @selfRef.Min = min;
        return @selfRef;
    }

}
