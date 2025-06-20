// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ManagedNetworkFabric.Inputs;

namespace Pulumi.AzureNative.ManagedNetworkFabric;

public static partial class NetworkTapRuleMatchConditionArgsExtensions
{
    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs WithEncapsulationType(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ManagedNetworkFabric.EncapsulationType> encapsulationType)
    {
        @selfRef.EncapsulationType = encapsulationType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs WithIpCondition(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs @selfRef, global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.IpMatchConditionArgs ipCondition)
    {
        @selfRef.IpCondition = ipCondition;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs WithIpCondition(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.IpMatchConditionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.IpMatchConditionArgs();
        @configure(@item);
        @selfRef.IpCondition = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs WithPortCondition(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs @selfRef, global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.PortConditionArgs portCondition)
    {
        @selfRef.PortCondition = portCondition;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs WithPortCondition(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.PortConditionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.PortConditionArgs();
        @configure(@item);
        @selfRef.PortCondition = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs WithProtocolTypes(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> protocolTypes)
    {
        @selfRef.ProtocolTypes = protocolTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs WithProtocolTypes(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ProtocolTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs WithProtocolTypes(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ProtocolTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs WithVlanMatchCondition(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs @selfRef, global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VlanMatchConditionArgs vlanMatchCondition)
    {
        @selfRef.VlanMatchCondition = vlanMatchCondition;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs WithVlanMatchCondition(this global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.NetworkTapRuleMatchConditionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VlanMatchConditionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ManagedNetworkFabric.Inputs.VlanMatchConditionArgs();
        @configure(@item);
        @selfRef.VlanMatchCondition = @item;
        return @selfRef;
    }

}
