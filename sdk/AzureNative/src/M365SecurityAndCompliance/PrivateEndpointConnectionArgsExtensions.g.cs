// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.M365SecurityAndCompliance.Inputs;

namespace Pulumi.AzureNative.M365SecurityAndCompliance;

public static partial class PrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.M365SecurityAndCompliance.Inputs.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.M365SecurityAndCompliance.Inputs.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.M365SecurityAndCompliance.Inputs.PrivateLinkServiceConnectionStateArgs privateLinkServiceConnectionState)
    {
        @selfRef.PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.M365SecurityAndCompliance.Inputs.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.M365SecurityAndCompliance.Inputs.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.M365SecurityAndCompliance.Inputs.PrivateLinkServiceConnectionStateArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.M365SecurityAndCompliance.Inputs.PrivateLinkServiceConnectionStateArgs();
        @configure(@item);
        @selfRef.PrivateLinkServiceConnectionState = @item;
        return @selfRef;
    }

}
