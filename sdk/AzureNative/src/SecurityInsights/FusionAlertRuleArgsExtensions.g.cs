// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class FusionAlertRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs WithAlertRuleTemplateName(this global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs @selfRef, global::System.String alertRuleTemplateName)
    {
        @selfRef.AlertRuleTemplateName = alertRuleTemplateName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs WithEnabled(this global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs WithKind(this global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs WithResourceGroupName(this global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs WithRuleId(this global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs @selfRef, global::System.String ruleId)
    {
        @selfRef.RuleId = ruleId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs WithWorkspaceName(this global::Pulumi.AzureNative.SecurityInsights.FusionAlertRuleArgs @selfRef, global::System.String workspaceName)
    {
        @selfRef.WorkspaceName = workspaceName;
        return @selfRef;
    }

}
