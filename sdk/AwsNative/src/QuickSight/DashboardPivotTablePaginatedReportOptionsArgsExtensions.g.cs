// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardPivotTablePaginatedReportOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPivotTablePaginatedReportOptionsArgs WithOverflowColumnHeaderVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPivotTablePaginatedReportOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardVisibility overflowColumnHeaderVisibility)
    {
        @selfRef.OverflowColumnHeaderVisibility = overflowColumnHeaderVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPivotTablePaginatedReportOptionsArgs WithOverflowColumnHeaderVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPivotTablePaginatedReportOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardVisibility> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardVisibility>();
        @configure(@item);
        @selfRef.OverflowColumnHeaderVisibility = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPivotTablePaginatedReportOptionsArgs WithVerticalOverflowVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPivotTablePaginatedReportOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardVisibility verticalOverflowVisibility)
    {
        @selfRef.VerticalOverflowVisibility = verticalOverflowVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPivotTablePaginatedReportOptionsArgs WithVerticalOverflowVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPivotTablePaginatedReportOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardVisibility> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardVisibility>();
        @configure(@item);
        @selfRef.VerticalOverflowVisibility = @item;
        return @selfRef;
    }

}
