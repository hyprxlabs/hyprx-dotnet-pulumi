// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SecurityInsights.Inputs;

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class AutomationRulePropertyArrayChangedValuesConditionArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayChangedValuesConditionArgs WithArrayType(this global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayChangedValuesConditionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SecurityInsights.AutomationRulePropertyArrayChangedConditionSupportedArrayType> arrayType)
    {
        @selfRef.ArrayType = arrayType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayChangedValuesConditionArgs WithChangeType(this global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayChangedValuesConditionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SecurityInsights.AutomationRulePropertyArrayChangedConditionSupportedChangeType> changeType)
    {
        @selfRef.ChangeType = changeType;
        return @selfRef;
    }

}
