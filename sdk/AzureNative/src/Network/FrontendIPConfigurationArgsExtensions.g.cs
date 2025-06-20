// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class FrontendIPConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithGatewayLoadBalancer(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs gatewayLoadBalancer)
    {
        @selfRef.GatewayLoadBalancer = gatewayLoadBalancer;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithGatewayLoadBalancer(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.GatewayLoadBalancer = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithPrivateIPAddress(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::System.String privateIPAddress)
    {
        @selfRef.PrivateIPAddress = privateIPAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithPrivateIPAddressVersion(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.IPVersion> privateIPAddressVersion)
    {
        @selfRef.PrivateIPAddressVersion = privateIPAddressVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithPrivateIPAllocationMethod(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.IPAllocationMethod> privateIPAllocationMethod)
    {
        @selfRef.PrivateIPAllocationMethod = privateIPAllocationMethod;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithPublicIPAddress(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.PublicIPAddressArgs publicIPAddress)
    {
        @selfRef.PublicIPAddress = publicIPAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithPublicIPAddress(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.PublicIPAddressArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.PublicIPAddressArgs();
        @configure(@item);
        @selfRef.PublicIPAddress = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithPublicIPPrefix(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs publicIPPrefix)
    {
        @selfRef.PublicIPPrefix = publicIPPrefix;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithPublicIPPrefix(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.PublicIPPrefix = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithSubnet(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubnetArgs subnet)
    {
        @selfRef.Subnet = subnet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithSubnet(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubnetArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubnetArgs();
        @configure(@item);
        @selfRef.Subnet = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithZones(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> zones)
    {
        @selfRef.Zones = zones;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithZones(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Zones = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs WithZones(this global::Pulumi.AzureNative.Network.Inputs.FrontendIPConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Zones = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
