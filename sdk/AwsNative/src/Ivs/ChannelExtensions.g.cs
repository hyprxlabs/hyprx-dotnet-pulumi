// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ivs;

public static partial class ChannelExtensions
{

    extension(Channel)
    {
        public static Channel New(string @id, global::Pulumi.AwsNative.Ivs.ChannelArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Channel(@id, @args, @options);
        }

        public static Channel New(string @id, global::System.Action<global::Pulumi.AwsNative.Ivs.ChannelArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ivs.ChannelArgs @args = new();
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

            return new Channel(@id, @args, @options);
        }

    }

}
