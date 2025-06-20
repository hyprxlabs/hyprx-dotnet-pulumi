// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Cdn.Inputs;

namespace Pulumi.AzureNative.Cdn;

public static partial class CookiesMatchConditionParametersArgsExtensions
{
    public static global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs WithMatchValues(this global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs @selfRef, global::System.Collections.Generic.List<global::System.String> matchValues)
    {
        @selfRef.MatchValues = matchValues;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs WithMatchValues(this global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.MatchValues = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs WithMatchValues(this global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.MatchValues = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs WithNegateCondition(this global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs @selfRef, bool negateCondition = true)
    {
        @selfRef.NegateCondition = negateCondition;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs WithOperator(this global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.CookiesOperator> @operator)
    {
        @selfRef.Operator = @operator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs WithSelector(this global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs @selfRef, global::System.String selector)
    {
        @selfRef.Selector = selector;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs WithTransforms(this global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.Transform>> transforms)
    {
        @selfRef.Transforms = transforms;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs WithTransforms(this global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.Transform>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.Transform>>();
        @configure(@list);
        @selfRef.Transforms = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs WithTransforms(this global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.Transform>>> @create)
    {
        @selfRef.Transforms = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs WithTypeName(this global::Pulumi.AzureNative.Cdn.Inputs.CookiesMatchConditionParametersArgs @selfRef, global::System.String typeName)
    {
        @selfRef.TypeName = typeName;
        return @selfRef;
    }

}
