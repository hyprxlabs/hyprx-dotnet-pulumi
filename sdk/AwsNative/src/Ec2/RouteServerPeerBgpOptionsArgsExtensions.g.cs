// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class RouteServerPeerBgpOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.RouteServerPeerBgpOptionsArgs WithPeerAsn(this global::Pulumi.AwsNative.Ec2.Inputs.RouteServerPeerBgpOptionsArgs @selfRef, global::System.Int32 peerAsn)
    {
        @selfRef.PeerAsn = peerAsn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.RouteServerPeerBgpOptionsArgs WithPeerLivenessDetection(this global::Pulumi.AwsNative.Ec2.Inputs.RouteServerPeerBgpOptionsArgs @selfRef, global::Pulumi.AwsNative.Ec2.RouteServerPeerBgpOptionsPeerLivenessDetection peerLivenessDetection)
    {
        @selfRef.PeerLivenessDetection = peerLivenessDetection;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.RouteServerPeerBgpOptionsArgs WithPeerLivenessDetection(this global::Pulumi.AwsNative.Ec2.Inputs.RouteServerPeerBgpOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.RouteServerPeerBgpOptionsPeerLivenessDetection> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Ec2.RouteServerPeerBgpOptionsPeerLivenessDetection>();
        @configure(@item);
        @selfRef.PeerLivenessDetection = @item;
        return @selfRef;
    }

}
