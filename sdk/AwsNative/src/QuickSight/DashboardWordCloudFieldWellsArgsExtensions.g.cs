// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardWordCloudFieldWellsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWordCloudFieldWellsArgs WithWordCloudAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWordCloudFieldWellsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWordCloudAggregatedFieldWellsArgs wordCloudAggregatedFieldWells)
    {
        @selfRef.WordCloudAggregatedFieldWells = wordCloudAggregatedFieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWordCloudFieldWellsArgs WithWordCloudAggregatedFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWordCloudFieldWellsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWordCloudAggregatedFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWordCloudAggregatedFieldWellsArgs();
        @configure(@item);
        @selfRef.WordCloudAggregatedFieldWells = @item;
        return @selfRef;
    }

}
