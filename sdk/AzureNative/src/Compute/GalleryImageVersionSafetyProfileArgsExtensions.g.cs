// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class GalleryImageVersionSafetyProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryImageVersionSafetyProfileArgs WithAllowDeletionOfReplicatedLocations(this global::Pulumi.AzureNative.Compute.Inputs.GalleryImageVersionSafetyProfileArgs @selfRef, bool allowDeletionOfReplicatedLocations = true)
    {
        @selfRef.AllowDeletionOfReplicatedLocations = allowDeletionOfReplicatedLocations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryImageVersionSafetyProfileArgs WithBlockDeletionBeforeEndOfLife(this global::Pulumi.AzureNative.Compute.Inputs.GalleryImageVersionSafetyProfileArgs @selfRef, bool blockDeletionBeforeEndOfLife = true)
    {
        @selfRef.BlockDeletionBeforeEndOfLife = blockDeletionBeforeEndOfLife;
        return @selfRef;
    }

}
