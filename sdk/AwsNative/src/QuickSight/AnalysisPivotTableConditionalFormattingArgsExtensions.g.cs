// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisPivotTableConditionalFormattingArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingArgs WithConditionalFormattingOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingOptionArgs> conditionalFormattingOptions)
    {
        @selfRef.ConditionalFormattingOptions = conditionalFormattingOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingArgs WithConditionalFormattingOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingOptionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingOptionArgs>();
        @configure(@list);
        @selfRef.ConditionalFormattingOptions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingArgs WithConditionalFormattingOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConditionalFormattingOptionArgs>> @create)
    {
        @selfRef.ConditionalFormattingOptions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
