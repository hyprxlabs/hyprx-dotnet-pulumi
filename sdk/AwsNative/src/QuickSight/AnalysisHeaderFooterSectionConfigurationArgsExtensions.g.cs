// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisHeaderFooterSectionConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisHeaderFooterSectionConfigurationArgs WithLayout(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisHeaderFooterSectionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSectionLayoutConfigurationArgs layout)
    {
        @selfRef.Layout = layout;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisHeaderFooterSectionConfigurationArgs WithLayout(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisHeaderFooterSectionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSectionLayoutConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSectionLayoutConfigurationArgs();
        @configure(@item);
        @selfRef.Layout = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisHeaderFooterSectionConfigurationArgs WithSectionId(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisHeaderFooterSectionConfigurationArgs @selfRef, global::System.String sectionId)
    {
        @selfRef.SectionId = sectionId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisHeaderFooterSectionConfigurationArgs WithStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisHeaderFooterSectionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSectionStyleArgs style)
    {
        @selfRef.Style = style;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisHeaderFooterSectionConfigurationArgs WithStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisHeaderFooterSectionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSectionStyleArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSectionStyleArgs();
        @configure(@item);
        @selfRef.Style = @item;
        return @selfRef;
    }

}
