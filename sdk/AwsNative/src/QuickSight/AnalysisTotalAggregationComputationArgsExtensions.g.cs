// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisTotalAggregationComputationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTotalAggregationComputationArgs WithComputationId(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTotalAggregationComputationArgs @selfRef, global::System.String computationId)
    {
        @selfRef.ComputationId = computationId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTotalAggregationComputationArgs WithName(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTotalAggregationComputationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTotalAggregationComputationArgs WithValue(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTotalAggregationComputationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisMeasureFieldArgs value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTotalAggregationComputationArgs WithValue(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisTotalAggregationComputationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisMeasureFieldArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisMeasureFieldArgs();
        @configure(@item);
        @selfRef.Value = @item;
        return @selfRef;
    }

}
