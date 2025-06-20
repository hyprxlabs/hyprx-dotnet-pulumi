// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Purview;

public static partial class PrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs WithAccountName(this global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs WithPrivateEndpoint(this global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.Purview.Inputs.PrivateEndpointArgs privateEndpoint)
    {
        @selfRef.PrivateEndpoint = privateEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs WithPrivateEndpoint(this global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Purview.Inputs.PrivateEndpointArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Purview.Inputs.PrivateEndpointArgs();
        @configure(@item);
        @selfRef.PrivateEndpoint = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs WithPrivateEndpointConnectionName(this global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs @selfRef, global::System.String privateEndpointConnectionName)
    {
        @selfRef.PrivateEndpointConnectionName = privateEndpointConnectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.Purview.Inputs.PrivateLinkServiceConnectionStateArgs privateLinkServiceConnectionState)
    {
        @selfRef.PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Purview.Inputs.PrivateLinkServiceConnectionStateArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Purview.Inputs.PrivateLinkServiceConnectionStateArgs();
        @configure(@item);
        @selfRef.PrivateLinkServiceConnectionState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.Purview.PrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
