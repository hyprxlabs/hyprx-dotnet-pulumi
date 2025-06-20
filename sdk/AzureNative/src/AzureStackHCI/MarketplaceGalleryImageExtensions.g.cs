// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AzureStackHCI;

public static partial class MarketplaceGalleryImageExtensions
{

    extension(MarketplaceGalleryImage)
    {
        public static MarketplaceGalleryImage New(string @id, global::Pulumi.AzureNative.AzureStackHCI.MarketplaceGalleryImageArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new MarketplaceGalleryImage(@id, @args, @options);
        }

        public static MarketplaceGalleryImage New(string @id, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.MarketplaceGalleryImageArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.AzureStackHCI.MarketplaceGalleryImageArgs @args = new();
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

            return new MarketplaceGalleryImage(@id, @args, @options);
        }

    }

}
