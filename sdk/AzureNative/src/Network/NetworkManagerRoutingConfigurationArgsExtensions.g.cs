// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Network;

public static partial class NetworkManagerRoutingConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.NetworkManagerRoutingConfigurationArgs WithConfigurationName(this global::Pulumi.AzureNative.Network.NetworkManagerRoutingConfigurationArgs @selfRef, global::System.String configurationName)
    {
        @selfRef.ConfigurationName = configurationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkManagerRoutingConfigurationArgs WithDescription(this global::Pulumi.AzureNative.Network.NetworkManagerRoutingConfigurationArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkManagerRoutingConfigurationArgs WithNetworkManagerName(this global::Pulumi.AzureNative.Network.NetworkManagerRoutingConfigurationArgs @selfRef, global::System.String networkManagerName)
    {
        @selfRef.NetworkManagerName = networkManagerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkManagerRoutingConfigurationArgs WithResourceGroupName(this global::Pulumi.AzureNative.Network.NetworkManagerRoutingConfigurationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
