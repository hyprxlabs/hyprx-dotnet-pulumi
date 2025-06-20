// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ContainerRegistry;

public static partial class CacheRuleExtensions
{

    extension(CacheRule)
    {
        public static CacheRule New(string @id, global::Pulumi.AzureNative.ContainerRegistry.CacheRuleArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new CacheRule(@id, @args, @options);
        }

        public static CacheRule New(string @id, global::System.Action<global::Pulumi.AzureNative.ContainerRegistry.CacheRuleArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ContainerRegistry.CacheRuleArgs @args = new();
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

            return new CacheRule(@id, @args, @options);
        }

    }

}
