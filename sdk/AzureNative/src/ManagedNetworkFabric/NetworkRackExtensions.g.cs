// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ManagedNetworkFabric;

public static partial class NetworkRackExtensions
{

    extension(NetworkRack)
    {
        public static NetworkRack New(string @id, global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkRackArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new NetworkRack(@id, @args, @options);
        }

        public static NetworkRack New(string @id, global::System.Action<global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkRackArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ManagedNetworkFabric.NetworkRackArgs @args = new();
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

            return new NetworkRack(@id, @args, @options);
        }

    }

}
