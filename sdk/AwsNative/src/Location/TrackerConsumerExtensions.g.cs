// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Location;

public static partial class TrackerConsumerExtensions
{

    extension(TrackerConsumer)
    {
        public static TrackerConsumer New(string @id, global::Pulumi.AwsNative.Location.TrackerConsumerArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new TrackerConsumer(@id, @args, @options);
        }

        public static TrackerConsumer New(string @id, global::System.Action<global::Pulumi.AwsNative.Location.TrackerConsumerArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Location.TrackerConsumerArgs @args = new();
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

            return new TrackerConsumer(@id, @args, @options);
        }

    }

}
