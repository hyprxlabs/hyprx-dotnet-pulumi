// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateConditionalFormattingGradientColorArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateConditionalFormattingGradientColorArgs WithColor(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateConditionalFormattingGradientColorArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGradientColorArgs color)
    {
        @selfRef.Color = color;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateConditionalFormattingGradientColorArgs WithColor(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateConditionalFormattingGradientColorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGradientColorArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGradientColorArgs();
        @configure(@item);
        @selfRef.Color = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateConditionalFormattingGradientColorArgs WithExpression(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateConditionalFormattingGradientColorArgs @selfRef, global::System.String expression)
    {
        @selfRef.Expression = expression;
        return @selfRef;
    }

}
