// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardBodySectionConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs WithContent(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionContentArgs content)
    {
        @selfRef.Content = content;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs WithContent(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionContentArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionContentArgs();
        @configure(@item);
        @selfRef.Content = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs WithPageBreakConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionPageBreakConfigurationArgs pageBreakConfiguration)
    {
        @selfRef.PageBreakConfiguration = pageBreakConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs WithPageBreakConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionPageBreakConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionPageBreakConfigurationArgs();
        @configure(@item);
        @selfRef.PageBreakConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs WithRepeatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs repeatConfiguration)
    {
        @selfRef.RepeatConfiguration = repeatConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs WithRepeatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionRepeatConfigurationArgs();
        @configure(@item);
        @selfRef.RepeatConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs WithSectionId(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs @selfRef, global::System.String sectionId)
    {
        @selfRef.SectionId = sectionId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs WithStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionStyleArgs style)
    {
        @selfRef.Style = style;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs WithStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardBodySectionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardSectionStyleArgs();
        @configure(@item);
        @selfRef.Style = @item;
        return @selfRef;
    }

}
