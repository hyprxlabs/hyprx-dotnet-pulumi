// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardAxisScaleArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisScaleArgs WithLinear(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisScaleArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisLinearScaleArgs linear)
    {
        @selfRef.Linear = linear;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisScaleArgs WithLinear(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisScaleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisLinearScaleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisLinearScaleArgs();
        @configure(@item);
        @selfRef.Linear = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisScaleArgs WithLogarithmic(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisScaleArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisLogarithmicScaleArgs logarithmic)
    {
        @selfRef.Logarithmic = logarithmic;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisScaleArgs WithLogarithmic(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisScaleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisLogarithmicScaleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardAxisLogarithmicScaleArgs();
        @configure(@item);
        @selfRef.Logarithmic = @item;
        return @selfRef;
    }

}
