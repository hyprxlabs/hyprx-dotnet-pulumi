// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardScatterPlotConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithDataLabels(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataLabelOptionsArgs dataLabels)
    {
        @selfRef.DataLabels = dataLabels;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithDataLabels(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataLabelOptionsArgs();
        @configure(@item);
        @selfRef.DataLabels = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotFieldWellsArgs fieldWells)
    {
        @selfRef.FieldWells = fieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotFieldWellsArgs();
        @configure(@item);
        @selfRef.FieldWells = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualInteractionOptionsArgs interactions)
    {
        @selfRef.Interactions = interactions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualInteractionOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualInteractionOptionsArgs();
        @configure(@item);
        @selfRef.Interactions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithLegend(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLegendOptionsArgs legend)
    {
        @selfRef.Legend = legend;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithLegend(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLegendOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLegendOptionsArgs();
        @configure(@item);
        @selfRef.Legend = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithSortConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotSortConfigurationArgs sortConfiguration)
    {
        @selfRef.SortConfiguration = sortConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithSortConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotSortConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotSortConfigurationArgs();
        @configure(@item);
        @selfRef.SortConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithTooltip(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTooltipOptionsArgs tooltip)
    {
        @selfRef.Tooltip = tooltip;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithTooltip(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTooltipOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTooltipOptionsArgs();
        @configure(@item);
        @selfRef.Tooltip = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithVisualPalette(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualPaletteArgs visualPalette)
    {
        @selfRef.VisualPalette = visualPalette;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithVisualPalette(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualPaletteArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualPaletteArgs();
        @configure(@item);
        @selfRef.VisualPalette = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithXAxisDisplayOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisDisplayOptionsArgs xAxisDisplayOptions)
    {
        @selfRef.XAxisDisplayOptions = xAxisDisplayOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithXAxisDisplayOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisDisplayOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisDisplayOptionsArgs();
        @configure(@item);
        @selfRef.XAxisDisplayOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithXAxisLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs xAxisLabelOptions)
    {
        @selfRef.XAxisLabelOptions = xAxisLabelOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithXAxisLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs();
        @configure(@item);
        @selfRef.XAxisLabelOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithYAxisDisplayOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisDisplayOptionsArgs yAxisDisplayOptions)
    {
        @selfRef.YAxisDisplayOptions = yAxisDisplayOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithYAxisDisplayOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisDisplayOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisDisplayOptionsArgs();
        @configure(@item);
        @selfRef.YAxisDisplayOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithYAxisLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs yAxisLabelOptions)
    {
        @selfRef.YAxisLabelOptions = yAxisLabelOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs WithYAxisLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs();
        @configure(@item);
        @selfRef.YAxisLabelOptions = @item;
        return @selfRef;
    }

}
