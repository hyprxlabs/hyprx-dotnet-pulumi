// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ContainerInstance;

public static partial class ContainerGroupExtensions
{

    extension(ContainerGroup)
    {
        public static ContainerGroup New(string @id, global::Pulumi.AzureNative.ContainerInstance.ContainerGroupArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ContainerGroup(@id, @args, @options);
        }

        public static ContainerGroup New(string @id, global::System.Action<global::Pulumi.AzureNative.ContainerInstance.ContainerGroupArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ContainerInstance.ContainerGroupArgs @args = new();
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

            return new ContainerGroup(@id, @args, @options);
        }

    }

}
