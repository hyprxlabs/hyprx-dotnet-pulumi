// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardSheetControlLayoutConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetControlLayoutConfigurationArgs WithGridLayout(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetControlLayoutConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGridLayoutConfigurationArgs gridLayout)
    {
        @selfRef.GridLayout = gridLayout;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetControlLayoutConfigurationArgs WithGridLayout(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSheetControlLayoutConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGridLayoutConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGridLayoutConfigurationArgs();
        @configure(@item);
        @selfRef.GridLayout = @item;
        return @selfRef;
    }

}
