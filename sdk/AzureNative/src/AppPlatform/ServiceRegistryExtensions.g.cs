// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AppPlatform;

public static partial class ServiceRegistryExtensions
{

    extension(ServiceRegistry)
    {
        public static ServiceRegistry New(string @id, global::Pulumi.AzureNative.AppPlatform.ServiceRegistryArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ServiceRegistry(@id, @args, @options);
        }

        public static ServiceRegistry New(string @id, global::System.Action<global::Pulumi.AzureNative.AppPlatform.ServiceRegistryArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.AppPlatform.ServiceRegistryArgs @args = new();
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

            return new ServiceRegistry(@id, @args, @options);
        }

    }

}
