// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Kusto;

public static partial class PrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.Kusto.PrivateEndpointConnectionArgs WithClusterName(this global::Pulumi.AzureNative.Kusto.PrivateEndpointConnectionArgs @selfRef, global::System.String clusterName)
    {
        @selfRef.ClusterName = clusterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.PrivateEndpointConnectionArgs WithPrivateEndpointConnectionName(this global::Pulumi.AzureNative.Kusto.PrivateEndpointConnectionArgs @selfRef, global::System.String privateEndpointConnectionName)
    {
        @selfRef.PrivateEndpointConnectionName = privateEndpointConnectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.Kusto.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.Kusto.Inputs.PrivateLinkServiceConnectionStatePropertyArgs privateLinkServiceConnectionState)
    {
        @selfRef.PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.Kusto.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Kusto.Inputs.PrivateLinkServiceConnectionStatePropertyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Kusto.Inputs.PrivateLinkServiceConnectionStatePropertyArgs();
        @configure(@item);
        @selfRef.PrivateLinkServiceConnectionState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Kusto.PrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.Kusto.PrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
