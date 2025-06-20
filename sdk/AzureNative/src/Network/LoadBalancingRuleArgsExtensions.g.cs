// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class LoadBalancingRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithBackendAddressPool(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs backendAddressPool)
    {
        @selfRef.BackendAddressPool = backendAddressPool;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithBackendAddressPool(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.BackendAddressPool = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithBackendAddressPools(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> backendAddressPools)
    {
        @selfRef.BackendAddressPools = backendAddressPools;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithBackendAddressPools(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs>();
        @configure(@list);
        @selfRef.BackendAddressPools = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithBackendAddressPools(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs>> @create)
    {
        @selfRef.BackendAddressPools = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithBackendPort(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::System.Int32 backendPort)
    {
        @selfRef.BackendPort = backendPort;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithDisableOutboundSnat(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, bool disableOutboundSnat = true)
    {
        @selfRef.DisableOutboundSnat = disableOutboundSnat;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithEnableFloatingIP(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, bool enableFloatingIP = true)
    {
        @selfRef.EnableFloatingIP = enableFloatingIP;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithEnableTcpReset(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, bool enableTcpReset = true)
    {
        @selfRef.EnableTcpReset = enableTcpReset;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithFrontendIPConfiguration(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs frontendIPConfiguration)
    {
        @selfRef.FrontendIPConfiguration = frontendIPConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithFrontendIPConfiguration(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.FrontendIPConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithFrontendPort(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::System.Int32 frontendPort)
    {
        @selfRef.FrontendPort = frontendPort;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithIdleTimeoutInMinutes(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::System.Int32 idleTimeoutInMinutes)
    {
        @selfRef.IdleTimeoutInMinutes = idleTimeoutInMinutes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithLoadDistribution(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.LoadDistribution> loadDistribution)
    {
        @selfRef.LoadDistribution = loadDistribution;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithProbe(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs probe)
    {
        @selfRef.Probe = probe;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithProbe(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.Probe = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs WithProtocol(this global::Pulumi.AzureNative.Network.Inputs.LoadBalancingRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.TransportProtocol> protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

}
