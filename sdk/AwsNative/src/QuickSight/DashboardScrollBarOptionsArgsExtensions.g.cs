// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardScrollBarOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScrollBarOptionsArgs WithVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScrollBarOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardVisibility visibility)
    {
        @selfRef.Visibility = visibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScrollBarOptionsArgs WithVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScrollBarOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardVisibility> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardVisibility>();
        @configure(@item);
        @selfRef.Visibility = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScrollBarOptionsArgs WithVisibleRange(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScrollBarOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisibleRangeOptionsArgs visibleRange)
    {
        @selfRef.VisibleRange = visibleRange;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScrollBarOptionsArgs WithVisibleRange(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardScrollBarOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisibleRangeOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisibleRangeOptionsArgs();
        @configure(@item);
        @selfRef.VisibleRange = @item;
        return @selfRef;
    }

}
