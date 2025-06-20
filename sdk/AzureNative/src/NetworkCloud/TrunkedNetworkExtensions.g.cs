// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.NetworkCloud;

public static partial class TrunkedNetworkExtensions
{

    extension(TrunkedNetwork)
    {
        public static TrunkedNetwork New(string @id, global::Pulumi.AzureNative.NetworkCloud.TrunkedNetworkArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new TrunkedNetwork(@id, @args, @options);
        }

        public static TrunkedNetwork New(string @id, global::System.Action<global::Pulumi.AzureNative.NetworkCloud.TrunkedNetworkArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.NetworkCloud.TrunkedNetworkArgs @args = new();
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

            return new TrunkedNetwork(@id, @args, @options);
        }

    }

}
