// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SignalRService;

public static partial class SignalRPrivateEndpointConnectionExtensions
{

    extension(SignalRPrivateEndpointConnection)
    {
        public static SignalRPrivateEndpointConnection New(string @id, global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new SignalRPrivateEndpointConnection(@id, @args, @options);
        }

        public static SignalRPrivateEndpointConnection New(string @id, global::System.Action<global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs @args = new();
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

            return new SignalRPrivateEndpointConnection(@id, @args, @options);
        }

    }

}
