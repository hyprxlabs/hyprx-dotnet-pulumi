// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardGeospatialPointStyleArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPointStyleArgs WithCircleSymbolStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPointStyleArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialCircleSymbolStyleArgs circleSymbolStyle)
    {
        @selfRef.CircleSymbolStyle = circleSymbolStyle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPointStyleArgs WithCircleSymbolStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialPointStyleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialCircleSymbolStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardGeospatialCircleSymbolStyleArgs();
        @configure(@item);
        @selfRef.CircleSymbolStyle = @item;
        return @selfRef;
    }

}
