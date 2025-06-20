// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.NetworkManager;

public static partial class ConnectAttachmentArgsExtensions
{
    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithCoreNetworkId(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::System.String coreNetworkId)
    {
        @selfRef.CoreNetworkId = coreNetworkId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithEdgeLocation(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::System.String edgeLocation)
    {
        @selfRef.EdgeLocation = edgeLocation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithNetworkFunctionGroupName(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::System.String networkFunctionGroupName)
    {
        @selfRef.NetworkFunctionGroupName = networkFunctionGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithOptions(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::Pulumi.AwsNative.NetworkManager.Inputs.ConnectAttachmentOptionsArgs options)
    {
        @selfRef.Options = options;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithOptions(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.NetworkManager.Inputs.ConnectAttachmentOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.NetworkManager.Inputs.ConnectAttachmentOptionsArgs();
        @configure(@item);
        @selfRef.Options = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithProposedNetworkFunctionGroupChange(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::Pulumi.AwsNative.NetworkManager.Inputs.ConnectAttachmentProposedNetworkFunctionGroupChangeArgs proposedNetworkFunctionGroupChange)
    {
        @selfRef.ProposedNetworkFunctionGroupChange = proposedNetworkFunctionGroupChange;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithProposedNetworkFunctionGroupChange(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.NetworkManager.Inputs.ConnectAttachmentProposedNetworkFunctionGroupChangeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.NetworkManager.Inputs.ConnectAttachmentProposedNetworkFunctionGroupChangeArgs();
        @configure(@item);
        @selfRef.ProposedNetworkFunctionGroupChange = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithProposedSegmentChange(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::Pulumi.AwsNative.NetworkManager.Inputs.ConnectAttachmentProposedSegmentChangeArgs proposedSegmentChange)
    {
        @selfRef.ProposedSegmentChange = proposedSegmentChange;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithProposedSegmentChange(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.NetworkManager.Inputs.ConnectAttachmentProposedSegmentChangeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.NetworkManager.Inputs.ConnectAttachmentProposedSegmentChangeArgs();
        @configure(@item);
        @selfRef.ProposedSegmentChange = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithTags(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithTags(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithTags(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs WithTransportAttachmentId(this global::Pulumi.AwsNative.NetworkManager.ConnectAttachmentArgs @selfRef, global::System.String transportAttachmentId)
    {
        @selfRef.TransportAttachmentId = transportAttachmentId;
        return @selfRef;
    }

}
