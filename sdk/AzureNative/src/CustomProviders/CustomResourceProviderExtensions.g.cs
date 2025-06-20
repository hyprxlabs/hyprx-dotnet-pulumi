// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.CustomProviders;

public static partial class CustomResourceProviderExtensions
{

    extension(CustomResourceProvider)
    {
        public static CustomResourceProvider New(string @id, global::Pulumi.AzureNative.CustomProviders.CustomResourceProviderArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new CustomResourceProvider(@id, @args, @options);
        }

        public static CustomResourceProvider New(string @id, global::System.Action<global::Pulumi.AzureNative.CustomProviders.CustomResourceProviderArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.CustomProviders.CustomResourceProviderArgs @args = new();
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

            return new CustomResourceProvider(@id, @args, @options);
        }

    }

}
