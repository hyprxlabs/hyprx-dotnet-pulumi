// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.MediaPackageV2;

public static partial class ChannelGroupExtensions
{

    extension(ChannelGroup)
    {
        public static ChannelGroup New(string @id, global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ChannelGroup(@id, @args, @options);
        }

        public static ChannelGroup New(string @id, global::System.Action<global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.MediaPackageV2.ChannelGroupArgs @args = new();
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

            return new ChannelGroup(@id, @args, @options);
        }

    }

}
