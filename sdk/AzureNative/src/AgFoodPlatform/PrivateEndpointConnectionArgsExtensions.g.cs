// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AgFoodPlatform;

public static partial class PrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.AgFoodPlatform.PrivateEndpointConnectionArgs WithDataManagerForAgricultureResourceName(this global::Pulumi.AzureNative.AgFoodPlatform.PrivateEndpointConnectionArgs @selfRef, global::System.String dataManagerForAgricultureResourceName)
    {
        @selfRef.DataManagerForAgricultureResourceName = dataManagerForAgricultureResourceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AgFoodPlatform.PrivateEndpointConnectionArgs WithPrivateEndpointConnectionName(this global::Pulumi.AzureNative.AgFoodPlatform.PrivateEndpointConnectionArgs @selfRef, global::System.String privateEndpointConnectionName)
    {
        @selfRef.PrivateEndpointConnectionName = privateEndpointConnectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AgFoodPlatform.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.AgFoodPlatform.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.AgFoodPlatform.Inputs.PrivateLinkServiceConnectionStateArgs privateLinkServiceConnectionState)
    {
        @selfRef.PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AgFoodPlatform.PrivateEndpointConnectionArgs WithPrivateLinkServiceConnectionState(this global::Pulumi.AzureNative.AgFoodPlatform.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AgFoodPlatform.Inputs.PrivateLinkServiceConnectionStateArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AgFoodPlatform.Inputs.PrivateLinkServiceConnectionStateArgs();
        @configure(@item);
        @selfRef.PrivateLinkServiceConnectionState = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AgFoodPlatform.PrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.AgFoodPlatform.PrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
