// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SecurityInsights.Inputs;

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class AutomationRulePropertyArrayValuesConditionArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayValuesConditionArgs WithArrayConditionType(this global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayValuesConditionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SecurityInsights.AutomationRulePropertyArrayConditionSupportedArrayConditionType> arrayConditionType)
    {
        @selfRef.ArrayConditionType = arrayConditionType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayValuesConditionArgs WithArrayType(this global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayValuesConditionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SecurityInsights.AutomationRulePropertyArrayConditionSupportedArrayType> arrayType)
    {
        @selfRef.ArrayType = arrayType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayValuesConditionArgs WithItemConditions(this global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayValuesConditionArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> itemConditions)
    {
        @selfRef.ItemConditions = itemConditions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayValuesConditionArgs WithItemConditions(this global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayValuesConditionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.ItemConditions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayValuesConditionArgs WithItemConditions(this global::Pulumi.AzureNative.SecurityInsights.Inputs.AutomationRulePropertyArrayValuesConditionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.ItemConditions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
