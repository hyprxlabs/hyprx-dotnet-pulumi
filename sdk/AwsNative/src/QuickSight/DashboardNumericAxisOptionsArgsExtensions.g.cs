// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardNumericAxisOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericAxisOptionsArgs WithRange(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericAxisOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisDisplayRangeArgs range)
    {
        @selfRef.Range = range;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericAxisOptionsArgs WithRange(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericAxisOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisDisplayRangeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisDisplayRangeArgs();
        @configure(@item);
        @selfRef.Range = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericAxisOptionsArgs WithScale(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericAxisOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisScaleArgs scale)
    {
        @selfRef.Scale = scale;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericAxisOptionsArgs WithScale(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericAxisOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisScaleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisScaleArgs();
        @configure(@item);
        @selfRef.Scale = @item;
        return @selfRef;
    }

}
