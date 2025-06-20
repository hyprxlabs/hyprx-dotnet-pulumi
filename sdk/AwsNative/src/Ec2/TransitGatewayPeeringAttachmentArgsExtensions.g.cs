// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class TransitGatewayPeeringAttachmentArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs WithPeerAccountId(this global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs @selfRef, global::System.String peerAccountId)
    {
        @selfRef.PeerAccountId = peerAccountId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs WithPeerRegion(this global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs @selfRef, global::System.String peerRegion)
    {
        @selfRef.PeerRegion = peerRegion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs WithPeerTransitGatewayId(this global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs @selfRef, global::System.String peerTransitGatewayId)
    {
        @selfRef.PeerTransitGatewayId = peerTransitGatewayId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs WithTags(this global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs WithTags(this global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs WithTags(this global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs WithTransitGatewayId(this global::Pulumi.AwsNative.Ec2.TransitGatewayPeeringAttachmentArgs @selfRef, global::System.String transitGatewayId)
    {
        @selfRef.TransitGatewayId = transitGatewayId;
        return @selfRef;
    }

}
