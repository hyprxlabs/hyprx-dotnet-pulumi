// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisBodySectionConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs WithContent(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionContentArgs content)
    {
        @selfRef.Content = content;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs WithContent(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionContentArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionContentArgs();
        @configure(@item);
        @selfRef.Content = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs WithPageBreakConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSectionPageBreakConfigurationArgs pageBreakConfiguration)
    {
        @selfRef.PageBreakConfiguration = pageBreakConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs WithPageBreakConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSectionPageBreakConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSectionPageBreakConfigurationArgs();
        @configure(@item);
        @selfRef.PageBreakConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs WithRepeatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionRepeatConfigurationArgs repeatConfiguration)
    {
        @selfRef.RepeatConfiguration = repeatConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs WithRepeatConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionRepeatConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionRepeatConfigurationArgs();
        @configure(@item);
        @selfRef.RepeatConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs WithSectionId(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs @selfRef, global::System.String sectionId)
    {
        @selfRef.SectionId = sectionId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs WithStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSectionStyleArgs style)
    {
        @selfRef.Style = style;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs WithStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisBodySectionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSectionStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSectionStyleArgs();
        @configure(@item);
        @selfRef.Style = @item;
        return @selfRef;
    }

}
