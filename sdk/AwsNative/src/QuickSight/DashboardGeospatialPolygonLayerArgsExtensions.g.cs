// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardGeospatialPolygonLayerArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPolygonLayerArgs WithStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPolygonLayerArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPolygonStyleArgs style)
    {
        @selfRef.Style = style;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPolygonLayerArgs WithStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPolygonLayerArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPolygonStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPolygonStyleArgs();
        @configure(@item);
        @selfRef.Style = @item;
        return @selfRef;
    }

}
