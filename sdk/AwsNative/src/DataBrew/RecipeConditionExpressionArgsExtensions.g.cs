// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DataBrew.Inputs;

namespace Pulumi.AwsNative.DataBrew;

public static partial class RecipeConditionExpressionArgsExtensions
{
    public static global::Pulumi.AwsNative.DataBrew.Inputs.RecipeConditionExpressionArgs WithCondition(this global::Pulumi.AwsNative.DataBrew.Inputs.RecipeConditionExpressionArgs @selfRef, global::System.String condition)
    {
        @selfRef.Condition = condition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.Inputs.RecipeConditionExpressionArgs WithTargetColumn(this global::Pulumi.AwsNative.DataBrew.Inputs.RecipeConditionExpressionArgs @selfRef, global::System.String targetColumn)
    {
        @selfRef.TargetColumn = targetColumn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DataBrew.Inputs.RecipeConditionExpressionArgs WithValue(this global::Pulumi.AwsNative.DataBrew.Inputs.RecipeConditionExpressionArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
