// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.NimbleStudio;

public static partial class StreamingImageExtensions
{

    extension(StreamingImage)
    {
        public static StreamingImage New(string @id, global::Pulumi.AwsNative.NimbleStudio.StreamingImageArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new StreamingImage(@id, @args, @options);
        }

        public static StreamingImage New(string @id, global::System.Action<global::Pulumi.AwsNative.NimbleStudio.StreamingImageArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.NimbleStudio.StreamingImageArgs @args = new();
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

            return new StreamingImage(@id, @args, @options);
        }

    }

}
