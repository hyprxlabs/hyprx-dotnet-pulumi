// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.ApplicationSignals;

public static partial class DiscoveryExtensions
{

    extension(Discovery)
    {
        public static Discovery New(string @id, global::Pulumi.AwsNative.ApplicationSignals.DiscoveryArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Discovery(@id, @args, @options);
        }

        public static Discovery New(string @id, global::System.Action<global::Pulumi.AwsNative.ApplicationSignals.DiscoveryArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.ApplicationSignals.DiscoveryArgs @args = new();
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

            return new Discovery(@id, @args, @options);
        }

    }

}
