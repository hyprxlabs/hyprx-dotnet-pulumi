// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisFunnelChartFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFunnelChartFieldWellsArgs WithFunnelChartAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFunnelChartFieldWellsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFunnelChartAggregatedFieldWellsArgs funnelChartAggregatedFieldWells)
    {
        @selfRef.FunnelChartAggregatedFieldWells = funnelChartAggregatedFieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFunnelChartFieldWellsArgs WithFunnelChartAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFunnelChartFieldWellsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFunnelChartAggregatedFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFunnelChartAggregatedFieldWellsArgs();
        @configure(@item);
        @selfRef.FunnelChartAggregatedFieldWells = @item;
        return @selfRef;
    }

}
