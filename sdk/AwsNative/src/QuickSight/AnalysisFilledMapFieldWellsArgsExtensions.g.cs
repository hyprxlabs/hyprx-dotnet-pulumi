// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisFilledMapFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFilledMapFieldWellsArgs WithFilledMapAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFilledMapFieldWellsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFilledMapAggregatedFieldWellsArgs filledMapAggregatedFieldWells)
    {
        @selfRef.FilledMapAggregatedFieldWells = filledMapAggregatedFieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFilledMapFieldWellsArgs WithFilledMapAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFilledMapFieldWellsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFilledMapAggregatedFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFilledMapAggregatedFieldWellsArgs();
        @configure(@item);
        @selfRef.FilledMapAggregatedFieldWells = @item;
        return @selfRef;
    }

}
