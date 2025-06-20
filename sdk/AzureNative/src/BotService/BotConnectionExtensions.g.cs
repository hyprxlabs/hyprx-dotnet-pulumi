// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.BotService;

public static partial class BotConnectionExtensions
{

    extension(BotConnection)
    {
        public static BotConnection New(string @id, global::Pulumi.AzureNative.BotService.BotConnectionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new BotConnection(@id, @args, @options);
        }

        public static BotConnection New(string @id, global::System.Action<global::Pulumi.AzureNative.BotService.BotConnectionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.BotService.BotConnectionArgs @args = new();
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

            return new BotConnection(@id, @args, @options);
        }

    }

}
