// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateReferenceLineLabelConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs WithCustomLabelConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineCustomLabelConfigurationArgs customLabelConfiguration)
    {
        @selfRef.CustomLabelConfiguration = customLabelConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs WithCustomLabelConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineCustomLabelConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineCustomLabelConfigurationArgs();
        @configure(@item);
        @selfRef.CustomLabelConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs WithFontColor(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs @selfRef, global::System.String fontColor)
    {
        @selfRef.FontColor = fontColor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs WithFontConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFontConfigurationArgs fontConfiguration)
    {
        @selfRef.FontConfiguration = fontConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs WithFontConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFontConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFontConfigurationArgs();
        @configure(@item);
        @selfRef.FontConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs WithHorizontalPosition(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateReferenceLineLabelHorizontalPosition horizontalPosition)
    {
        @selfRef.HorizontalPosition = horizontalPosition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs WithHorizontalPosition(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateReferenceLineLabelHorizontalPosition> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateReferenceLineLabelHorizontalPosition>();
        @configure(@item);
        @selfRef.HorizontalPosition = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs WithValueLabelConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineValueLabelConfigurationArgs valueLabelConfiguration)
    {
        @selfRef.ValueLabelConfiguration = valueLabelConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs WithValueLabelConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineValueLabelConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineValueLabelConfigurationArgs();
        @configure(@item);
        @selfRef.ValueLabelConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs WithVerticalPosition(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateReferenceLineLabelVerticalPosition verticalPosition)
    {
        @selfRef.VerticalPosition = verticalPosition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs WithVerticalPosition(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateReferenceLineLabelVerticalPosition> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateReferenceLineLabelVerticalPosition>();
        @configure(@item);
        @selfRef.VerticalPosition = @item;
        return @selfRef;
    }

}
