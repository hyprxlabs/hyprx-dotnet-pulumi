// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Confluent;

public static partial class TopicExtensions
{

    extension(Topic)
    {
        public static Topic New(string @id, global::Pulumi.AzureNative.Confluent.TopicArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Topic(@id, @args, @options);
        }

        public static Topic New(string @id, global::System.Action<global::Pulumi.AzureNative.Confluent.TopicArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Confluent.TopicArgs @args = new();
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

            return new Topic(@id, @args, @options);
        }

    }

}
