// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.ConnectCampaignsV2.Inputs;

namespace Pulumi.AwsNative.ConnectCampaignsV2;

public static partial class CampaignTimeWindowArgsExtensions
{
    public static global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTimeWindowArgs WithOpenHours(this global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTimeWindowArgs @selfRef, global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignOpenHoursArgs openHours)
    {
        @selfRef.OpenHours = openHours;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTimeWindowArgs WithOpenHours(this global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTimeWindowArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignOpenHoursArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignOpenHoursArgs();
        @configure(@item);
        @selfRef.OpenHours = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTimeWindowArgs WithRestrictedPeriods(this global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTimeWindowArgs @selfRef, global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignRestrictedPeriodsArgs restrictedPeriods)
    {
        @selfRef.RestrictedPeriods = restrictedPeriods;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTimeWindowArgs WithRestrictedPeriods(this global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignTimeWindowArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignRestrictedPeriodsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.ConnectCampaignsV2.Inputs.CampaignRestrictedPeriodsArgs();
        @configure(@item);
        @selfRef.RestrictedPeriods = @item;
        return @selfRef;
    }

}
