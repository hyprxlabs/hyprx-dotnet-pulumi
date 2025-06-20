// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.FrontDoor.Inputs;

namespace Pulumi.AzureNative.FrontDoor;

public static partial class ManagedRuleSetArgsExtensions
{
    public static global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs WithExclusions(this global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleExclusionArgs> exclusions)
    {
        @selfRef.Exclusions = exclusions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs WithExclusions(this global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleExclusionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleExclusionArgs>();
        @configure(@list);
        @selfRef.Exclusions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs WithExclusions(this global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleExclusionArgs>> @create)
    {
        @selfRef.Exclusions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs WithRuleGroupOverrides(this global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleGroupOverrideArgs> ruleGroupOverrides)
    {
        @selfRef.RuleGroupOverrides = ruleGroupOverrides;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs WithRuleGroupOverrides(this global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleGroupOverrideArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleGroupOverrideArgs>();
        @configure(@list);
        @selfRef.RuleGroupOverrides = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs WithRuleGroupOverrides(this global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleGroupOverrideArgs>> @create)
    {
        @selfRef.RuleGroupOverrides = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs WithRuleSetAction(this global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.FrontDoor.ManagedRuleSetActionType> ruleSetAction)
    {
        @selfRef.RuleSetAction = ruleSetAction;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs WithRuleSetType(this global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs @selfRef, global::System.String ruleSetType)
    {
        @selfRef.RuleSetType = ruleSetType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs WithRuleSetVersion(this global::Pulumi.AzureNative.FrontDoor.Inputs.ManagedRuleSetArgs @selfRef, global::System.String ruleSetVersion)
    {
        @selfRef.RuleSetVersion = ruleSetVersion;
        return @selfRef;
    }

}
