// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Cdn.Inputs;

namespace Pulumi.AzureNative.Cdn;

public static partial class DeliveryRuleRequestUriConditionArgsExtensions
{
    public static global::Pulumi.AzureNative.Cdn.Inputs.DeliveryRuleRequestUriConditionArgs WithName(this global::Pulumi.AzureNative.Cdn.Inputs.DeliveryRuleRequestUriConditionArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.DeliveryRuleRequestUriConditionArgs WithParameters(this global::Pulumi.AzureNative.Cdn.Inputs.DeliveryRuleRequestUriConditionArgs @selfRef, global::Pulumi.AzureNative.Cdn.Inputs.RequestUriMatchConditionParametersArgs parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.DeliveryRuleRequestUriConditionArgs WithParameters(this global::Pulumi.AzureNative.Cdn.Inputs.DeliveryRuleRequestUriConditionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Cdn.Inputs.RequestUriMatchConditionParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Cdn.Inputs.RequestUriMatchConditionParametersArgs();
        @configure(@item);
        @selfRef.Parameters = @item;
        return @selfRef;
    }

}
