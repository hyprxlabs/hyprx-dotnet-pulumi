// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardKpiSortConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiSortConfigurationArgs WithTrendGroupSort(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiSortConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFieldSortOptionsArgs> trendGroupSort)
    {
        @selfRef.TrendGroupSort = trendGroupSort;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiSortConfigurationArgs WithTrendGroupSort(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiSortConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFieldSortOptionsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFieldSortOptionsArgs>();
        @configure(@list);
        @selfRef.TrendGroupSort = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiSortConfigurationArgs WithTrendGroupSort(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiSortConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardFieldSortOptionsArgs>> @create)
    {
        @selfRef.TrendGroupSort = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
