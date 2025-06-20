// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ProviderHub;

public static partial class DefaultRolloutExtensions
{

    extension(DefaultRollout)
    {
        public static DefaultRollout New(string @id, global::Pulumi.AzureNative.ProviderHub.DefaultRolloutArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new DefaultRollout(@id, @args, @options);
        }

        public static DefaultRollout New(string @id, global::System.Action<global::Pulumi.AzureNative.ProviderHub.DefaultRolloutArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ProviderHub.DefaultRolloutArgs @args = new();
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

            return new DefaultRollout(@id, @args, @options);
        }

    }

}
