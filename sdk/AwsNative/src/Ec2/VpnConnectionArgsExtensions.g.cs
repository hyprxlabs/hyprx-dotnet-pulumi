// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class VpnConnectionArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithCustomerGatewayId(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.String customerGatewayId)
    {
        @selfRef.CustomerGatewayId = customerGatewayId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithEnableAcceleration(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, bool enableAcceleration = true)
    {
        @selfRef.EnableAcceleration = enableAcceleration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithLocalIpv4NetworkCidr(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.String localIpv4NetworkCidr)
    {
        @selfRef.LocalIpv4NetworkCidr = localIpv4NetworkCidr;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithLocalIpv6NetworkCidr(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.String localIpv6NetworkCidr)
    {
        @selfRef.LocalIpv6NetworkCidr = localIpv6NetworkCidr;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithOutsideIpAddressType(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.String outsideIpAddressType)
    {
        @selfRef.OutsideIpAddressType = outsideIpAddressType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithRemoteIpv4NetworkCidr(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.String remoteIpv4NetworkCidr)
    {
        @selfRef.RemoteIpv4NetworkCidr = remoteIpv4NetworkCidr;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithRemoteIpv6NetworkCidr(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.String remoteIpv6NetworkCidr)
    {
        @selfRef.RemoteIpv6NetworkCidr = remoteIpv6NetworkCidr;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithStaticRoutesOnly(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, bool staticRoutesOnly = true)
    {
        @selfRef.StaticRoutesOnly = staticRoutesOnly;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithTags(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithTags(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithTags(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithTransitGatewayId(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.String transitGatewayId)
    {
        @selfRef.TransitGatewayId = transitGatewayId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithTransportTransitGatewayAttachmentId(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.String transportTransitGatewayAttachmentId)
    {
        @selfRef.TransportTransitGatewayAttachmentId = transportTransitGatewayAttachmentId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithTunnelInsideIpVersion(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.String tunnelInsideIpVersion)
    {
        @selfRef.TunnelInsideIpVersion = tunnelInsideIpVersion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithType(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithVpnGatewayId(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.String vpnGatewayId)
    {
        @selfRef.VpnGatewayId = vpnGatewayId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithVpnTunnelOptionsSpecifications(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.VpnConnectionVpnTunnelOptionsSpecificationArgs> vpnTunnelOptionsSpecifications)
    {
        @selfRef.VpnTunnelOptionsSpecifications = vpnTunnelOptionsSpecifications;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithVpnTunnelOptionsSpecifications(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.VpnConnectionVpnTunnelOptionsSpecificationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ec2.Inputs.VpnConnectionVpnTunnelOptionsSpecificationArgs>();
        @configure(@list);
        @selfRef.VpnTunnelOptionsSpecifications = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpnConnectionArgs WithVpnTunnelOptionsSpecifications(this global::Pulumi.AwsNative.Ec2.VpnConnectionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ec2.Inputs.VpnConnectionVpnTunnelOptionsSpecificationArgs>> @create)
    {
        @selfRef.VpnTunnelOptionsSpecifications = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
