// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateReferenceLineValueLabelConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineValueLabelConfigurationArgs WithFormatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineValueLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateNumericFormatConfigurationArgs formatConfiguration)
    {
        @selfRef.FormatConfiguration = formatConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineValueLabelConfigurationArgs WithFormatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineValueLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateNumericFormatConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateNumericFormatConfigurationArgs();
        @configure(@item);
        @selfRef.FormatConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineValueLabelConfigurationArgs WithRelativePosition(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineValueLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateReferenceLineValueLabelRelativePosition relativePosition)
    {
        @selfRef.RelativePosition = relativePosition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineValueLabelConfigurationArgs WithRelativePosition(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineValueLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateReferenceLineValueLabelRelativePosition> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateReferenceLineValueLabelRelativePosition>();
        @configure(@item);
        @selfRef.RelativePosition = @item;
        return @selfRef;
    }

}
