// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardLineChartFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLineChartFieldWellsArgs WithLineChartAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLineChartFieldWellsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLineChartAggregatedFieldWellsArgs lineChartAggregatedFieldWells)
    {
        @selfRef.LineChartAggregatedFieldWells = lineChartAggregatedFieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLineChartFieldWellsArgs WithLineChartAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLineChartFieldWellsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLineChartAggregatedFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardLineChartAggregatedFieldWellsArgs();
        @configure(@item);
        @selfRef.LineChartAggregatedFieldWells = @item;
        return @selfRef;
    }

}
