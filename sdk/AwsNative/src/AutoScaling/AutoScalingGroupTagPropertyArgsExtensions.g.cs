// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AutoScaling.Inputs;

namespace Pulumi.AwsNative.AutoScaling;

public static partial class AutoScalingGroupTagPropertyArgsExtensions
{
    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupTagPropertyArgs WithKey(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupTagPropertyArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupTagPropertyArgs WithPropagateAtLaunch(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupTagPropertyArgs @selfRef, bool propagateAtLaunch = true)
    {
        @selfRef.PropagateAtLaunch = propagateAtLaunch;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupTagPropertyArgs WithValue(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupTagPropertyArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
