// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.BotService.Inputs;

namespace Pulumi.AzureNative.BotService;

public static partial class AcsChatChannelArgsExtensions
{
    public static global::Pulumi.AzureNative.BotService.Inputs.AcsChatChannelArgs WithChannelName(this global::Pulumi.AzureNative.BotService.Inputs.AcsChatChannelArgs @selfRef, global::System.String channelName)
    {
        @selfRef.ChannelName = channelName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.AcsChatChannelArgs WithEtag(this global::Pulumi.AzureNative.BotService.Inputs.AcsChatChannelArgs @selfRef, global::System.String etag)
    {
        @selfRef.Etag = etag;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.AcsChatChannelArgs WithLocation(this global::Pulumi.AzureNative.BotService.Inputs.AcsChatChannelArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

}
