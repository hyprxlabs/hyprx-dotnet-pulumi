// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardDataPathValueArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataPathValueArgs WithDataPathType(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataPathValueArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataPathTypeArgs dataPathType)
    {
        @selfRef.DataPathType = dataPathType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataPathValueArgs WithDataPathType(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataPathValueArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataPathTypeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataPathTypeArgs();
        @configure(@item);
        @selfRef.DataPathType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataPathValueArgs WithFieldId(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataPathValueArgs @selfRef, global::System.String fieldId)
    {
        @selfRef.FieldId = fieldId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataPathValueArgs WithFieldValue(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardDataPathValueArgs @selfRef, global::System.String fieldValue)
    {
        @selfRef.FieldValue = fieldValue;
        return @selfRef;
    }

}
