// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DataSetLookbackWindowArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLookbackWindowArgs WithColumnName(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLookbackWindowArgs @selfRef, global::System.String columnName)
    {
        @selfRef.ColumnName = columnName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLookbackWindowArgs WithSize(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLookbackWindowArgs @selfRef, global::System.Double size)
    {
        @selfRef.Size = size;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLookbackWindowArgs WithSizeUnit(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLookbackWindowArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DataSetLookbackWindowSizeUnit sizeUnit)
    {
        @selfRef.SizeUnit = sizeUnit;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLookbackWindowArgs WithSizeUnit(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetLookbackWindowArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DataSetLookbackWindowSizeUnit> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DataSetLookbackWindowSizeUnit>();
        @configure(@item);
        @selfRef.SizeUnit = @item;
        return @selfRef;
    }

}
