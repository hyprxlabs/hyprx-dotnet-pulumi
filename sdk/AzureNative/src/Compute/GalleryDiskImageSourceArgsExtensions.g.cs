// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class GalleryDiskImageSourceArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryDiskImageSourceArgs WithId(this global::Pulumi.AzureNative.Compute.Inputs.GalleryDiskImageSourceArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryDiskImageSourceArgs WithStorageAccountId(this global::Pulumi.AzureNative.Compute.Inputs.GalleryDiskImageSourceArgs @selfRef, global::System.String storageAccountId)
    {
        @selfRef.StorageAccountId = storageAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryDiskImageSourceArgs WithUri(this global::Pulumi.AzureNative.Compute.Inputs.GalleryDiskImageSourceArgs @selfRef, global::System.String uri)
    {
        @selfRef.Uri = uri;
        return @selfRef;
    }

}
