// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.MongoCluster;

public static partial class PrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.MongoCluster.PrivateEndpointConnectionArgs WithMongoClusterName(this global::Pulumi.AzureNative.MongoCluster.PrivateEndpointConnectionArgs @selfRef, global::System.String mongoClusterName)
    {
        @selfRef.MongoClusterName = mongoClusterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MongoCluster.PrivateEndpointConnectionArgs WithPrivateEndpointConnectionName(this global::Pulumi.AzureNative.MongoCluster.PrivateEndpointConnectionArgs @selfRef, global::System.String privateEndpointConnectionName)
    {
        @selfRef.PrivateEndpointConnectionName = privateEndpointConnectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MongoCluster.PrivateEndpointConnectionArgs WithProperties(this global::Pulumi.AzureNative.MongoCluster.PrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.MongoCluster.Inputs.PrivateEndpointConnectionPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MongoCluster.PrivateEndpointConnectionArgs WithProperties(this global::Pulumi.AzureNative.MongoCluster.PrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MongoCluster.Inputs.PrivateEndpointConnectionPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MongoCluster.Inputs.PrivateEndpointConnectionPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MongoCluster.PrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.MongoCluster.PrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
