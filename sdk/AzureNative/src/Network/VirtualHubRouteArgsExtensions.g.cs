// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class VirtualHubRouteArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.VirtualHubRouteArgs WithAddressPrefixes(this global::Pulumi.AzureNative.Network.Inputs.VirtualHubRouteArgs @selfRef, global::System.Collections.Generic.List<global::System.String> addressPrefixes)
    {
        @selfRef.AddressPrefixes = addressPrefixes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualHubRouteArgs WithAddressPrefixes(this global::Pulumi.AzureNative.Network.Inputs.VirtualHubRouteArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AddressPrefixes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualHubRouteArgs WithAddressPrefixes(this global::Pulumi.AzureNative.Network.Inputs.VirtualHubRouteArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AddressPrefixes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualHubRouteArgs WithNextHopIpAddress(this global::Pulumi.AzureNative.Network.Inputs.VirtualHubRouteArgs @selfRef, global::System.String nextHopIpAddress)
    {
        @selfRef.NextHopIpAddress = nextHopIpAddress;
        return @selfRef;
    }

}
