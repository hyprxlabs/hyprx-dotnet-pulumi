// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class InstanceIpv6AddressArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.InstanceIpv6AddressArgs WithIpv6Address(this global::Pulumi.AwsNative.Ec2.Inputs.InstanceIpv6AddressArgs @selfRef, global::System.String ipv6Address)
    {
        @selfRef.Ipv6Address = ipv6Address;
        return @selfRef;
    }

}
