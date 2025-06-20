// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.BotService.Inputs;

namespace Pulumi.AzureNative.BotService;

public static partial class AlexaChannelArgsExtensions
{
    public static global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelArgs WithChannelName(this global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelArgs @selfRef, global::System.String channelName)
    {
        @selfRef.ChannelName = channelName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelArgs WithEtag(this global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelArgs @selfRef, global::System.String etag)
    {
        @selfRef.Etag = etag;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelArgs WithLocation(this global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelArgs WithProperties(this global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelArgs @selfRef, global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelArgs WithProperties(this global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.BotService.Inputs.AlexaChannelPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

}
