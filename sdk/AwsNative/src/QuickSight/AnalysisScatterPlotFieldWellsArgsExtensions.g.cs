// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisScatterPlotFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotFieldWellsArgs WithScatterPlotCategoricallyAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotFieldWellsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotCategoricallyAggregatedFieldWellsArgs scatterPlotCategoricallyAggregatedFieldWells)
    {
        @selfRef.ScatterPlotCategoricallyAggregatedFieldWells = scatterPlotCategoricallyAggregatedFieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotFieldWellsArgs WithScatterPlotCategoricallyAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotFieldWellsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotCategoricallyAggregatedFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotCategoricallyAggregatedFieldWellsArgs();
        @configure(@item);
        @selfRef.ScatterPlotCategoricallyAggregatedFieldWells = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotFieldWellsArgs WithScatterPlotUnaggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotFieldWellsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotUnaggregatedFieldWellsArgs scatterPlotUnaggregatedFieldWells)
    {
        @selfRef.ScatterPlotUnaggregatedFieldWells = scatterPlotUnaggregatedFieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotFieldWellsArgs WithScatterPlotUnaggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotFieldWellsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotUnaggregatedFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisScatterPlotUnaggregatedFieldWellsArgs();
        @configure(@item);
        @selfRef.ScatterPlotUnaggregatedFieldWells = @item;
        return @selfRef;
    }

}
