// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SsmContacts.Inputs;

namespace Pulumi.AwsNative.SsmContacts;

public static partial class PlanChannelTargetInfoArgsExtensions
{
    public static global::Pulumi.AwsNative.SsmContacts.Inputs.PlanChannelTargetInfoArgs WithChannelId(this global::Pulumi.AwsNative.SsmContacts.Inputs.PlanChannelTargetInfoArgs @selfRef, global::System.String channelId)
    {
        @selfRef.ChannelId = channelId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SsmContacts.Inputs.PlanChannelTargetInfoArgs WithRetryIntervalInMinutes(this global::Pulumi.AwsNative.SsmContacts.Inputs.PlanChannelTargetInfoArgs @selfRef, global::System.Int32 retryIntervalInMinutes)
    {
        @selfRef.RetryIntervalInMinutes = retryIntervalInMinutes;
        return @selfRef;
    }

}
