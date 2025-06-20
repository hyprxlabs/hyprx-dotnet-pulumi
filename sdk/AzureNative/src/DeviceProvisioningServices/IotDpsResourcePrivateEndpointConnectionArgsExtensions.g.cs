// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.DeviceProvisioningServices;

public static partial class IotDpsResourcePrivateEndpointConnectionArgsExtensions
{
    public static global::Pulumi.AzureNative.DeviceProvisioningServices.IotDpsResourcePrivateEndpointConnectionArgs WithPrivateEndpointConnectionName(this global::Pulumi.AzureNative.DeviceProvisioningServices.IotDpsResourcePrivateEndpointConnectionArgs @selfRef, global::System.String privateEndpointConnectionName)
    {
        @selfRef.PrivateEndpointConnectionName = privateEndpointConnectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceProvisioningServices.IotDpsResourcePrivateEndpointConnectionArgs WithProperties(this global::Pulumi.AzureNative.DeviceProvisioningServices.IotDpsResourcePrivateEndpointConnectionArgs @selfRef, global::Pulumi.AzureNative.DeviceProvisioningServices.Inputs.PrivateEndpointConnectionPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceProvisioningServices.IotDpsResourcePrivateEndpointConnectionArgs WithProperties(this global::Pulumi.AzureNative.DeviceProvisioningServices.IotDpsResourcePrivateEndpointConnectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DeviceProvisioningServices.Inputs.PrivateEndpointConnectionPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DeviceProvisioningServices.Inputs.PrivateEndpointConnectionPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceProvisioningServices.IotDpsResourcePrivateEndpointConnectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.DeviceProvisioningServices.IotDpsResourcePrivateEndpointConnectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DeviceProvisioningServices.IotDpsResourcePrivateEndpointConnectionArgs WithResourceName(this global::Pulumi.AzureNative.DeviceProvisioningServices.IotDpsResourcePrivateEndpointConnectionArgs @selfRef, global::System.String resourceName)
    {
        @selfRef.ResourceName = resourceName;
        return @selfRef;
    }

}
