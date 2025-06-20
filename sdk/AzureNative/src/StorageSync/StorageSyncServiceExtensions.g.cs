// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.StorageSync;

public static partial class StorageSyncServiceExtensions
{

    extension(StorageSyncService)
    {
        public static StorageSyncService New(string @id, global::Pulumi.AzureNative.StorageSync.StorageSyncServiceArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new StorageSyncService(@id, @args, @options);
        }

        public static StorageSyncService New(string @id, global::System.Action<global::Pulumi.AzureNative.StorageSync.StorageSyncServiceArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.StorageSync.StorageSyncServiceArgs @args = new();
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

            return new StorageSyncService(@id, @args, @options);
        }

    }

}
