// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardDataBarsOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataBarsOptionsArgs WithFieldId(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataBarsOptionsArgs @selfRef, global::System.String fieldId)
    {
        @selfRef.FieldId = fieldId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataBarsOptionsArgs WithNegativeColor(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataBarsOptionsArgs @selfRef, global::System.String negativeColor)
    {
        @selfRef.NegativeColor = negativeColor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataBarsOptionsArgs WithPositiveColor(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataBarsOptionsArgs @selfRef, global::System.String positiveColor)
    {
        @selfRef.PositiveColor = positiveColor;
        return @selfRef;
    }

}
