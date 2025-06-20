// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.BotService.Inputs;

namespace Pulumi.AzureNative.BotService;

public static partial class SkypeChannelPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs WithCallingWebHook(this global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs @selfRef, global::System.String callingWebHook)
    {
        @selfRef.CallingWebHook = callingWebHook;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs WithEnableCalling(this global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs @selfRef, bool enableCalling = true)
    {
        @selfRef.EnableCalling = enableCalling;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs WithEnableGroups(this global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs @selfRef, bool enableGroups = true)
    {
        @selfRef.EnableGroups = enableGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs WithEnableMediaCards(this global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs @selfRef, bool enableMediaCards = true)
    {
        @selfRef.EnableMediaCards = enableMediaCards;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs WithEnableMessaging(this global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs @selfRef, bool enableMessaging = true)
    {
        @selfRef.EnableMessaging = enableMessaging;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs WithEnableScreenSharing(this global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs @selfRef, bool enableScreenSharing = true)
    {
        @selfRef.EnableScreenSharing = enableScreenSharing;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs WithEnableVideo(this global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs @selfRef, bool enableVideo = true)
    {
        @selfRef.EnableVideo = enableVideo;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs WithGroupsMode(this global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs @selfRef, global::System.String groupsMode)
    {
        @selfRef.GroupsMode = groupsMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs WithIncomingCallRoute(this global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs @selfRef, global::System.String incomingCallRoute)
    {
        @selfRef.IncomingCallRoute = incomingCallRoute;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs WithIsEnabled(this global::Pulumi.AzureNative.BotService.Inputs.SkypeChannelPropertiesArgs @selfRef, bool isEnabled = true)
    {
        @selfRef.IsEnabled = isEnabled;
        return @selfRef;
    }

}
