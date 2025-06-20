// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AlertsManagement.Inputs;

namespace Pulumi.AzureNative.AlertsManagement;

public static partial class AlertProcessingRulePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithActions(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.AlertsManagement.Inputs.AddActionGroupsArgs, global::Pulumi.AzureNative.AlertsManagement.Inputs.RemoveAllActionGroupsArgs>> actions)
    {
        @selfRef.Actions = actions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithActions(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.AlertsManagement.Inputs.AddActionGroupsArgs, global::Pulumi.AzureNative.AlertsManagement.Inputs.RemoveAllActionGroupsArgs>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::Pulumi.AzureNative.AlertsManagement.Inputs.AddActionGroupsArgs, global::Pulumi.AzureNative.AlertsManagement.Inputs.RemoveAllActionGroupsArgs>>();
        @configure(@list);
        @selfRef.Actions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithActions(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::Pulumi.AzureNative.AlertsManagement.Inputs.AddActionGroupsArgs, global::Pulumi.AzureNative.AlertsManagement.Inputs.RemoveAllActionGroupsArgs>>> @create)
    {
        @selfRef.Actions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithConditions(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AlertsManagement.Inputs.ConditionArgs> conditions)
    {
        @selfRef.Conditions = conditions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithConditions(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AlertsManagement.Inputs.ConditionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AlertsManagement.Inputs.ConditionArgs>();
        @configure(@list);
        @selfRef.Conditions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithConditions(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AlertsManagement.Inputs.ConditionArgs>> @create)
    {
        @selfRef.Conditions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithDescription(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithEnabled(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithSchedule(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, global::Pulumi.AzureNative.AlertsManagement.Inputs.ScheduleArgs schedule)
    {
        @selfRef.Schedule = schedule;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithSchedule(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AlertsManagement.Inputs.ScheduleArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AlertsManagement.Inputs.ScheduleArgs();
        @configure(@item);
        @selfRef.Schedule = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithScopes(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> scopes)
    {
        @selfRef.Scopes = scopes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithScopes(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Scopes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs WithScopes(this global::Pulumi.AzureNative.AlertsManagement.Inputs.AlertProcessingRulePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Scopes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
