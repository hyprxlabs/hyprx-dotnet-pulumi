// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisSeriesItemArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSeriesItemArgs WithDataFieldSeriesItem(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSeriesItemArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataFieldSeriesItemArgs dataFieldSeriesItem)
    {
        @selfRef.DataFieldSeriesItem = dataFieldSeriesItem;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSeriesItemArgs WithDataFieldSeriesItem(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSeriesItemArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataFieldSeriesItemArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDataFieldSeriesItemArgs();
        @configure(@item);
        @selfRef.DataFieldSeriesItem = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSeriesItemArgs WithFieldSeriesItem(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSeriesItemArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFieldSeriesItemArgs fieldSeriesItem)
    {
        @selfRef.FieldSeriesItem = fieldSeriesItem;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSeriesItemArgs WithFieldSeriesItem(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSeriesItemArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFieldSeriesItemArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFieldSeriesItemArgs();
        @configure(@item);
        @selfRef.FieldSeriesItem = @item;
        return @selfRef;
    }

}
