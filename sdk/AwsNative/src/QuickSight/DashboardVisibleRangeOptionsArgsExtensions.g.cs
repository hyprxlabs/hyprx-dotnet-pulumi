// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardVisibleRangeOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisibleRangeOptionsArgs WithPercentRange(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisibleRangeOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPercentVisibleRangeArgs percentRange)
    {
        @selfRef.PercentRange = percentRange;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisibleRangeOptionsArgs WithPercentRange(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisibleRangeOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPercentVisibleRangeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardPercentVisibleRangeArgs();
        @configure(@item);
        @selfRef.PercentRange = @item;
        return @selfRef;
    }

}
