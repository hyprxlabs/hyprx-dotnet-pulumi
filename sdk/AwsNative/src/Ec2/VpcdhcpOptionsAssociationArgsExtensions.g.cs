// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class VpcdhcpOptionsAssociationArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.VpcdhcpOptionsAssociationArgs WithDhcpOptionsId(this global::Pulumi.AwsNative.Ec2.VpcdhcpOptionsAssociationArgs @selfRef, global::System.String dhcpOptionsId)
    {
        @selfRef.DhcpOptionsId = dhcpOptionsId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpcdhcpOptionsAssociationArgs WithVpcId(this global::Pulumi.AwsNative.Ec2.VpcdhcpOptionsAssociationArgs @selfRef, global::System.String vpcId)
    {
        @selfRef.VpcId = vpcId;
        return @selfRef;
    }

}
