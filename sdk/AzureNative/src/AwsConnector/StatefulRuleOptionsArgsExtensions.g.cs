// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class StatefulRuleOptionsArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.StatefulRuleOptionsArgs WithRuleOrder(this global::Pulumi.AzureNative.AwsConnector.Inputs.StatefulRuleOptionsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AwsConnector.StatefulRuleOptionsRuleOrder> ruleOrder)
    {
        @selfRef.RuleOrder = ruleOrder;
        return @selfRef;
    }

}
