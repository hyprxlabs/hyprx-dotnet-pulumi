// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class VpnGatewayNatRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs WithExternalMappings(this global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VpnNatRuleMappingArgs> externalMappings)
    {
        @selfRef.ExternalMappings = externalMappings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs WithExternalMappings(this global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VpnNatRuleMappingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VpnNatRuleMappingArgs>();
        @configure(@list);
        @selfRef.ExternalMappings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs WithExternalMappings(this global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.VpnNatRuleMappingArgs>> @create)
    {
        @selfRef.ExternalMappings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs WithInternalMappings(this global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VpnNatRuleMappingArgs> internalMappings)
    {
        @selfRef.InternalMappings = internalMappings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs WithInternalMappings(this global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VpnNatRuleMappingArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VpnNatRuleMappingArgs>();
        @configure(@list);
        @selfRef.InternalMappings = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs WithInternalMappings(this global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.VpnNatRuleMappingArgs>> @create)
    {
        @selfRef.InternalMappings = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs WithIpConfigurationId(this global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs @selfRef, global::System.String ipConfigurationId)
    {
        @selfRef.IpConfigurationId = ipConfigurationId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs WithMode(this global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.VpnNatRuleMode> mode)
    {
        @selfRef.Mode = mode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs WithType(this global::Pulumi.AzureNative.Network.Inputs.VpnGatewayNatRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.VpnNatRuleType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
