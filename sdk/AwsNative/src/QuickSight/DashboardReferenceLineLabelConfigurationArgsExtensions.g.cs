// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardReferenceLineLabelConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs WithCustomLabelConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineCustomLabelConfigurationArgs customLabelConfiguration)
    {
        @selfRef.CustomLabelConfiguration = customLabelConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs WithCustomLabelConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineCustomLabelConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineCustomLabelConfigurationArgs();
        @configure(@item);
        @selfRef.CustomLabelConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs WithFontColor(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs @selfRef, global::System.String fontColor)
    {
        @selfRef.FontColor = fontColor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs WithFontConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFontConfigurationArgs fontConfiguration)
    {
        @selfRef.FontConfiguration = fontConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs WithFontConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFontConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFontConfigurationArgs();
        @configure(@item);
        @selfRef.FontConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs WithHorizontalPosition(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardReferenceLineLabelHorizontalPosition horizontalPosition)
    {
        @selfRef.HorizontalPosition = horizontalPosition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs WithHorizontalPosition(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardReferenceLineLabelHorizontalPosition> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardReferenceLineLabelHorizontalPosition>();
        @configure(@item);
        @selfRef.HorizontalPosition = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs WithValueLabelConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineValueLabelConfigurationArgs valueLabelConfiguration)
    {
        @selfRef.ValueLabelConfiguration = valueLabelConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs WithValueLabelConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineValueLabelConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineValueLabelConfigurationArgs();
        @configure(@item);
        @selfRef.ValueLabelConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs WithVerticalPosition(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardReferenceLineLabelVerticalPosition verticalPosition)
    {
        @selfRef.VerticalPosition = verticalPosition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs WithVerticalPosition(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardReferenceLineLabelVerticalPosition> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardReferenceLineLabelVerticalPosition>();
        @configure(@item);
        @selfRef.VerticalPosition = @item;
        return @selfRef;
    }

}
