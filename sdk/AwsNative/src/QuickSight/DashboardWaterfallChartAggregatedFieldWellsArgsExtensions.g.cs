// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardWaterfallChartAggregatedFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs WithBreakdowns(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDimensionFieldArgs> breakdowns)
    {
        @selfRef.Breakdowns = breakdowns;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs WithBreakdowns(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDimensionFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDimensionFieldArgs>();
        @configure(@list);
        @selfRef.Breakdowns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs WithBreakdowns(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDimensionFieldArgs>> @create)
    {
        @selfRef.Breakdowns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs WithCategories(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDimensionFieldArgs> categories)
    {
        @selfRef.Categories = categories;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs WithCategories(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDimensionFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDimensionFieldArgs>();
        @configure(@list);
        @selfRef.Categories = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs WithCategories(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDimensionFieldArgs>> @create)
    {
        @selfRef.Categories = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardMeasureFieldArgs> values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardMeasureFieldArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardMeasureFieldArgs>();
        @configure(@list);
        @selfRef.Values = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs WithValues(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartAggregatedFieldWellsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardMeasureFieldArgs>> @create)
    {
        @selfRef.Values = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
