// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplatePivotTableRowsLabelOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableRowsLabelOptionsArgs WithCustomLabel(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableRowsLabelOptionsArgs @selfRef, global::System.String customLabel)
    {
        @selfRef.CustomLabel = customLabel;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableRowsLabelOptionsArgs WithVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableRowsLabelOptionsArgs @selfRef, global::System.Object visibility)
    {
        @selfRef.Visibility = visibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableRowsLabelOptionsArgs WithVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplatePivotTableRowsLabelOptionsArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Visibility = @item;
        return @selfRef;
    }

}
