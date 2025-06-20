// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SignalRService;

public static partial class SignalRPrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs WithPrivateEndpoint(this global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.SignalRService.Inputs.PrivateEndpointArgs privateEndpoint)
    {
        @selfRef.PrivateEndpoint = privateEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs WithPrivateEndpoint(this global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.SignalRService.Inputs.PrivateEndpointArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.SignalRService.Inputs.PrivateEndpointArgs();
        @configure(@item);
        @selfRef.PrivateEndpoint = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs WithPrivateEndpointConnectionName(this global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs @selfRef, global::System.String privateEndpointConnectionName)
    {
        @selfRef.PrivateEndpointConnectionName = privateEndpointConnectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.SignalRService.Inputs.PrivateLinkServiceConnectionStateArgs privateLinkServiceConnectionState)
    {
        @selfRef.PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.SignalRService.Inputs.PrivateLinkServiceConnectionStateArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.SignalRService.Inputs.PrivateLinkServiceConnectionStateArgs();
        @configure(@item);
        @selfRef.PrivateLinkServiceConnectionState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs WithResourceName(this global::Pulumi.AzureNative.SignalRService.SignalRPrivateEndpointConnectionArgs @selfRef, global::System.String resourceName)
    {
        @selfRef.ResourceName = resourceName;
        return @selfRef;
    }

}
