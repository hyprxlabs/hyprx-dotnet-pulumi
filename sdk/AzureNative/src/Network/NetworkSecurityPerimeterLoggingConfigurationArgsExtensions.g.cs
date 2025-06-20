// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Network;

public static partial class NetworkSecurityPerimeterLoggingConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterLoggingConfigurationArgs WithLoggingConfigurationName(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterLoggingConfigurationArgs @selfRef, global::System.String loggingConfigurationName)
    {
        @selfRef.LoggingConfigurationName = loggingConfigurationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterLoggingConfigurationArgs WithNetworkSecurityPerimeterName(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterLoggingConfigurationArgs @selfRef, global::System.String networkSecurityPerimeterName)
    {
        @selfRef.NetworkSecurityPerimeterName = networkSecurityPerimeterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterLoggingConfigurationArgs WithProperties(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterLoggingConfigurationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.NspLoggingConfigurationPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterLoggingConfigurationArgs WithProperties(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterLoggingConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.NspLoggingConfigurationPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.NspLoggingConfigurationPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterLoggingConfigurationArgs WithResourceGroupName(this global::Pulumi.AzureNative.Network.NetworkSecurityPerimeterLoggingConfigurationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
