// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.MediaLive;

public static partial class EventBridgeRuleTemplateExtensions
{

    extension(EventBridgeRuleTemplate)
    {
        public static EventBridgeRuleTemplate New(string @id, global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new EventBridgeRuleTemplate(@id, @args, @options);
        }

        public static EventBridgeRuleTemplate New(string @id, global::System.Action<global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.MediaLive.EventBridgeRuleTemplateArgs @args = new();
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

            return new EventBridgeRuleTemplate(@id, @args, @options);
        }

    }

}
