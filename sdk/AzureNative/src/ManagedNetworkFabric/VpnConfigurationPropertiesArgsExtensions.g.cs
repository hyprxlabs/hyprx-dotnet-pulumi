// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ManagedNetworkFabric.Inputs;

namespace Pulumi.AzureNative.ManagedNetworkFabric;

public static partial class VpnConfigurationPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesArgs WithNetworkToNetworkInterconnectId(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesArgs @selfRef, global::System.String networkToNetworkInterconnectId)
    {
        @selfRef.NetworkToNetworkInterconnectId = networkToNetworkInterconnectId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesArgs WithOptionAProperties(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesArgs @selfRef, global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesOptionAPropertiesArgs optionAProperties)
    {
        @selfRef.OptionAProperties = optionAProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesArgs WithOptionAProperties(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesOptionAPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesOptionAPropertiesArgs();
        @configure(@item);
        @selfRef.OptionAProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesArgs WithOptionBProperties(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesArgs @selfRef, global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.FabricOptionBPropertiesArgs optionBProperties)
    {
        @selfRef.OptionBProperties = optionBProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesArgs WithOptionBProperties(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.FabricOptionBPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.FabricOptionBPropertiesArgs();
        @configure(@item);
        @selfRef.OptionBProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesArgs WithPeeringOption(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VpnConfigurationPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ManagedNetworkFabric.PeeringOption> peeringOption)
    {
        @selfRef.PeeringOption = peeringOption;
        return @selfRef;
    }

}
