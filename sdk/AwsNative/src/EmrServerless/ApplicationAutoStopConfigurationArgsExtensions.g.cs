// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.EmrServerless.Inputs;

namespace Pulumi.AwsNative.EmrServerless;

public static partial class ApplicationAutoStopConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationAutoStopConfigurationArgs WithEnabled(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationAutoStopConfigurationArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationAutoStopConfigurationArgs WithIdleTimeoutMinutes(this global::Pulumi.AwsNative.EmrServerless.Inputs.ApplicationAutoStopConfigurationArgs @selfRef, global::System.Int32 idleTimeoutMinutes)
    {
        @selfRef.IdleTimeoutMinutes = idleTimeoutMinutes;
        return @selfRef;
    }

}
