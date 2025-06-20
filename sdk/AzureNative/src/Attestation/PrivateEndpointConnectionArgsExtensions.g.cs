// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Attestation;

public static partial class PrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.Attestation.PrivateEndpointConnectionArgs WithPrivateEndpointConnectionName(this global::Pulumi.AzureNative.Attestation.PrivateEndpointConnectionArgs @selfRef, global::System.String privateEndpointConnectionName)
    {
        @selfRef.PrivateEndpointConnectionName = privateEndpointConnectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Attestation.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.Attestation.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.Attestation.Inputs.PrivateLinkServiceConnectionStateArgs privateLinkServiceConnectionState)
    {
        @selfRef.PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Attestation.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.Attestation.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Attestation.Inputs.PrivateLinkServiceConnectionStateArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Attestation.Inputs.PrivateLinkServiceConnectionStateArgs();
        @configure(@item);
        @selfRef.PrivateLinkServiceConnectionState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Attestation.PrivateEndpointConnectionArgs WithProviderName(this global::Pulumi.AzureNative.Attestation.PrivateEndpointConnectionArgs @selfRef, global::System.String providerName)
    {
        @selfRef.ProviderName = providerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Attestation.PrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.Attestation.PrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
