// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.StorageCache;

public static partial class CacheExtensions
{

    extension(Cache)
    {
        public static Cache New(string @id, global::Pulumi.AzureNative.StorageCache.CacheArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Cache(@id, @args, @options);
        }

        public static Cache New(string @id, global::System.Action<global::Pulumi.AzureNative.StorageCache.CacheArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.StorageCache.CacheArgs @args = new();
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

            return new Cache(@id, @args, @options);
        }

    }

}
