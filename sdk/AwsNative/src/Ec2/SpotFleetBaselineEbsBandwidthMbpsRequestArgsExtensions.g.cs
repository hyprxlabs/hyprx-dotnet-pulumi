// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class SpotFleetBaselineEbsBandwidthMbpsRequestArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetBaselineEbsBandwidthMbpsRequestArgs WithMax(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetBaselineEbsBandwidthMbpsRequestArgs @selfRef, global::System.Int32 max)
    {
        @selfRef.Max = max;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetBaselineEbsBandwidthMbpsRequestArgs WithMin(this global::Pulumi.AwsNative.Ec2.Inputs.SpotFleetBaselineEbsBandwidthMbpsRequestArgs @selfRef, global::System.Int32 min)
    {
        @selfRef.Min = min;
        return @selfRef;
    }

}
