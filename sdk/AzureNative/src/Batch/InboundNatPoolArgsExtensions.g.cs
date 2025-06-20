// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Batch.Inputs;

namespace Pulumi.AzureNative.Batch;

public static partial class InboundNatPoolArgsExtensions
{
    public static global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs WithBackendPort(this global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs @selfRef, global::System.Int32 backendPort)
    {
        @selfRef.BackendPort = backendPort;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs WithFrontendPortRangeEnd(this global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs @selfRef, global::System.Int32 frontendPortRangeEnd)
    {
        @selfRef.FrontendPortRangeEnd = frontendPortRangeEnd;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs WithFrontendPortRangeStart(this global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs @selfRef, global::System.Int32 frontendPortRangeStart)
    {
        @selfRef.FrontendPortRangeStart = frontendPortRangeStart;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs WithName(this global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs WithNetworkSecurityGroupRules(this global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Batch.Inputs.NetworkSecurityGroupRuleArgs> networkSecurityGroupRules)
    {
        @selfRef.NetworkSecurityGroupRules = networkSecurityGroupRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs WithNetworkSecurityGroupRules(this global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Batch.Inputs.NetworkSecurityGroupRuleArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Batch.Inputs.NetworkSecurityGroupRuleArgs>();
        @configure(@list);
        @selfRef.NetworkSecurityGroupRules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs WithNetworkSecurityGroupRules(this global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Batch.Inputs.NetworkSecurityGroupRuleArgs>> @create)
    {
        @selfRef.NetworkSecurityGroupRules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs WithProtocol(this global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs @selfRef, global::Pulumi.AzureNative.Batch.InboundEndpointProtocol protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs WithProtocol(this global::Pulumi.AzureNative.Batch.Inputs.InboundNatPoolArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Batch.InboundEndpointProtocol> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Batch.InboundEndpointProtocol>();
        @configure(@item);
        @selfRef.Protocol = @item;
        return @selfRef;
    }

}
