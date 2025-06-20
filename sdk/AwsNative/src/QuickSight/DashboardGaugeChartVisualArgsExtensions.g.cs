// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardGaugeChartVisualArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualCustomActionArgs> actions)
    {
        @selfRef.Actions = actions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualCustomActionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualCustomActionArgs>();
        @configure(@list);
        @selfRef.Actions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualCustomActionArgs>> @create)
    {
        @selfRef.Actions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithChartConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartConfigurationArgs chartConfiguration)
    {
        @selfRef.ChartConfiguration = chartConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithChartConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartConfigurationArgs();
        @configure(@item);
        @selfRef.ChartConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithConditionalFormatting(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartConditionalFormattingArgs conditionalFormatting)
    {
        @selfRef.ConditionalFormatting = conditionalFormatting;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithConditionalFormatting(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartConditionalFormattingArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartConditionalFormattingArgs();
        @configure(@item);
        @selfRef.ConditionalFormatting = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithSubtitle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualSubtitleLabelOptionsArgs subtitle)
    {
        @selfRef.Subtitle = subtitle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithSubtitle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualSubtitleLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualSubtitleLabelOptionsArgs();
        @configure(@item);
        @selfRef.Subtitle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithTitle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualTitleLabelOptionsArgs title)
    {
        @selfRef.Title = title;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithTitle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualTitleLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualTitleLabelOptionsArgs();
        @configure(@item);
        @selfRef.Title = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithVisualContentAltText(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::System.String visualContentAltText)
    {
        @selfRef.VisualContentAltText = visualContentAltText;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs WithVisualId(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGaugeChartVisualArgs @selfRef, global::System.String visualId)
    {
        @selfRef.VisualId = visualId;
        return @selfRef;
    }

}
