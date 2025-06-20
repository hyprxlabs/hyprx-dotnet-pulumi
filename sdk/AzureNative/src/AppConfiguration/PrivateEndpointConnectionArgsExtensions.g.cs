// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AppConfiguration;

public static partial class PrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs WithConfigStoreName(this global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs @selfRef, global::System.String configStoreName)
    {
        @selfRef.ConfigStoreName = configStoreName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs WithPrivateEndpoint(this global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.AppConfiguration.Inputs.PrivateEndpointArgs privateEndpoint)
    {
        @selfRef.PrivateEndpoint = privateEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs WithPrivateEndpoint(this global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppConfiguration.Inputs.PrivateEndpointArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppConfiguration.Inputs.PrivateEndpointArgs();
        @configure(@item);
        @selfRef.PrivateEndpoint = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs WithPrivateEndpointConnectionName(this global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs @selfRef, global::System.String privateEndpointConnectionName)
    {
        @selfRef.PrivateEndpointConnectionName = privateEndpointConnectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.AppConfiguration.Inputs.PrivateLinkServiceConnectionStateArgs privateLinkServiceConnectionState)
    {
        @selfRef.PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AppConfiguration.Inputs.PrivateLinkServiceConnectionStateArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AppConfiguration.Inputs.PrivateLinkServiceConnectionStateArgs();
        @configure(@item);
        @selfRef.PrivateLinkServiceConnectionState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.AppConfiguration.PrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
