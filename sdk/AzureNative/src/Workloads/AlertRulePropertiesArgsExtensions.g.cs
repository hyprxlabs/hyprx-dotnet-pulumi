// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Workloads.Inputs;

namespace Pulumi.AzureNative.Workloads;

public static partial class AlertRulePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithActionGroups(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> actionGroups)
    {
        @selfRef.ActionGroups = actionGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithActionGroups(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ActionGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithActionGroups(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ActionGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithAlertQueryParameters(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Workloads.Inputs.AlertQueryParameterArgs> alertQueryParameters)
    {
        @selfRef.AlertQueryParameters = alertQueryParameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithAlertQueryParameters(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Workloads.Inputs.AlertQueryParameterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Workloads.Inputs.AlertQueryParameterArgs>();
        @configure(@list);
        @selfRef.AlertQueryParameters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithAlertQueryParameters(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Workloads.Inputs.AlertQueryParameterArgs>> @create)
    {
        @selfRef.AlertQueryParameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithAutoMitigate(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Workloads.AlertAutoMitigate> autoMitigate)
    {
        @selfRef.AutoMitigate = autoMitigate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithDimension(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.String dimension)
    {
        @selfRef.Dimension = dimension;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithEvaluationFrequency(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.Int32 evaluationFrequency)
    {
        @selfRef.EvaluationFrequency = evaluationFrequency;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithFailingPeriodsOperator(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Workloads.ConditionalOperator> failingPeriodsOperator)
    {
        @selfRef.FailingPeriodsOperator = failingPeriodsOperator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithFailingPeriodsToAlert(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.Int32 failingPeriodsToAlert)
    {
        @selfRef.FailingPeriodsToAlert = failingPeriodsToAlert;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithMuteActionsDuration(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.Int32 muteActionsDuration)
    {
        @selfRef.MuteActionsDuration = muteActionsDuration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithSeverity(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.Int32 severity)
    {
        @selfRef.Severity = severity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithStatus(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Workloads.AlertRuleStatus> status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithThreshold(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.Int32 threshold)
    {
        @selfRef.Threshold = threshold;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithThresholdOperator(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Workloads.ConditionalOperator> thresholdOperator)
    {
        @selfRef.ThresholdOperator = thresholdOperator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs WithWindowSize(this global::Pulumi.AzureNative.Workloads.Inputs.AlertRulePropertiesArgs @selfRef, global::System.Int32 windowSize)
    {
        @selfRef.WindowSize = windowSize;
        return @selfRef;
    }

}
