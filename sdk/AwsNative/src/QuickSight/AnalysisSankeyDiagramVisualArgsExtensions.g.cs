// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisSankeyDiagramVisualArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualCustomActionArgs> actions)
    {
        @selfRef.Actions = actions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualCustomActionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualCustomActionArgs>();
        @configure(@list);
        @selfRef.Actions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualCustomActionArgs>> @create)
    {
        @selfRef.Actions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs WithChartConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramChartConfigurationArgs chartConfiguration)
    {
        @selfRef.ChartConfiguration = chartConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs WithChartConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramChartConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramChartConfigurationArgs();
        @configure(@item);
        @selfRef.ChartConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs WithSubtitle(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualSubtitleLabelOptionsArgs subtitle)
    {
        @selfRef.Subtitle = subtitle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs WithSubtitle(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualSubtitleLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualSubtitleLabelOptionsArgs();
        @configure(@item);
        @selfRef.Subtitle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs WithTitle(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualTitleLabelOptionsArgs title)
    {
        @selfRef.Title = title;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs WithTitle(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualTitleLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualTitleLabelOptionsArgs();
        @configure(@item);
        @selfRef.Title = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs WithVisualContentAltText(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs @selfRef, global::System.String visualContentAltText)
    {
        @selfRef.VisualContentAltText = visualContentAltText;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs WithVisualId(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSankeyDiagramVisualArgs @selfRef, global::System.String visualId)
    {
        @selfRef.VisualId = visualId;
        return @selfRef;
    }

}
