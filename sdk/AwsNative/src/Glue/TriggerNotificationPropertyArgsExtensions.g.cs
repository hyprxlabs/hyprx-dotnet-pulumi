// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Glue.Inputs;

namespace Pulumi.AwsNative.Glue;

public static partial class TriggerNotificationPropertyArgsExtensions
{
    public static global::Pulumi.AwsNative.Glue.Inputs.TriggerNotificationPropertyArgs WithNotifyDelayAfter(this global::Pulumi.AwsNative.Glue.Inputs.TriggerNotificationPropertyArgs @selfRef, global::System.Int32 notifyDelayAfter)
    {
        @selfRef.NotifyDelayAfter = notifyDelayAfter;
        return @selfRef;
    }

}
