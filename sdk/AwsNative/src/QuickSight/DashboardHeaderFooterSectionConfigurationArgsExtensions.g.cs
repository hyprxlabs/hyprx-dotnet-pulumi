// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardHeaderFooterSectionConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardHeaderFooterSectionConfigurationArgs WithLayout(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardHeaderFooterSectionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionLayoutConfigurationArgs layout)
    {
        @selfRef.Layout = layout;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardHeaderFooterSectionConfigurationArgs WithLayout(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardHeaderFooterSectionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionLayoutConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionLayoutConfigurationArgs();
        @configure(@item);
        @selfRef.Layout = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardHeaderFooterSectionConfigurationArgs WithSectionId(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardHeaderFooterSectionConfigurationArgs @selfRef, global::System.String sectionId)
    {
        @selfRef.SectionId = sectionId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardHeaderFooterSectionConfigurationArgs WithStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardHeaderFooterSectionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionStyleArgs style)
    {
        @selfRef.Style = style;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardHeaderFooterSectionConfigurationArgs WithStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardHeaderFooterSectionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionStyleArgs();
        @configure(@item);
        @selfRef.Style = @item;
        return @selfRef;
    }

}
