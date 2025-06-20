// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Network;

public static partial class NetworkInterfaceTapConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs WithId(this global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs WithName(this global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs WithNetworkInterfaceName(this global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs @selfRef, global::System.String networkInterfaceName)
    {
        @selfRef.NetworkInterfaceName = networkInterfaceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs WithResourceGroupName(this global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs WithTapConfigurationName(this global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs @selfRef, global::System.String tapConfigurationName)
    {
        @selfRef.TapConfigurationName = tapConfigurationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs WithVirtualNetworkTap(this global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkTapArgs virtualNetworkTap)
    {
        @selfRef.VirtualNetworkTap = virtualNetworkTap;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs WithVirtualNetworkTap(this global::Pulumi.AzureNative.Network.NetworkInterfaceTapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkTapArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkTapArgs();
        @configure(@item);
        @selfRef.VirtualNetworkTap = @item;
        return @selfRef;
    }

}
