// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.HybridNetwork;

public static partial class VendorSkusExtensions
{

    extension(VendorSkus)
    {
        public static VendorSkus New(string @id, global::Pulumi.AzureNative.HybridNetwork.VendorSkusArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new VendorSkus(@id, @args, @options);
        }

        public static VendorSkus New(string @id, global::System.Action<global::Pulumi.AzureNative.HybridNetwork.VendorSkusArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.HybridNetwork.VendorSkusArgs @args = new();
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

            return new VendorSkus(@id, @args, @options);
        }

    }

}
