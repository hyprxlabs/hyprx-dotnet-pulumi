// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateDecimalValueWhenUnsetConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDecimalValueWhenUnsetConfigurationArgs WithCustomValue(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDecimalValueWhenUnsetConfigurationArgs @selfRef, global::System.Double customValue)
    {
        @selfRef.CustomValue = customValue;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDecimalValueWhenUnsetConfigurationArgs WithValueWhenUnsetOption(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDecimalValueWhenUnsetConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateValueWhenUnsetOption valueWhenUnsetOption)
    {
        @selfRef.ValueWhenUnsetOption = valueWhenUnsetOption;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDecimalValueWhenUnsetConfigurationArgs WithValueWhenUnsetOption(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDecimalValueWhenUnsetConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateValueWhenUnsetOption> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateValueWhenUnsetOption>();
        @configure(@item);
        @selfRef.ValueWhenUnsetOption = @item;
        return @selfRef;
    }

}
