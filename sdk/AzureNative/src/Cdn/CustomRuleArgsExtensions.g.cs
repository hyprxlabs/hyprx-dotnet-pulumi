// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Cdn.Inputs;

namespace Pulumi.AzureNative.Cdn;

public static partial class CustomRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs WithAction(this global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.ActionType> action)
    {
        @selfRef.Action = action;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs WithEnabledState(this global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.CustomRuleEnabledState> enabledState)
    {
        @selfRef.EnabledState = enabledState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs WithMatchConditions(this global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Cdn.Inputs.MatchConditionArgs> matchConditions)
    {
        @selfRef.MatchConditions = matchConditions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs WithMatchConditions(this global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Cdn.Inputs.MatchConditionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Cdn.Inputs.MatchConditionArgs>();
        @configure(@list);
        @selfRef.MatchConditions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs WithMatchConditions(this global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Cdn.Inputs.MatchConditionArgs>> @create)
    {
        @selfRef.MatchConditions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs WithName(this global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs WithPriority(this global::Pulumi.AzureNative.Cdn.Inputs.CustomRuleArgs @selfRef, global::System.Int32 priority)
    {
        @selfRef.Priority = priority;
        return @selfRef;
    }

}
