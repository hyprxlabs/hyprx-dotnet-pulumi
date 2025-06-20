// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateFilledMapConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapFieldWellsArgs fieldWells)
    {
        @selfRef.FieldWells = fieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapFieldWellsArgs();
        @configure(@item);
        @selfRef.FieldWells = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualInteractionOptionsArgs interactions)
    {
        @selfRef.Interactions = interactions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualInteractionOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualInteractionOptionsArgs();
        @configure(@item);
        @selfRef.Interactions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithLegend(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLegendOptionsArgs legend)
    {
        @selfRef.Legend = legend;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithLegend(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLegendOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLegendOptionsArgs();
        @configure(@item);
        @selfRef.Legend = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithMapStyleOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGeospatialMapStyleOptionsArgs mapStyleOptions)
    {
        @selfRef.MapStyleOptions = mapStyleOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithMapStyleOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGeospatialMapStyleOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGeospatialMapStyleOptionsArgs();
        @configure(@item);
        @selfRef.MapStyleOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithSortConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapSortConfigurationArgs sortConfiguration)
    {
        @selfRef.SortConfiguration = sortConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithSortConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapSortConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapSortConfigurationArgs();
        @configure(@item);
        @selfRef.SortConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithTooltip(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTooltipOptionsArgs tooltip)
    {
        @selfRef.Tooltip = tooltip;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithTooltip(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTooltipOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTooltipOptionsArgs();
        @configure(@item);
        @selfRef.Tooltip = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithWindowOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGeospatialWindowOptionsArgs windowOptions)
    {
        @selfRef.WindowOptions = windowOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs WithWindowOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilledMapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGeospatialWindowOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGeospatialWindowOptionsArgs();
        @configure(@item);
        @selfRef.WindowOptions = @item;
        return @selfRef;
    }

}
