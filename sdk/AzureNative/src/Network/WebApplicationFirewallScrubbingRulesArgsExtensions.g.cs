// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class WebApplicationFirewallScrubbingRulesArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.WebApplicationFirewallScrubbingRulesArgs WithMatchVariable(this global::Pulumi.AzureNative.Network.Inputs.WebApplicationFirewallScrubbingRulesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.ScrubbingRuleEntryMatchVariable> matchVariable)
    {
        @selfRef.MatchVariable = matchVariable;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.WebApplicationFirewallScrubbingRulesArgs WithSelector(this global::Pulumi.AzureNative.Network.Inputs.WebApplicationFirewallScrubbingRulesArgs @selfRef, global::System.String selector)
    {
        @selfRef.Selector = selector;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.WebApplicationFirewallScrubbingRulesArgs WithSelectorMatchOperator(this global::Pulumi.AzureNative.Network.Inputs.WebApplicationFirewallScrubbingRulesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.ScrubbingRuleEntryMatchOperator> selectorMatchOperator)
    {
        @selfRef.SelectorMatchOperator = selectorMatchOperator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.WebApplicationFirewallScrubbingRulesArgs WithState(this global::Pulumi.AzureNative.Network.Inputs.WebApplicationFirewallScrubbingRulesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.ScrubbingRuleEntryState> state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

}
