// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class VirtualMachineScaleSetIPConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithApplicationGatewayBackendAddressPools(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs> applicationGatewayBackendAddressPools)
    {
        @selfRef.ApplicationGatewayBackendAddressPools = applicationGatewayBackendAddressPools;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithApplicationGatewayBackendAddressPools(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs>();
        @configure(@list);
        @selfRef.ApplicationGatewayBackendAddressPools = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithApplicationGatewayBackendAddressPools(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs>> @create)
    {
        @selfRef.ApplicationGatewayBackendAddressPools = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithApplicationSecurityGroups(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs> applicationSecurityGroups)
    {
        @selfRef.ApplicationSecurityGroups = applicationSecurityGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithApplicationSecurityGroups(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs>();
        @configure(@list);
        @selfRef.ApplicationSecurityGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithApplicationSecurityGroups(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs>> @create)
    {
        @selfRef.ApplicationSecurityGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithLoadBalancerBackendAddressPools(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs> loadBalancerBackendAddressPools)
    {
        @selfRef.LoadBalancerBackendAddressPools = loadBalancerBackendAddressPools;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithLoadBalancerBackendAddressPools(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs>();
        @configure(@list);
        @selfRef.LoadBalancerBackendAddressPools = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithLoadBalancerBackendAddressPools(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs>> @create)
    {
        @selfRef.LoadBalancerBackendAddressPools = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithLoadBalancerInboundNatPools(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs> loadBalancerInboundNatPools)
    {
        @selfRef.LoadBalancerInboundNatPools = loadBalancerInboundNatPools;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithLoadBalancerInboundNatPools(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs>();
        @configure(@list);
        @selfRef.LoadBalancerInboundNatPools = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithLoadBalancerInboundNatPools(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.SubResourceArgs>> @create)
    {
        @selfRef.LoadBalancerInboundNatPools = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithName(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithPrimary(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, bool primary = true)
    {
        @selfRef.Primary = primary;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithPrivateIPAddressVersion(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Compute.IPVersion> privateIPAddressVersion)
    {
        @selfRef.PrivateIPAddressVersion = privateIPAddressVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithPublicIPAddressConfiguration(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetPublicIPAddressConfigurationArgs publicIPAddressConfiguration)
    {
        @selfRef.PublicIPAddressConfiguration = publicIPAddressConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithPublicIPAddressConfiguration(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetPublicIPAddressConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetPublicIPAddressConfigurationArgs();
        @configure(@item);
        @selfRef.PublicIPAddressConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithSubnet(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.ApiEntityReferenceArgs subnet)
    {
        @selfRef.Subnet = subnet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs WithSubnet(this global::Pulumi.AzureNative.Compute.Inputs.VirtualMachineScaleSetIPConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.ApiEntityReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.ApiEntityReferenceArgs();
        @configure(@item);
        @selfRef.Subnet = @item;
        return @selfRef;
    }

}
