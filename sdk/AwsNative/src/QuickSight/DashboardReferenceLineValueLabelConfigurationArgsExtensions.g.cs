// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardReferenceLineValueLabelConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineValueLabelConfigurationArgs WithFormatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineValueLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs formatConfiguration)
    {
        @selfRef.FormatConfiguration = formatConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineValueLabelConfigurationArgs WithFormatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineValueLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardNumericFormatConfigurationArgs();
        @configure(@item);
        @selfRef.FormatConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineValueLabelConfigurationArgs WithRelativePosition(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineValueLabelConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.DashboardReferenceLineValueLabelRelativePosition relativePosition)
    {
        @selfRef.RelativePosition = relativePosition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineValueLabelConfigurationArgs WithRelativePosition(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardReferenceLineValueLabelConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.DashboardReferenceLineValueLabelRelativePosition> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.DashboardReferenceLineValueLabelRelativePosition>();
        @configure(@item);
        @selfRef.RelativePosition = @item;
        return @selfRef;
    }

}
