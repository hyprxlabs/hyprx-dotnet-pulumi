// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplatePivotTotalOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithCustomLabel(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::System.String customLabel)
    {
        @selfRef.CustomLabel = customLabel;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithMetricHeaderCellStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableCellStyleArgs metricHeaderCellStyle)
    {
        @selfRef.MetricHeaderCellStyle = metricHeaderCellStyle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithMetricHeaderCellStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableCellStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableCellStyleArgs();
        @configure(@item);
        @selfRef.MetricHeaderCellStyle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithPlacement(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateTableTotalsPlacement placement)
    {
        @selfRef.Placement = placement;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithPlacement(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateTableTotalsPlacement> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateTableTotalsPlacement>();
        @configure(@item);
        @selfRef.Placement = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithScrollStatus(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateTableTotalsScrollStatus scrollStatus)
    {
        @selfRef.ScrollStatus = scrollStatus;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithScrollStatus(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateTableTotalsScrollStatus> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateTableTotalsScrollStatus>();
        @configure(@item);
        @selfRef.ScrollStatus = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithTotalAggregationOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTotalAggregationOptionArgs> totalAggregationOptions)
    {
        @selfRef.TotalAggregationOptions = totalAggregationOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithTotalAggregationOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTotalAggregationOptionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTotalAggregationOptionArgs>();
        @configure(@list);
        @selfRef.TotalAggregationOptions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithTotalAggregationOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTotalAggregationOptionArgs>> @create)
    {
        @selfRef.TotalAggregationOptions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithTotalCellStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableCellStyleArgs totalCellStyle)
    {
        @selfRef.TotalCellStyle = totalCellStyle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithTotalCellStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableCellStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableCellStyleArgs();
        @configure(@item);
        @selfRef.TotalCellStyle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithTotalsVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::System.Object totalsVisibility)
    {
        @selfRef.TotalsVisibility = totalsVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithTotalsVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.TotalsVisibility = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithValueCellStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableCellStyleArgs valueCellStyle)
    {
        @selfRef.ValueCellStyle = valueCellStyle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs WithValueCellStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTotalOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableCellStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateTableCellStyleArgs();
        @configure(@item);
        @selfRef.ValueCellStyle = @item;
        return @selfRef;
    }

}
