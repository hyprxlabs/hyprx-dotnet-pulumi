// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisWaterfallChartConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithCategoryAxisDisplayOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAxisDisplayOptionsArgs categoryAxisDisplayOptions)
    {
        @selfRef.CategoryAxisDisplayOptions = categoryAxisDisplayOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithCategoryAxisDisplayOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAxisDisplayOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAxisDisplayOptionsArgs();
        @configure(@item);
        @selfRef.CategoryAxisDisplayOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithCategoryAxisLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisChartAxisLabelOptionsArgs categoryAxisLabelOptions)
    {
        @selfRef.CategoryAxisLabelOptions = categoryAxisLabelOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithCategoryAxisLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisChartAxisLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisChartAxisLabelOptionsArgs();
        @configure(@item);
        @selfRef.CategoryAxisLabelOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithColorConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartColorConfigurationArgs colorConfiguration)
    {
        @selfRef.ColorConfiguration = colorConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithColorConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartColorConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartColorConfigurationArgs();
        @configure(@item);
        @selfRef.ColorConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithDataLabels(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataLabelOptionsArgs dataLabels)
    {
        @selfRef.DataLabels = dataLabels;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithDataLabels(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataLabelOptionsArgs();
        @configure(@item);
        @selfRef.DataLabels = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartFieldWellsArgs fieldWells)
    {
        @selfRef.FieldWells = fieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartFieldWellsArgs();
        @configure(@item);
        @selfRef.FieldWells = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs interactions)
    {
        @selfRef.Interactions = interactions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs();
        @configure(@item);
        @selfRef.Interactions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithLegend(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLegendOptionsArgs legend)
    {
        @selfRef.Legend = legend;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithLegend(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLegendOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLegendOptionsArgs();
        @configure(@item);
        @selfRef.Legend = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithPrimaryYAxisDisplayOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAxisDisplayOptionsArgs primaryYAxisDisplayOptions)
    {
        @selfRef.PrimaryYAxisDisplayOptions = primaryYAxisDisplayOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithPrimaryYAxisDisplayOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAxisDisplayOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisAxisDisplayOptionsArgs();
        @configure(@item);
        @selfRef.PrimaryYAxisDisplayOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithPrimaryYAxisLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisChartAxisLabelOptionsArgs primaryYAxisLabelOptions)
    {
        @selfRef.PrimaryYAxisLabelOptions = primaryYAxisLabelOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithPrimaryYAxisLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisChartAxisLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisChartAxisLabelOptionsArgs();
        @configure(@item);
        @selfRef.PrimaryYAxisLabelOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithSortConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartSortConfigurationArgs sortConfiguration)
    {
        @selfRef.SortConfiguration = sortConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithSortConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartSortConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartSortConfigurationArgs();
        @configure(@item);
        @selfRef.SortConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithVisualPalette(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualPaletteArgs visualPalette)
    {
        @selfRef.VisualPalette = visualPalette;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithVisualPalette(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualPaletteArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualPaletteArgs();
        @configure(@item);
        @selfRef.VisualPalette = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithWaterfallChartOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartOptionsArgs waterfallChartOptions)
    {
        @selfRef.WaterfallChartOptions = waterfallChartOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs WithWaterfallChartOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWaterfallChartOptionsArgs();
        @configure(@item);
        @selfRef.WaterfallChartOptions = @item;
        return @selfRef;
    }

}
