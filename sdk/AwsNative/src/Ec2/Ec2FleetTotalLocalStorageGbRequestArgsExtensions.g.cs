// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class Ec2FleetTotalLocalStorageGbRequestArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTotalLocalStorageGbRequestArgs WithMax(this global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTotalLocalStorageGbRequestArgs @selfRef, global::System.Double max)
    {
        @selfRef.Max = max;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTotalLocalStorageGbRequestArgs WithMin(this global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetTotalLocalStorageGbRequestArgs @selfRef, global::System.Double min)
    {
        @selfRef.Min = min;
        return @selfRef;
    }

}
