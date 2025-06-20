// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Cdn.Inputs;

namespace Pulumi.AzureNative.Cdn;

public static partial class HttpVersionMatchConditionParametersArgsExtensions
{
    public static global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs WithMatchValues(this global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs @selfRef, global::System.Collections.Generic.List<global::System.String> matchValues)
    {
        @selfRef.MatchValues = matchValues;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs WithMatchValues(this global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.MatchValues = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs WithMatchValues(this global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.MatchValues = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs WithNegateCondition(this global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs @selfRef, bool negateCondition = true)
    {
        @selfRef.NegateCondition = negateCondition;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs WithOperator(this global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.HttpVersionOperator> @operator)
    {
        @selfRef.Operator = @operator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs WithTransforms(this global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.Transform>> transforms)
    {
        @selfRef.Transforms = transforms;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs WithTransforms(this global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.Transform>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.Transform>>();
        @configure(@list);
        @selfRef.Transforms = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs WithTransforms(this global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cdn.Transform>>> @create)
    {
        @selfRef.Transforms = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs WithTypeName(this global::Pulumi.AzureNative.Cdn.Inputs.HttpVersionMatchConditionParametersArgs @selfRef, global::System.String typeName)
    {
        @selfRef.TypeName = typeName;
        return @selfRef;
    }

}
