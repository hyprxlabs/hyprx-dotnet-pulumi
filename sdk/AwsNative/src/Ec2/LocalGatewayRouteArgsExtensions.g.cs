// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class LocalGatewayRouteArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.LocalGatewayRouteArgs WithDestinationCidrBlock(this global::Pulumi.AwsNative.Ec2.LocalGatewayRouteArgs @selfRef, global::System.String destinationCidrBlock)
    {
        @selfRef.DestinationCidrBlock = destinationCidrBlock;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.LocalGatewayRouteArgs WithLocalGatewayRouteTableId(this global::Pulumi.AwsNative.Ec2.LocalGatewayRouteArgs @selfRef, global::System.String localGatewayRouteTableId)
    {
        @selfRef.LocalGatewayRouteTableId = localGatewayRouteTableId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.LocalGatewayRouteArgs WithLocalGatewayVirtualInterfaceGroupId(this global::Pulumi.AwsNative.Ec2.LocalGatewayRouteArgs @selfRef, global::System.String localGatewayVirtualInterfaceGroupId)
    {
        @selfRef.LocalGatewayVirtualInterfaceGroupId = localGatewayVirtualInterfaceGroupId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.LocalGatewayRouteArgs WithNetworkInterfaceId(this global::Pulumi.AwsNative.Ec2.LocalGatewayRouteArgs @selfRef, global::System.String networkInterfaceId)
    {
        @selfRef.NetworkInterfaceId = networkInterfaceId;
        return @selfRef;
    }

}
