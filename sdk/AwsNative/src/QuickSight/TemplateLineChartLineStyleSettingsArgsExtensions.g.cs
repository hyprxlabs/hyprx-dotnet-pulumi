// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateLineChartLineStyleSettingsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs WithLineInterpolation(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateLineInterpolation lineInterpolation)
    {
        @selfRef.LineInterpolation = lineInterpolation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs WithLineInterpolation(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateLineInterpolation> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateLineInterpolation>();
        @configure(@item);
        @selfRef.LineInterpolation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs WithLineStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateLineChartLineStyle lineStyle)
    {
        @selfRef.LineStyle = lineStyle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs WithLineStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateLineChartLineStyle> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateLineChartLineStyle>();
        @configure(@item);
        @selfRef.LineStyle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs WithLineVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs @selfRef, global::System.Object lineVisibility)
    {
        @selfRef.LineVisibility = lineVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs WithLineVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.LineVisibility = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs WithLineWidth(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs @selfRef, global::System.String lineWidth)
    {
        @selfRef.LineWidth = lineWidth;
        return @selfRef;
    }

}
