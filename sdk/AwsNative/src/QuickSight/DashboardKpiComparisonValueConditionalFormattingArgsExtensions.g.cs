// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardKpiComparisonValueConditionalFormattingArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiComparisonValueConditionalFormattingArgs WithIcon(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiComparisonValueConditionalFormattingArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardConditionalFormattingIconArgs icon)
    {
        @selfRef.Icon = icon;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiComparisonValueConditionalFormattingArgs WithIcon(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiComparisonValueConditionalFormattingArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardConditionalFormattingIconArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardConditionalFormattingIconArgs();
        @configure(@item);
        @selfRef.Icon = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiComparisonValueConditionalFormattingArgs WithTextColor(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiComparisonValueConditionalFormattingArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardConditionalFormattingColorArgs textColor)
    {
        @selfRef.TextColor = textColor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiComparisonValueConditionalFormattingArgs WithTextColor(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardKpiComparisonValueConditionalFormattingArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardConditionalFormattingColorArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardConditionalFormattingColorArgs();
        @configure(@item);
        @selfRef.TextColor = @item;
        return @selfRef;
    }

}
