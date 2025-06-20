// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Peering.Inputs;

namespace Pulumi.AzureNative.Peering;

public static partial class PeeringPropertiesDirectArgsExtensions
{
    public static global::Pulumi.AzureNative.Peering.Inputs.PeeringPropertiesDirectArgs WithConnections(this global::Pulumi.AzureNative.Peering.Inputs.PeeringPropertiesDirectArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Peering.Inputs.DirectConnectionArgs> connections)
    {
        @selfRef.Connections = connections;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.PeeringPropertiesDirectArgs WithConnections(this global::Pulumi.AzureNative.Peering.Inputs.PeeringPropertiesDirectArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Peering.Inputs.DirectConnectionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Peering.Inputs.DirectConnectionArgs>();
        @configure(@list);
        @selfRef.Connections = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.PeeringPropertiesDirectArgs WithConnections(this global::Pulumi.AzureNative.Peering.Inputs.PeeringPropertiesDirectArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Peering.Inputs.DirectConnectionArgs>> @create)
    {
        @selfRef.Connections = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.PeeringPropertiesDirectArgs WithDirectPeeringType(this global::Pulumi.AzureNative.Peering.Inputs.PeeringPropertiesDirectArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Peering.DirectPeeringType> directPeeringType)
    {
        @selfRef.DirectPeeringType = directPeeringType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.PeeringPropertiesDirectArgs WithPeerAsn(this global::Pulumi.AzureNative.Peering.Inputs.PeeringPropertiesDirectArgs @selfRef, global::Pulumi.AzureNative.Peering.Inputs.SubResourceArgs peerAsn)
    {
        @selfRef.PeerAsn = peerAsn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Peering.Inputs.PeeringPropertiesDirectArgs WithPeerAsn(this global::Pulumi.AzureNative.Peering.Inputs.PeeringPropertiesDirectArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Peering.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Peering.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.PeerAsn = @item;
        return @selfRef;
    }

}
