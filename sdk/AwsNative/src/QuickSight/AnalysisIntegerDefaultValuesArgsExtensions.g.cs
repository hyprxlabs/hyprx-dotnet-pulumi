// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisIntegerDefaultValuesArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerDefaultValuesArgs WithDynamicValue(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerDefaultValuesArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDynamicDefaultValueArgs dynamicValue)
    {
        @selfRef.DynamicValue = dynamicValue;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerDefaultValuesArgs WithDynamicValue(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerDefaultValuesArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDynamicDefaultValueArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDynamicDefaultValueArgs();
        @configure(@item);
        @selfRef.DynamicValue = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerDefaultValuesArgs WithStaticValues(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerDefaultValuesArgs @selfRef, global::System.Collections.Generic.List<global::System.Double> staticValues)
    {
        @selfRef.StaticValues = staticValues;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerDefaultValuesArgs WithStaticValues(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerDefaultValuesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Double>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Double>();
        @configure(@list);
        @selfRef.StaticValues = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerDefaultValuesArgs WithStaticValues(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerDefaultValuesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Double>> @create)
    {
        @selfRef.StaticValues = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
