// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisWordCloudFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWordCloudFieldWellsArgs WithWordCloudAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWordCloudFieldWellsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWordCloudAggregatedFieldWellsArgs wordCloudAggregatedFieldWells)
    {
        @selfRef.WordCloudAggregatedFieldWells = wordCloudAggregatedFieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWordCloudFieldWellsArgs WithWordCloudAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWordCloudFieldWellsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWordCloudAggregatedFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisWordCloudAggregatedFieldWellsArgs();
        @configure(@item);
        @selfRef.WordCloudAggregatedFieldWells = @item;
        return @selfRef;
    }

}
