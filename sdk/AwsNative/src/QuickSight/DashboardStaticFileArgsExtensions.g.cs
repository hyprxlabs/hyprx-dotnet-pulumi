// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardStaticFileArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardStaticFileArgs WithImageStaticFile(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardStaticFileArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardImageStaticFileArgs imageStaticFile)
    {
        @selfRef.ImageStaticFile = imageStaticFile;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardStaticFileArgs WithImageStaticFile(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardStaticFileArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardImageStaticFileArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardImageStaticFileArgs();
        @configure(@item);
        @selfRef.ImageStaticFile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardStaticFileArgs WithSpatialStaticFile(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardStaticFileArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSpatialStaticFileArgs spatialStaticFile)
    {
        @selfRef.SpatialStaticFile = spatialStaticFile;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardStaticFileArgs WithSpatialStaticFile(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardStaticFileArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSpatialStaticFileArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSpatialStaticFileArgs();
        @configure(@item);
        @selfRef.SpatialStaticFile = @item;
        return @selfRef;
    }

}
