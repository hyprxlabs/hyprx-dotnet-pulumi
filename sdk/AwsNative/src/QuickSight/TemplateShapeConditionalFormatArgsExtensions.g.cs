// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateShapeConditionalFormatArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateShapeConditionalFormatArgs WithBackgroundColor(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateShapeConditionalFormatArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateConditionalFormattingColorArgs backgroundColor)
    {
        @selfRef.BackgroundColor = backgroundColor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateShapeConditionalFormatArgs WithBackgroundColor(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateShapeConditionalFormatArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateConditionalFormattingColorArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateConditionalFormattingColorArgs();
        @configure(@item);
        @selfRef.BackgroundColor = @item;
        return @selfRef;
    }

}
