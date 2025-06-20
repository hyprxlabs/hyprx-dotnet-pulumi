// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.NetworkManager;

public static partial class CoreNetworkExtensions
{

    extension(CoreNetwork)
    {
        public static CoreNetwork New(string @id, global::Pulumi.AwsNative.NetworkManager.CoreNetworkArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new CoreNetwork(@id, @args, @options);
        }

        public static CoreNetwork New(string @id, global::System.Action<global::Pulumi.AwsNative.NetworkManager.CoreNetworkArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.NetworkManager.CoreNetworkArgs @args = new();
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

            return new CoreNetwork(@id, @args, @options);
        }

    }

}
