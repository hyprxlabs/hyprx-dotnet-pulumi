// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardPluginVisualSortConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualSortConfigurationArgs WithPluginVisualTableQuerySort(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualSortConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualTableQuerySortArgs pluginVisualTableQuerySort)
    {
        @selfRef.PluginVisualTableQuerySort = pluginVisualTableQuerySort;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualSortConfigurationArgs WithPluginVisualTableQuerySort(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualSortConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualTableQuerySortArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPluginVisualTableQuerySortArgs();
        @configure(@item);
        @selfRef.PluginVisualTableQuerySort = @item;
        return @selfRef;
    }

}
