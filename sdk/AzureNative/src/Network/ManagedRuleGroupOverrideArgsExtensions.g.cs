// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class ManagedRuleGroupOverrideArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.ManagedRuleGroupOverrideArgs WithRuleGroupName(this global::Pulumi.AzureNative.Network.Inputs.ManagedRuleGroupOverrideArgs @selfRef, global::System.String ruleGroupName)
    {
        @selfRef.RuleGroupName = ruleGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ManagedRuleGroupOverrideArgs WithRules(this global::Pulumi.AzureNative.Network.Inputs.ManagedRuleGroupOverrideArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ManagedRuleOverrideArgs> rules)
    {
        @selfRef.Rules = rules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ManagedRuleGroupOverrideArgs WithRules(this global::Pulumi.AzureNative.Network.Inputs.ManagedRuleGroupOverrideArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ManagedRuleOverrideArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ManagedRuleOverrideArgs>();
        @configure(@list);
        @selfRef.Rules = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ManagedRuleGroupOverrideArgs WithRules(this global::Pulumi.AzureNative.Network.Inputs.ManagedRuleGroupOverrideArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.ManagedRuleOverrideArgs>> @create)
    {
        @selfRef.Rules = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
