// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisIntegerValueWhenUnsetConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerValueWhenUnsetConfigurationArgs WithCustomValue(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerValueWhenUnsetConfigurationArgs @selfRef, global::System.Double customValue)
    {
        @selfRef.CustomValue = customValue;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerValueWhenUnsetConfigurationArgs WithValueWhenUnsetOption(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerValueWhenUnsetConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisValueWhenUnsetOption valueWhenUnsetOption)
    {
        @selfRef.ValueWhenUnsetOption = valueWhenUnsetOption;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerValueWhenUnsetConfigurationArgs WithValueWhenUnsetOption(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisIntegerValueWhenUnsetConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisValueWhenUnsetOption> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisValueWhenUnsetOption>();
        @configure(@item);
        @selfRef.ValueWhenUnsetOption = @item;
        return @selfRef;
    }

}
