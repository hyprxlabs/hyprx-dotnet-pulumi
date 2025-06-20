// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisGeospatialHeatmapConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialHeatmapConfigurationArgs WithHeatmapColor(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialHeatmapConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialHeatmapColorScaleArgs heatmapColor)
    {
        @selfRef.HeatmapColor = heatmapColor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialHeatmapConfigurationArgs WithHeatmapColor(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialHeatmapConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialHeatmapColorScaleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialHeatmapColorScaleArgs();
        @configure(@item);
        @selfRef.HeatmapColor = @item;
        return @selfRef;
    }

}
