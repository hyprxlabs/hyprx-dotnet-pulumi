// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.IoTCentral;

public static partial class PrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTCentral.PrivateEndpointConnectionArgs WithPrivateEndpointConnectionName(this global::Pulumi.AzureNative.IoTCentral.PrivateEndpointConnectionArgs @selfRef, global::System.String privateEndpointConnectionName)
    {
        @selfRef.PrivateEndpointConnectionName = privateEndpointConnectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTCentral.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.IoTCentral.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.IoTCentral.Inputs.PrivateLinkServiceConnectionStateArgs privateLinkServiceConnectionState)
    {
        @selfRef.PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTCentral.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.IoTCentral.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTCentral.Inputs.PrivateLinkServiceConnectionStateArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTCentral.Inputs.PrivateLinkServiceConnectionStateArgs();
        @configure(@item);
        @selfRef.PrivateLinkServiceConnectionState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTCentral.PrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.IoTCentral.PrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTCentral.PrivateEndpointConnectionArgs WithResourceName(this global::Pulumi.AzureNative.IoTCentral.PrivateEndpointConnectionArgs @selfRef, global::System.String resourceName)
    {
        @selfRef.ResourceName = resourceName;
        return @selfRef;
    }

}
