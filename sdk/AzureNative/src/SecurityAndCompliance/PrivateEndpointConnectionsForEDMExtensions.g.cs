// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SecurityAndCompliance;

public static partial class PrivateEndpointConnectionsForEDMExtensions
{

    extension(PrivateEndpointConnectionsForEDM)
    {
        public static PrivateEndpointConnectionsForEDM New(string @id, global::Pulumi.AzureNative.SecurityAndCompliance.PrivateEndpointConnectionsForEDMArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new PrivateEndpointConnectionsForEDM(@id, @args, @options);
        }

        public static PrivateEndpointConnectionsForEDM New(string @id, global::System.Action<global::Pulumi.AzureNative.SecurityAndCompliance.PrivateEndpointConnectionsForEDMArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.SecurityAndCompliance.PrivateEndpointConnectionsForEDMArgs @args = new();
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

            return new PrivateEndpointConnectionsForEDM(@id, @args, @options);
        }

    }

}
