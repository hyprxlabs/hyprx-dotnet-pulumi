// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateLineChartSeriesSettingsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartSeriesSettingsArgs WithLineStyleSettings(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartSeriesSettingsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs lineStyleSettings)
    {
        @selfRef.LineStyleSettings = lineStyleSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartSeriesSettingsArgs WithLineStyleSettings(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartSeriesSettingsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartLineStyleSettingsArgs();
        @configure(@item);
        @selfRef.LineStyleSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartSeriesSettingsArgs WithMarkerStyleSettings(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartSeriesSettingsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartMarkerStyleSettingsArgs markerStyleSettings)
    {
        @selfRef.MarkerStyleSettings = markerStyleSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartSeriesSettingsArgs WithMarkerStyleSettings(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartSeriesSettingsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartMarkerStyleSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLineChartMarkerStyleSettingsArgs();
        @configure(@item);
        @selfRef.MarkerStyleSettings = @item;
        return @selfRef;
    }

}
