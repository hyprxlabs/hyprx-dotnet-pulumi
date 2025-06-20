// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardTreeMapConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithColorLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs colorLabelOptions)
    {
        @selfRef.ColorLabelOptions = colorLabelOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithColorLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs();
        @configure(@item);
        @selfRef.ColorLabelOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithColorScale(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardColorScaleArgs colorScale)
    {
        @selfRef.ColorScale = colorScale;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithColorScale(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardColorScaleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardColorScaleArgs();
        @configure(@item);
        @selfRef.ColorScale = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithDataLabels(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataLabelOptionsArgs dataLabels)
    {
        @selfRef.DataLabels = dataLabels;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithDataLabels(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataLabelOptionsArgs();
        @configure(@item);
        @selfRef.DataLabels = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapFieldWellsArgs fieldWells)
    {
        @selfRef.FieldWells = fieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapFieldWellsArgs();
        @configure(@item);
        @selfRef.FieldWells = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithGroupLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs groupLabelOptions)
    {
        @selfRef.GroupLabelOptions = groupLabelOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithGroupLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs();
        @configure(@item);
        @selfRef.GroupLabelOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualInteractionOptionsArgs interactions)
    {
        @selfRef.Interactions = interactions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualInteractionOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualInteractionOptionsArgs();
        @configure(@item);
        @selfRef.Interactions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithLegend(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLegendOptionsArgs legend)
    {
        @selfRef.Legend = legend;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithLegend(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLegendOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLegendOptionsArgs();
        @configure(@item);
        @selfRef.Legend = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithSizeLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs sizeLabelOptions)
    {
        @selfRef.SizeLabelOptions = sizeLabelOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithSizeLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardChartAxisLabelOptionsArgs();
        @configure(@item);
        @selfRef.SizeLabelOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithSortConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapSortConfigurationArgs sortConfiguration)
    {
        @selfRef.SortConfiguration = sortConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithSortConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapSortConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapSortConfigurationArgs();
        @configure(@item);
        @selfRef.SortConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithTooltip(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTooltipOptionsArgs tooltip)
    {
        @selfRef.Tooltip = tooltip;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs WithTooltip(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTreeMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTooltipOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTooltipOptionsArgs();
        @configure(@item);
        @selfRef.Tooltip = @item;
        return @selfRef;
    }

}
