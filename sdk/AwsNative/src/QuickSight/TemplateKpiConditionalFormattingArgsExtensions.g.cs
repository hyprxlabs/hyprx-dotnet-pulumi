// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateKpiConditionalFormattingArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingArgs WithConditionalFormattingOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingOptionArgs> conditionalFormattingOptions)
    {
        @selfRef.ConditionalFormattingOptions = conditionalFormattingOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingArgs WithConditionalFormattingOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingOptionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingOptionArgs>();
        @configure(@list);
        @selfRef.ConditionalFormattingOptions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingArgs WithConditionalFormattingOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingOptionArgs>> @create)
    {
        @selfRef.ConditionalFormattingOptions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
