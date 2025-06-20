// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.OffAzure;

public static partial class PrivateEndpointConnectionControllerExtensions
{

    extension(PrivateEndpointConnectionController)
    {
        public static PrivateEndpointConnectionController New(string @id, global::Pulumi.AzureNative.OffAzure.PrivateEndpointConnectionControllerArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new PrivateEndpointConnectionController(@id, @args, @options);
        }

        public static PrivateEndpointConnectionController New(string @id, global::System.Action<global::Pulumi.AzureNative.OffAzure.PrivateEndpointConnectionControllerArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.OffAzure.PrivateEndpointConnectionControllerArgs @args = new();
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

            return new PrivateEndpointConnectionController(@id, @args, @options);
        }

    }

}
