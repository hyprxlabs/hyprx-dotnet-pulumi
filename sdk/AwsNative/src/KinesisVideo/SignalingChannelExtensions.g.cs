// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.KinesisVideo;

public static partial class SignalingChannelExtensions
{

    extension(SignalingChannel)
    {
        public static SignalingChannel New(string @id, global::Pulumi.AwsNative.KinesisVideo.SignalingChannelArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new SignalingChannel(@id, @args, @options);
        }

        public static SignalingChannel New(string @id, global::System.Action<global::Pulumi.AwsNative.KinesisVideo.SignalingChannelArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.KinesisVideo.SignalingChannelArgs @args = new();
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

            return new SignalingChannel(@id, @args, @options);
        }

    }

}
