// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.NetworkCloud;

public static partial class CloudServicesNetworkExtensions
{

    extension(CloudServicesNetwork)
    {
        public static CloudServicesNetwork New(string @id, global::Pulumi.AzureNative.NetworkCloud.CloudServicesNetworkArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new CloudServicesNetwork(@id, @args, @options);
        }

        public static CloudServicesNetwork New(string @id, global::System.Action<global::Pulumi.AzureNative.NetworkCloud.CloudServicesNetworkArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.NetworkCloud.CloudServicesNetworkArgs @args = new();
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

            return new CloudServicesNetwork(@id, @args, @options);
        }

    }

}
