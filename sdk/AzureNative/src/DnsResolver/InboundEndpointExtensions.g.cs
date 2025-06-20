// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DnsResolver;

public static partial class InboundEndpointExtensions
{

    extension(InboundEndpoint)
    {
        public static InboundEndpoint New(string @id, global::Pulumi.AzureNative.DnsResolver.InboundEndpointArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new InboundEndpoint(@id, @args, @options);
        }

        public static InboundEndpoint New(string @id, global::System.Action<global::Pulumi.AzureNative.DnsResolver.InboundEndpointArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.DnsResolver.InboundEndpointArgs @args = new();
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

            return new InboundEndpoint(@id, @args, @options);
        }

    }

}
