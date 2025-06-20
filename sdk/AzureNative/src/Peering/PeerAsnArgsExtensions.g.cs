// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Peering;

public static partial class PeerAsnArgsExtensions
{
    public static global::Pulumi.AzureNative.Peering.PeerAsnArgs WithPeerAsn(this global::Pulumi.AzureNative.Peering.PeerAsnArgs @selfRef, global::System.Int32 peerAsn)
    {
        @selfRef.PeerAsn = peerAsn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.PeerAsnArgs WithPeerAsnName(this global::Pulumi.AzureNative.Peering.PeerAsnArgs @selfRef, global::System.String peerAsnName)
    {
        @selfRef.PeerAsnName = peerAsnName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.PeerAsnArgs WithPeerContactDetail(this global::Pulumi.AzureNative.Peering.PeerAsnArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Peering.Inputs.ContactDetailArgs> peerContactDetail)
    {
        @selfRef.PeerContactDetail = peerContactDetail;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.PeerAsnArgs WithPeerContactDetail(this global::Pulumi.AzureNative.Peering.PeerAsnArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Peering.Inputs.ContactDetailArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Peering.Inputs.ContactDetailArgs>();
        @configure(@list);
        @selfRef.PeerContactDetail = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.PeerAsnArgs WithPeerContactDetail(this global::Pulumi.AzureNative.Peering.PeerAsnArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Peering.Inputs.ContactDetailArgs>> @create)
    {
        @selfRef.PeerContactDetail = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.PeerAsnArgs WithPeerName(this global::Pulumi.AzureNative.Peering.PeerAsnArgs @selfRef, global::System.String peerName)
    {
        @selfRef.PeerName = peerName;
        return @selfRef;
    }

}
