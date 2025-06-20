// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Chatbot;

public static partial class SlackChannelConfigurationExtensions
{

    extension(SlackChannelConfiguration)
    {
        public static SlackChannelConfiguration New(string @id, global::Pulumi.AwsNative.Chatbot.SlackChannelConfigurationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new SlackChannelConfiguration(@id, @args, @options);
        }

        public static SlackChannelConfiguration New(string @id, global::System.Action<global::Pulumi.AwsNative.Chatbot.SlackChannelConfigurationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Chatbot.SlackChannelConfigurationArgs @args = new();
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

            return new SlackChannelConfiguration(@id, @args, @options);
        }

    }

}
