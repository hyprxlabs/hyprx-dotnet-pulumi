// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardRadarChartFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardRadarChartFieldWellsArgs WithRadarChartAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardRadarChartFieldWellsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardRadarChartAggregatedFieldWellsArgs radarChartAggregatedFieldWells)
    {
        @selfRef.RadarChartAggregatedFieldWells = radarChartAggregatedFieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardRadarChartFieldWellsArgs WithRadarChartAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardRadarChartFieldWellsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardRadarChartAggregatedFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardRadarChartAggregatedFieldWellsArgs();
        @configure(@item);
        @selfRef.RadarChartAggregatedFieldWells = @item;
        return @selfRef;
    }

}
