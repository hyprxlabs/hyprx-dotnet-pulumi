// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class InstanceEnaSrdUdpSpecificationArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.InstanceEnaSrdUdpSpecificationArgs WithEnaSrdUdpEnabled(this global::Pulumi.AwsNative.Ec2.Inputs.InstanceEnaSrdUdpSpecificationArgs @selfRef, bool enaSrdUdpEnabled = true)
    {
        @selfRef.EnaSrdUdpEnabled = enaSrdUdpEnabled;
        return @selfRef;
    }

}
