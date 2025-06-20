// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Compute;

public static partial class GalleryInVMAccessControlProfileExtensions
{

    extension(GalleryInVMAccessControlProfile)
    {
        public static GalleryInVMAccessControlProfile New(string @id, global::Pulumi.AzureNative.Compute.GalleryInVMAccessControlProfileArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new GalleryInVMAccessControlProfile(@id, @args, @options);
        }

        public static GalleryInVMAccessControlProfile New(string @id, global::System.Action<global::Pulumi.AzureNative.Compute.GalleryInVMAccessControlProfileArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Compute.GalleryInVMAccessControlProfileArgs @args = new();
            global::Pulumi.CustomResourceOptions? @options = null;
            if (@configureArgs is not null)
            {
                @configureArgs(@args);
            }

            if (@configureOptions is not null)
            {
                @options = new();
                @configureOptions(@options);
            }

            return new GalleryInVMAccessControlProfile(@id, @args, @options);
        }

    }

}
