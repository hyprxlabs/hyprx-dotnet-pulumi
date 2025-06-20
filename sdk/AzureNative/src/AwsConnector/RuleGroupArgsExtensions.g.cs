// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class RuleGroupArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs WithReferenceSets(this global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ReferenceSetsArgs referenceSets)
    {
        @selfRef.ReferenceSets = referenceSets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs WithReferenceSets(this global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ReferenceSetsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ReferenceSetsArgs();
        @configure(@item);
        @selfRef.ReferenceSets = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs WithRuleVariables(this global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.RuleVariablesArgs ruleVariables)
    {
        @selfRef.RuleVariables = ruleVariables;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs WithRuleVariables(this global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.RuleVariablesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.RuleVariablesArgs();
        @configure(@item);
        @selfRef.RuleVariables = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs WithRulesSource(this global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.RulesSourceArgs rulesSource)
    {
        @selfRef.RulesSource = rulesSource;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs WithRulesSource(this global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.RulesSourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.RulesSourceArgs();
        @configure(@item);
        @selfRef.RulesSource = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs WithStatefulRuleOptions(this global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.StatefulRuleOptionsArgs statefulRuleOptions)
    {
        @selfRef.StatefulRuleOptions = statefulRuleOptions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs WithStatefulRuleOptions(this global::Pulumi.AzureNative.AwsConnector.Inputs.RuleGroupArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.StatefulRuleOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.StatefulRuleOptionsArgs();
        @configure(@item);
        @selfRef.StatefulRuleOptions = @item;
        return @selfRef;
    }

}
