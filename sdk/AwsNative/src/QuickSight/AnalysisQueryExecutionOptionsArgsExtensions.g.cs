// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisQueryExecutionOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisQueryExecutionOptionsArgs WithQueryExecutionMode(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisQueryExecutionOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisQueryExecutionMode queryExecutionMode)
    {
        @selfRef.QueryExecutionMode = queryExecutionMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisQueryExecutionOptionsArgs WithQueryExecutionMode(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisQueryExecutionOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisQueryExecutionMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisQueryExecutionMode>();
        @configure(@item);
        @selfRef.QueryExecutionMode = @item;
        return @selfRef;
    }

}
