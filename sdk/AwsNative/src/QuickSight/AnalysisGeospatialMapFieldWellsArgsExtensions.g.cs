// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisGeospatialMapFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapFieldWellsArgs WithGeospatialMapAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapFieldWellsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapAggregatedFieldWellsArgs geospatialMapAggregatedFieldWells)
    {
        @selfRef.GeospatialMapAggregatedFieldWells = geospatialMapAggregatedFieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapFieldWellsArgs WithGeospatialMapAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapFieldWellsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapAggregatedFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapAggregatedFieldWellsArgs();
        @configure(@item);
        @selfRef.GeospatialMapAggregatedFieldWells = @item;
        return @selfRef;
    }

}
