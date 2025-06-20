// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.HybridNetwork;

public static partial class SiteNetworkServiceExtensions
{

    extension(SiteNetworkService)
    {
        public static SiteNetworkService New(string @id, global::Pulumi.AzureNative.HybridNetwork.SiteNetworkServiceArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new SiteNetworkService(@id, @args, @options);
        }

        public static SiteNetworkService New(string @id, global::System.Action<global::Pulumi.AzureNative.HybridNetwork.SiteNetworkServiceArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.HybridNetwork.SiteNetworkServiceArgs @args = new();
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

            return new SiteNetworkService(@id, @args, @options);
        }

    }

}
