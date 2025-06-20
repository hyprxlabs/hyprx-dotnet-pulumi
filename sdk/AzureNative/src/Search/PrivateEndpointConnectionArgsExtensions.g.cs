// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Search;

public static partial class PrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.Search.PrivateEndpointConnectionArgs WithPrivateEndpointConnectionName(this global::Pulumi.AzureNative.Search.PrivateEndpointConnectionArgs @selfRef, global::System.String privateEndpointConnectionName)
    {
        @selfRef.PrivateEndpointConnectionName = privateEndpointConnectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Search.PrivateEndpointConnectionArgs WithProperties(this global::Pulumi.AzureNative.Search.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.Search.Inputs.PrivateEndpointConnectionPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Search.PrivateEndpointConnectionArgs WithProperties(this global::Pulumi.AzureNative.Search.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Search.Inputs.PrivateEndpointConnectionPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Search.Inputs.PrivateEndpointConnectionPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Search.PrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.Search.PrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Search.PrivateEndpointConnectionArgs WithSearchServiceName(this global::Pulumi.AzureNative.Search.PrivateEndpointConnectionArgs @selfRef, global::System.String searchServiceName)
    {
        @selfRef.SearchServiceName = searchServiceName;
        return @selfRef;
    }

}
