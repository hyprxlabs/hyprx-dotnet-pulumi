// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardScatterPlotSortConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotSortConfigurationArgs WithScatterPlotLimitConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotSortConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardItemsLimitConfigurationArgs scatterPlotLimitConfiguration)
    {
        @selfRef.ScatterPlotLimitConfiguration = scatterPlotLimitConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotSortConfigurationArgs WithScatterPlotLimitConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScatterPlotSortConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardItemsLimitConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardItemsLimitConfigurationArgs();
        @configure(@item);
        @selfRef.ScatterPlotLimitConfiguration = @item;
        return @selfRef;
    }

}
