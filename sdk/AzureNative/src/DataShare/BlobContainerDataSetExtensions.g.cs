// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DataShare;

public static partial class BlobContainerDataSetExtensions
{

    extension(BlobContainerDataSet)
    {
        public static BlobContainerDataSet New(string @id, global::Pulumi.AzureNative.DataShare.BlobContainerDataSetArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new BlobContainerDataSet(@id, @args, @options);
        }

        public static BlobContainerDataSet New(string @id, global::System.Action<global::Pulumi.AzureNative.DataShare.BlobContainerDataSetArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.DataShare.BlobContainerDataSetArgs @args = new();
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

            return new BlobContainerDataSet(@id, @args, @options);
        }

    }

}
