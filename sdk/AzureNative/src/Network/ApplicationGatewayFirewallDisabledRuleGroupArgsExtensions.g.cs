// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class ApplicationGatewayFirewallDisabledRuleGroupArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayFirewallDisabledRuleGroupArgs WithRuleGroupName(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayFirewallDisabledRuleGroupArgs @selfRef, global::System.String ruleGroupName)
    {
        @selfRef.RuleGroupName = ruleGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayFirewallDisabledRuleGroupArgs WithRules(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayFirewallDisabledRuleGroupArgs @selfRef, global::System.Collections.Generic.List<global::System.Int32> rules)
    {
        @selfRef.Rules = rules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayFirewallDisabledRuleGroupArgs WithRules(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayFirewallDisabledRuleGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Int32>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Int32>();
        @configure(@list);
        @selfRef.Rules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayFirewallDisabledRuleGroupArgs WithRules(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayFirewallDisabledRuleGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Int32>> @create)
    {
        @selfRef.Rules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
