// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class GalleryExtendedLocationArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryExtendedLocationArgs WithName(this global::Pulumi.AzureNative.Compute.Inputs.GalleryExtendedLocationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.GalleryExtendedLocationArgs WithType(this global::Pulumi.AzureNative.Compute.Inputs.GalleryExtendedLocationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Compute.GalleryExtendedLocationType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
