// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DataShare;

public static partial class BlobDataSetMappingExtensions
{

    extension(BlobDataSetMapping)
    {
        public static BlobDataSetMapping New(string @id, global::Pulumi.AzureNative.DataShare.BlobDataSetMappingArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new BlobDataSetMapping(@id, @args, @options);
        }

        public static BlobDataSetMapping New(string @id, global::System.Action<global::Pulumi.AzureNative.DataShare.BlobDataSetMappingArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.DataShare.BlobDataSetMappingArgs @args = new();
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

            return new BlobDataSetMapping(@id, @args, @options);
        }

    }

}
