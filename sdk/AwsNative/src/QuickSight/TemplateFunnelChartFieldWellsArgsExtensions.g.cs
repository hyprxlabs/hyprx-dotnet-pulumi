// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateFunnelChartFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartFieldWellsArgs WithFunnelChartAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartFieldWellsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs funnelChartAggregatedFieldWells)
    {
        @selfRef.FunnelChartAggregatedFieldWells = funnelChartAggregatedFieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartFieldWellsArgs WithFunnelChartAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartFieldWellsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartAggregatedFieldWellsArgs();
        @configure(@item);
        @selfRef.FunnelChartAggregatedFieldWells = @item;
        return @selfRef;
    }

}
