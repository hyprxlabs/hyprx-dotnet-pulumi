// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ServiceLinker.Inputs;

namespace Pulumi.AzureNative.ServiceLinker;

public static partial class PublicNetworkSolutionArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.PublicNetworkSolutionArgs WithAction(this global::Pulumi.AzureNative.ServiceLinker.Inputs.PublicNetworkSolutionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceLinker.ActionType> action)
    {
        @selfRef.Action = action;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.PublicNetworkSolutionArgs WithDeleteOrUpdateBehavior(this global::Pulumi.AzureNative.ServiceLinker.Inputs.PublicNetworkSolutionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceLinker.DeleteOrUpdateBehavior> deleteOrUpdateBehavior)
    {
        @selfRef.DeleteOrUpdateBehavior = deleteOrUpdateBehavior;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.PublicNetworkSolutionArgs WithFirewallRules(this global::Pulumi.AzureNative.ServiceLinker.Inputs.PublicNetworkSolutionArgs @selfRef, global::Pulumi.AzureNative.ServiceLinker.Inputs.FirewallRulesArgs firewallRules)
    {
        @selfRef.FirewallRules = firewallRules;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceLinker.Inputs.PublicNetworkSolutionArgs WithFirewallRules(this global::Pulumi.AzureNative.ServiceLinker.Inputs.PublicNetworkSolutionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ServiceLinker.Inputs.FirewallRulesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ServiceLinker.Inputs.FirewallRulesArgs();
        @configure(@item);
        @selfRef.FirewallRules = @item;
        return @selfRef;
    }

}
