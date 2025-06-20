// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class PrivateLinkServiceIpConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs WithPrimary(this global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs @selfRef, bool primary = true)
    {
        @selfRef.Primary = primary;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs WithPrivateIPAddress(this global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs @selfRef, global::System.String privateIPAddress)
    {
        @selfRef.PrivateIPAddress = privateIPAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs WithPrivateIPAddressVersion(this global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.IPVersion> privateIPAddressVersion)
    {
        @selfRef.PrivateIPAddressVersion = privateIPAddressVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs WithPrivateIPAllocationMethod(this global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.IPAllocationMethod> privateIPAllocationMethod)
    {
        @selfRef.PrivateIPAllocationMethod = privateIPAllocationMethod;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs WithSubnet(this global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubnetArgs subnet)
    {
        @selfRef.Subnet = subnet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs WithSubnet(this global::Pulumi.AzureNative.Network.Inputs.PrivateLinkServiceIpConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubnetArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubnetArgs();
        @configure(@item);
        @selfRef.Subnet = @item;
        return @selfRef;
    }

}
