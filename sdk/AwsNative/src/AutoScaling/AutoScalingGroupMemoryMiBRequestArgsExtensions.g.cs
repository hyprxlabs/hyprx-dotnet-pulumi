// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AutoScaling.Inputs;

namespace Pulumi.AwsNative.AutoScaling;

public static partial class AutoScalingGroupMemoryMiBRequestArgsExtensions
{
    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupMemoryMiBRequestArgs WithMax(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupMemoryMiBRequestArgs @selfRef, global::System.Int32 max)
    {
        @selfRef.Max = max;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupMemoryMiBRequestArgs WithMin(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupMemoryMiBRequestArgs @selfRef, global::System.Int32 min)
    {
        @selfRef.Min = min;
        return @selfRef;
    }

}
