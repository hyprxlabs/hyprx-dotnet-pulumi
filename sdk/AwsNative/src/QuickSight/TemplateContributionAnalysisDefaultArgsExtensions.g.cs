// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateContributionAnalysisDefaultArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateContributionAnalysisDefaultArgs WithContributorDimensions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateContributionAnalysisDefaultArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnIdentifierArgs> contributorDimensions)
    {
        @selfRef.ContributorDimensions = contributorDimensions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateContributionAnalysisDefaultArgs WithContributorDimensions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateContributionAnalysisDefaultArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnIdentifierArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnIdentifierArgs>();
        @configure(@list);
        @selfRef.ContributorDimensions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateContributionAnalysisDefaultArgs WithContributorDimensions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateContributionAnalysisDefaultArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnIdentifierArgs>> @create)
    {
        @selfRef.ContributorDimensions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateContributionAnalysisDefaultArgs WithMeasureFieldId(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateContributionAnalysisDefaultArgs @selfRef, global::System.String measureFieldId)
    {
        @selfRef.MeasureFieldId = measureFieldId;
        return @selfRef;
    }

}
