// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardTableStyleTargetArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTableStyleTargetArgs WithCellType(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTableStyleTargetArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardStyledCellType cellType)
    {
        @selfRef.CellType = cellType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTableStyleTargetArgs WithCellType(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardTableStyleTargetArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardStyledCellType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardStyledCellType>();
        @configure(@item);
        @selfRef.CellType = @item;
        return @selfRef;
    }

}
