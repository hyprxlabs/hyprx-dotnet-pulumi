// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DataSetDatasetParameterArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs WithDateTimeDatasetParameter(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDateTimeDatasetParameterArgs dateTimeDatasetParameter)
    {
        @selfRef.DateTimeDatasetParameter = dateTimeDatasetParameter;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs WithDateTimeDatasetParameter(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDateTimeDatasetParameterArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDateTimeDatasetParameterArgs();
        @configure(@item);
        @selfRef.DateTimeDatasetParameter = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs WithDecimalDatasetParameter(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDecimalDatasetParameterArgs decimalDatasetParameter)
    {
        @selfRef.DecimalDatasetParameter = decimalDatasetParameter;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs WithDecimalDatasetParameter(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDecimalDatasetParameterArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDecimalDatasetParameterArgs();
        @configure(@item);
        @selfRef.DecimalDatasetParameter = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs WithIntegerDatasetParameter(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSetIntegerDatasetParameterArgs integerDatasetParameter)
    {
        @selfRef.IntegerDatasetParameter = integerDatasetParameter;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs WithIntegerDatasetParameter(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSetIntegerDatasetParameterArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSetIntegerDatasetParameterArgs();
        @configure(@item);
        @selfRef.IntegerDatasetParameter = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs WithStringDatasetParameter(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DataSetStringDatasetParameterArgs stringDatasetParameter)
    {
        @selfRef.StringDatasetParameter = stringDatasetParameter;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs WithStringDatasetParameter(this global::Pulumi.AwsNative.QuickSight.Inputs.DataSetDatasetParameterArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DataSetStringDatasetParameterArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DataSetStringDatasetParameterArgs();
        @configure(@item);
        @selfRef.StringDatasetParameter = @item;
        return @selfRef;
    }

}
