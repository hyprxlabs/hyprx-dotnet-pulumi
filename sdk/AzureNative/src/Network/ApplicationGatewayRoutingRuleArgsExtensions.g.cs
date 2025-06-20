// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class ApplicationGatewayRoutingRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs WithBackendAddressPool(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs backendAddressPool)
    {
        @selfRef.BackendAddressPool = backendAddressPool;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs WithBackendAddressPool(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.BackendAddressPool = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs WithBackendSettings(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs backendSettings)
    {
        @selfRef.BackendSettings = backendSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs WithBackendSettings(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.BackendSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs WithListener(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs listener)
    {
        @selfRef.Listener = listener;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs WithListener(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.Listener = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs WithPriority(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs @selfRef, global::System.Int32 priority)
    {
        @selfRef.Priority = priority;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs WithRuleType(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayRoutingRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.ApplicationGatewayRequestRoutingRuleType> ruleType)
    {
        @selfRef.RuleType = ruleType;
        return @selfRef;
    }

}
