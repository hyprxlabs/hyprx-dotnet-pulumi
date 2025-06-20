// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.BotService.Inputs;

namespace Pulumi.AzureNative.BotService;

public static partial class DirectLineSpeechChannelArgsExtensions
{
    public static global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelArgs WithChannelName(this global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelArgs @selfRef, global::System.String channelName)
    {
        @selfRef.ChannelName = channelName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelArgs WithEtag(this global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelArgs @selfRef, global::System.String etag)
    {
        @selfRef.Etag = etag;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelArgs WithLocation(this global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelArgs WithProperties(this global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelArgs @selfRef, global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelArgs WithProperties(this global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.BotService.Inputs.DirectLineSpeechChannelPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

}
