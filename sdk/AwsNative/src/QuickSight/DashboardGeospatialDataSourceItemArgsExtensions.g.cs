// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardGeospatialDataSourceItemArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialDataSourceItemArgs WithStaticFileDataSource(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialDataSourceItemArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialStaticFileSourceArgs staticFileDataSource)
    {
        @selfRef.StaticFileDataSource = staticFileDataSource;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialDataSourceItemArgs WithStaticFileDataSource(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialDataSourceItemArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialStaticFileSourceArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialStaticFileSourceArgs();
        @configure(@item);
        @selfRef.StaticFileDataSource = @item;
        return @selfRef;
    }

}
