// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AutoScaling.Inputs;

namespace Pulumi.AwsNative.AutoScaling;

public static partial class AutoScalingGroupPerformanceFactorReferenceRequestArgsExtensions
{
    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupPerformanceFactorReferenceRequestArgs WithInstanceFamily(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupPerformanceFactorReferenceRequestArgs @selfRef, global::System.String instanceFamily)
    {
        @selfRef.InstanceFamily = instanceFamily;
        return @selfRef;
    }

}
