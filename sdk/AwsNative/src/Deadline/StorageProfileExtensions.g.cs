// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Deadline;

public static partial class StorageProfileExtensions
{

    extension(StorageProfile)
    {
        public static StorageProfile New(string @id, global::Pulumi.AwsNative.Deadline.StorageProfileArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new StorageProfile(@id, @args, @options);
        }

        public static StorageProfile New(string @id, global::System.Action<global::Pulumi.AwsNative.Deadline.StorageProfileArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Deadline.StorageProfileArgs @args = new();
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

            return new StorageProfile(@id, @args, @options);
        }

    }

}
