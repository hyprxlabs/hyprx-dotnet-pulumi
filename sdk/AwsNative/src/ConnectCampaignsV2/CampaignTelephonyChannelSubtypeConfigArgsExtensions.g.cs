// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ConnectCampaignsV2.Inputs;

namespace Pulumi.AwsNative.ConnectCampaignsV2;

public static partial class CampaignTelephonyChannelSubtypeConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyChannelSubtypeConfigArgs WithCapacity(this global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyChannelSubtypeConfigArgs @selfRef, global::System.Double capacity)
    {
        @selfRef.Capacity = capacity;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyChannelSubtypeConfigArgs WithConnectQueueId(this global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyChannelSubtypeConfigArgs @selfRef, global::System.String connectQueueId)
    {
        @selfRef.ConnectQueueId = connectQueueId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyChannelSubtypeConfigArgs WithDefaultOutboundConfig(this global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyChannelSubtypeConfigArgs @selfRef, global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyOutboundConfigArgs defaultOutboundConfig)
    {
        @selfRef.DefaultOutboundConfig = defaultOutboundConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyChannelSubtypeConfigArgs WithDefaultOutboundConfig(this global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyChannelSubtypeConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyOutboundConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyOutboundConfigArgs();
        @configure(@item);
        @selfRef.DefaultOutboundConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyChannelSubtypeConfigArgs WithOutboundMode(this global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyChannelSubtypeConfigArgs @selfRef, global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyOutboundModeArgs outboundMode)
    {
        @selfRef.OutboundMode = outboundMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyChannelSubtypeConfigArgs WithOutboundMode(this global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyChannelSubtypeConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyOutboundModeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTelephonyOutboundModeArgs();
        @configure(@item);
        @selfRef.OutboundMode = @item;
        return @selfRef;
    }

}
