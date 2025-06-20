// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateGaugeChartVisualArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualCustomActionArgs> actions)
    {
        @selfRef.Actions = actions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualCustomActionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualCustomActionArgs>();
        @configure(@list);
        @selfRef.Actions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualCustomActionArgs>> @create)
    {
        @selfRef.Actions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithChartConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartConfigurationArgs chartConfiguration)
    {
        @selfRef.ChartConfiguration = chartConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithChartConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartConfigurationArgs();
        @configure(@item);
        @selfRef.ChartConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithConditionalFormatting(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartConditionalFormattingArgs conditionalFormatting)
    {
        @selfRef.ConditionalFormatting = conditionalFormatting;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithConditionalFormatting(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartConditionalFormattingArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartConditionalFormattingArgs();
        @configure(@item);
        @selfRef.ConditionalFormatting = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithSubtitle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualSubtitleLabelOptionsArgs subtitle)
    {
        @selfRef.Subtitle = subtitle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithSubtitle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualSubtitleLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualSubtitleLabelOptionsArgs();
        @configure(@item);
        @selfRef.Subtitle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithTitle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualTitleLabelOptionsArgs title)
    {
        @selfRef.Title = title;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithTitle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualTitleLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualTitleLabelOptionsArgs();
        @configure(@item);
        @selfRef.Title = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithVisualContentAltText(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::System.String visualContentAltText)
    {
        @selfRef.VisualContentAltText = visualContentAltText;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs WithVisualId(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateGaugeChartVisualArgs @selfRef, global::System.String visualId)
    {
        @selfRef.VisualId = visualId;
        return @selfRef;
    }

}
