// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateRadarChartFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartFieldWellsArgs WithRadarChartAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartFieldWellsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartAggregatedFieldWellsArgs radarChartAggregatedFieldWells)
    {
        @selfRef.RadarChartAggregatedFieldWells = radarChartAggregatedFieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartFieldWellsArgs WithRadarChartAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartFieldWellsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartAggregatedFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateRadarChartAggregatedFieldWellsArgs();
        @configure(@item);
        @selfRef.RadarChartAggregatedFieldWells = @item;
        return @selfRef;
    }

}
