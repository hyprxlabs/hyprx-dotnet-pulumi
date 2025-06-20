// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Omics;

public static partial class VariantStoreExtensions
{

    extension(VariantStore)
    {
        public static VariantStore New(string @id, global::Pulumi.AwsNative.Omics.VariantStoreArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new VariantStore(@id, @args, @options);
        }

        public static VariantStore New(string @id, global::System.Action<global::Pulumi.AwsNative.Omics.VariantStoreArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Omics.VariantStoreArgs @args = new();
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

            return new VariantStore(@id, @args, @options);
        }

    }

}
