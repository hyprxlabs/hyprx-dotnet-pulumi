// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ContainerService;

public static partial class TrustedAccessRoleBindingExtensions
{

    extension(TrustedAccessRoleBinding)
    {
        public static TrustedAccessRoleBinding New(string @id, global::Pulumi.AzureNative.ContainerService.TrustedAccessRoleBindingArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new TrustedAccessRoleBinding(@id, @args, @options);
        }

        public static TrustedAccessRoleBinding New(string @id, global::System.Action<global::Pulumi.AzureNative.ContainerService.TrustedAccessRoleBindingArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ContainerService.TrustedAccessRoleBindingArgs @args = new();
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

            return new TrustedAccessRoleBinding(@id, @args, @options);
        }

    }

}
