// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class NetworkInterfaceIPConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithApplicationGatewayBackendAddressPools(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayBackendAddressPoolArgs> applicationGatewayBackendAddressPools)
    {
        @selfRef.ApplicationGatewayBackendAddressPools = applicationGatewayBackendAddressPools;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithApplicationGatewayBackendAddressPools(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayBackendAddressPoolArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayBackendAddressPoolArgs>();
        @configure(@list);
        @selfRef.ApplicationGatewayBackendAddressPools = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithApplicationGatewayBackendAddressPools(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayBackendAddressPoolArgs>> @create)
    {
        @selfRef.ApplicationGatewayBackendAddressPools = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithApplicationSecurityGroups(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs> applicationSecurityGroups)
    {
        @selfRef.ApplicationSecurityGroups = applicationSecurityGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithApplicationSecurityGroups(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs>();
        @configure(@list);
        @selfRef.ApplicationSecurityGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithApplicationSecurityGroups(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.ApplicationSecurityGroupArgs>> @create)
    {
        @selfRef.ApplicationSecurityGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithGatewayLoadBalancer(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs gatewayLoadBalancer)
    {
        @selfRef.GatewayLoadBalancer = gatewayLoadBalancer;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithGatewayLoadBalancer(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.GatewayLoadBalancer = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithLoadBalancerBackendAddressPools(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.BackendAddressPoolArgs> loadBalancerBackendAddressPools)
    {
        @selfRef.LoadBalancerBackendAddressPools = loadBalancerBackendAddressPools;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithLoadBalancerBackendAddressPools(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.BackendAddressPoolArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.BackendAddressPoolArgs>();
        @configure(@list);
        @selfRef.LoadBalancerBackendAddressPools = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithLoadBalancerBackendAddressPools(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.BackendAddressPoolArgs>> @create)
    {
        @selfRef.LoadBalancerBackendAddressPools = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithLoadBalancerInboundNatRules(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.InboundNatRuleArgs> loadBalancerInboundNatRules)
    {
        @selfRef.LoadBalancerInboundNatRules = loadBalancerInboundNatRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithLoadBalancerInboundNatRules(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.InboundNatRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.InboundNatRuleArgs>();
        @configure(@list);
        @selfRef.LoadBalancerInboundNatRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithLoadBalancerInboundNatRules(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.InboundNatRuleArgs>> @create)
    {
        @selfRef.LoadBalancerInboundNatRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithPrimary(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, bool primary = true)
    {
        @selfRef.Primary = primary;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithPrivateIPAddress(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.String privateIPAddress)
    {
        @selfRef.PrivateIPAddress = privateIPAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithPrivateIPAddressPrefixLength(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Int32 privateIPAddressPrefixLength)
    {
        @selfRef.PrivateIPAddressPrefixLength = privateIPAddressPrefixLength;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithPrivateIPAddressVersion(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.IPVersion> privateIPAddressVersion)
    {
        @selfRef.PrivateIPAddressVersion = privateIPAddressVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithPrivateIPAllocationMethod(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.IPAllocationMethod> privateIPAllocationMethod)
    {
        @selfRef.PrivateIPAllocationMethod = privateIPAllocationMethod;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithPublicIPAddress(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.PublicIPAddressArgs publicIPAddress)
    {
        @selfRef.PublicIPAddress = publicIPAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithPublicIPAddress(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.PublicIPAddressArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.PublicIPAddressArgs();
        @configure(@item);
        @selfRef.PublicIPAddress = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithSubnet(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubnetArgs subnet)
    {
        @selfRef.Subnet = subnet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithSubnet(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubnetArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubnetArgs();
        @configure(@item);
        @selfRef.Subnet = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithType(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithVirtualNetworkTaps(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkTapArgs> virtualNetworkTaps)
    {
        @selfRef.VirtualNetworkTaps = virtualNetworkTaps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithVirtualNetworkTaps(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkTapArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkTapArgs>();
        @configure(@list);
        @selfRef.VirtualNetworkTaps = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs WithVirtualNetworkTaps(this global::Pulumi.AzureNative.Network.Inputs.NetworkInterfaceIPConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.VirtualNetworkTapArgs>> @create)
    {
        @selfRef.VirtualNetworkTaps = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
