// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateFunnelChartDataLabelOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithCategoryLabelVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::System.Object categoryLabelVisibility)
    {
        @selfRef.CategoryLabelVisibility = categoryLabelVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithCategoryLabelVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.CategoryLabelVisibility = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithLabelColor(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::System.String labelColor)
    {
        @selfRef.LabelColor = labelColor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithLabelFontConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFontConfigurationArgs labelFontConfiguration)
    {
        @selfRef.LabelFontConfiguration = labelFontConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithLabelFontConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFontConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFontConfigurationArgs();
        @configure(@item);
        @selfRef.LabelFontConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithMeasureDataLabelStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateFunnelChartMeasureDataLabelStyle measureDataLabelStyle)
    {
        @selfRef.MeasureDataLabelStyle = measureDataLabelStyle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithMeasureDataLabelStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateFunnelChartMeasureDataLabelStyle> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateFunnelChartMeasureDataLabelStyle>();
        @configure(@item);
        @selfRef.MeasureDataLabelStyle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithMeasureLabelVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::System.Object measureLabelVisibility)
    {
        @selfRef.MeasureLabelVisibility = measureLabelVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithMeasureLabelVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MeasureLabelVisibility = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithPosition(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateDataLabelPosition position)
    {
        @selfRef.Position = position;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithPosition(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateDataLabelPosition> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateDataLabelPosition>();
        @configure(@item);
        @selfRef.Position = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::System.Object visibility)
    {
        @selfRef.Visibility = visibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs WithVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartDataLabelOptionsArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Visibility = @item;
        return @selfRef;
    }

}
