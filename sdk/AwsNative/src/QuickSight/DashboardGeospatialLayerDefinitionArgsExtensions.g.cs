// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardGeospatialLayerDefinitionArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLayerDefinitionArgs WithLineLayer(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLayerDefinitionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLineLayerArgs lineLayer)
    {
        @selfRef.LineLayer = lineLayer;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLayerDefinitionArgs WithLineLayer(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLayerDefinitionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLineLayerArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLineLayerArgs();
        @configure(@item);
        @selfRef.LineLayer = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLayerDefinitionArgs WithPointLayer(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLayerDefinitionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPointLayerArgs pointLayer)
    {
        @selfRef.PointLayer = pointLayer;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLayerDefinitionArgs WithPointLayer(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLayerDefinitionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPointLayerArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPointLayerArgs();
        @configure(@item);
        @selfRef.PointLayer = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLayerDefinitionArgs WithPolygonLayer(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLayerDefinitionArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPolygonLayerArgs polygonLayer)
    {
        @selfRef.PolygonLayer = polygonLayer;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLayerDefinitionArgs WithPolygonLayer(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialLayerDefinitionArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPolygonLayerArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPolygonLayerArgs();
        @configure(@item);
        @selfRef.PolygonLayer = @item;
        return @selfRef;
    }

}
