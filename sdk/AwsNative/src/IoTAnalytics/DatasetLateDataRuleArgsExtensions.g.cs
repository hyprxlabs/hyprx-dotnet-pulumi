// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTAnalytics.Inputs;

namespace Pulumi.AwsNative.IoTAnalytics;

public static partial class DatasetLateDataRuleArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleArgs WithRuleConfiguration(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleArgs @selfRef, global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleConfigurationArgs ruleConfiguration)
    {
        @selfRef.RuleConfiguration = ruleConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleArgs WithRuleConfiguration(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleConfigurationArgs();
        @configure(@item);
        @selfRef.RuleConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleArgs WithRuleName(this global::Pulumi.AwsNative.IoTAnalytics.Inputs.DatasetLateDataRuleArgs @selfRef, global::System.String ruleName)
    {
        @selfRef.RuleName = ruleName;
        return @selfRef;
    }

}
