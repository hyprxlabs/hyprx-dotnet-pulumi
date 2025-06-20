// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class VpcPeeringConnectionArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs WithPeerOwnerId(this global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs @selfRef, global::System.String peerOwnerId)
    {
        @selfRef.PeerOwnerId = peerOwnerId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs WithPeerRegion(this global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs @selfRef, global::System.String peerRegion)
    {
        @selfRef.PeerRegion = peerRegion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs WithPeerRoleArn(this global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs @selfRef, global::System.String peerRoleArn)
    {
        @selfRef.PeerRoleArn = peerRoleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs WithPeerVpcId(this global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs @selfRef, global::System.String peerVpcId)
    {
        @selfRef.PeerVpcId = peerVpcId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs WithTags(this global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs WithTags(this global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs WithTags(this global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs WithVpcId(this global::Pulumi.AwsNative.Ec2.VpcPeeringConnectionArgs @selfRef, global::System.String vpcId)
    {
        @selfRef.VpcId = vpcId;
        return @selfRef;
    }

}
