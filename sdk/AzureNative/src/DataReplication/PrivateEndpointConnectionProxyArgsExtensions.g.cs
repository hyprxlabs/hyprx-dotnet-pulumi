// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DataReplication;

public static partial class PrivateEndpointConnectionProxyArgsExtensions
{
    public static global::Pulumi.AzureNative.DataReplication.PrivateEndpointConnectionProxyArgs WithPrivateEndpointConnectionProxyName(this global::Pulumi.AzureNative.DataReplication.PrivateEndpointConnectionProxyArgs @selfRef, global::System.String privateEndpointConnectionProxyName)
    {
        @selfRef.PrivateEndpointConnectionProxyName = privateEndpointConnectionProxyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.PrivateEndpointConnectionProxyArgs WithProperties(this global::Pulumi.AzureNative.DataReplication.PrivateEndpointConnectionProxyArgs @selfRef, global::Pulumi.AzureNative.DataReplication.Inputs.PrivateEndpointConnectionProxyPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.PrivateEndpointConnectionProxyArgs WithProperties(this global::Pulumi.AzureNative.DataReplication.PrivateEndpointConnectionProxyArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataReplication.Inputs.PrivateEndpointConnectionProxyPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataReplication.Inputs.PrivateEndpointConnectionProxyPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.PrivateEndpointConnectionProxyArgs WithResourceGroupName(this global::Pulumi.AzureNative.DataReplication.PrivateEndpointConnectionProxyArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataReplication.PrivateEndpointConnectionProxyArgs WithVaultName(this global::Pulumi.AzureNative.DataReplication.PrivateEndpointConnectionProxyArgs @selfRef, global::System.String vaultName)
    {
        @selfRef.VaultName = vaultName;
        return @selfRef;
    }

}
