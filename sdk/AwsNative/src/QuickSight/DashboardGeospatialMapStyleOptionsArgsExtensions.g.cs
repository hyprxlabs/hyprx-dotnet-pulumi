// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardGeospatialMapStyleOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialMapStyleOptionsArgs WithBaseMapStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialMapStyleOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardBaseMapStyleType baseMapStyle)
    {
        @selfRef.BaseMapStyle = baseMapStyle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialMapStyleOptionsArgs WithBaseMapStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialMapStyleOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardBaseMapStyleType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardBaseMapStyleType>();
        @configure(@item);
        @selfRef.BaseMapStyle = @item;
        return @selfRef;
    }

}
