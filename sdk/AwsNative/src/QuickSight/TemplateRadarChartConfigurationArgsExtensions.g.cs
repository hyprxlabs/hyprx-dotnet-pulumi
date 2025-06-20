// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateRadarChartConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithAlternateBandColorsVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Object alternateBandColorsVisibility)
    {
        @selfRef.AlternateBandColorsVisibility = alternateBandColorsVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithAlternateBandColorsVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.AlternateBandColorsVisibility = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithAlternateBandEvenColor(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.String alternateBandEvenColor)
    {
        @selfRef.AlternateBandEvenColor = alternateBandEvenColor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithAlternateBandOddColor(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.String alternateBandOddColor)
    {
        @selfRef.AlternateBandOddColor = alternateBandOddColor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithAxesRangeScale(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateRadarChartAxesRangeScale axesRangeScale)
    {
        @selfRef.AxesRangeScale = axesRangeScale;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithAxesRangeScale(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateRadarChartAxesRangeScale> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateRadarChartAxesRangeScale>();
        @configure(@item);
        @selfRef.AxesRangeScale = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithBaseSeriesSettings(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartSeriesSettingsArgs baseSeriesSettings)
    {
        @selfRef.BaseSeriesSettings = baseSeriesSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithBaseSeriesSettings(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartSeriesSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartSeriesSettingsArgs();
        @configure(@item);
        @selfRef.BaseSeriesSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithCategoryAxis(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisDisplayOptionsArgs categoryAxis)
    {
        @selfRef.CategoryAxis = categoryAxis;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithCategoryAxis(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisDisplayOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisDisplayOptionsArgs();
        @configure(@item);
        @selfRef.CategoryAxis = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithCategoryLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateChartAxisLabelOptionsArgs categoryLabelOptions)
    {
        @selfRef.CategoryLabelOptions = categoryLabelOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithCategoryLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateChartAxisLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateChartAxisLabelOptionsArgs();
        @configure(@item);
        @selfRef.CategoryLabelOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithColorAxis(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisDisplayOptionsArgs colorAxis)
    {
        @selfRef.ColorAxis = colorAxis;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithColorAxis(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisDisplayOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateAxisDisplayOptionsArgs();
        @configure(@item);
        @selfRef.ColorAxis = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithColorLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateChartAxisLabelOptionsArgs colorLabelOptions)
    {
        @selfRef.ColorLabelOptions = colorLabelOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithColorLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateChartAxisLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateChartAxisLabelOptionsArgs();
        @configure(@item);
        @selfRef.ColorLabelOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartFieldWellsArgs fieldWells)
    {
        @selfRef.FieldWells = fieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartFieldWellsArgs();
        @configure(@item);
        @selfRef.FieldWells = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualInteractionOptionsArgs interactions)
    {
        @selfRef.Interactions = interactions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualInteractionOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualInteractionOptionsArgs();
        @configure(@item);
        @selfRef.Interactions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithLegend(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLegendOptionsArgs legend)
    {
        @selfRef.Legend = legend;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithLegend(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLegendOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLegendOptionsArgs();
        @configure(@item);
        @selfRef.Legend = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithShape(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateRadarChartShape shape)
    {
        @selfRef.Shape = shape;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithShape(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateRadarChartShape> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateRadarChartShape>();
        @configure(@item);
        @selfRef.Shape = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithSortConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartSortConfigurationArgs sortConfiguration)
    {
        @selfRef.SortConfiguration = sortConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithSortConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartSortConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartSortConfigurationArgs();
        @configure(@item);
        @selfRef.SortConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithStartAngle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Double startAngle)
    {
        @selfRef.StartAngle = startAngle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithVisualPalette(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualPaletteArgs visualPalette)
    {
        @selfRef.VisualPalette = visualPalette;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs WithVisualPalette(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualPaletteArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualPaletteArgs();
        @configure(@item);
        @selfRef.VisualPalette = @item;
        return @selfRef;
    }

}
