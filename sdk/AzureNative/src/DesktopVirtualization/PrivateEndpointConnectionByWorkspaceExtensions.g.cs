// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DesktopVirtualization;

public static partial class PrivateEndpointConnectionByWorkspaceExtensions
{

    extension(PrivateEndpointConnectionByWorkspace)
    {
        public static PrivateEndpointConnectionByWorkspace New(string @id, global::Pulumi.AzureNative.DesktopVirtualization.PrivateEndpointConnectionByWorkspaceArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new PrivateEndpointConnectionByWorkspace(@id, @args, @options);
        }

        public static PrivateEndpointConnectionByWorkspace New(string @id, global::System.Action<global::Pulumi.AzureNative.DesktopVirtualization.PrivateEndpointConnectionByWorkspaceArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.DesktopVirtualization.PrivateEndpointConnectionByWorkspaceArgs @args = new();
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

            return new PrivateEndpointConnectionByWorkspace(@id, @args, @options);
        }

    }

}
