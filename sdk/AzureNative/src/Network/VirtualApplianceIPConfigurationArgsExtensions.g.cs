// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class VirtualApplianceIPConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceIPConfigurationArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceIPConfigurationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceIPConfigurationArgs WithProperties(this global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceIPConfigurationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceIPConfigurationPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceIPConfigurationArgs WithProperties(this global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceIPConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceIPConfigurationPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceIPConfigurationPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

}
