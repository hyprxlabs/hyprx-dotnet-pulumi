// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateKpiVisualArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualCustomActionArgs> actions)
    {
        @selfRef.Actions = actions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualCustomActionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualCustomActionArgs>();
        @configure(@list);
        @selfRef.Actions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualCustomActionArgs>> @create)
    {
        @selfRef.Actions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithChartConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConfigurationArgs chartConfiguration)
    {
        @selfRef.ChartConfiguration = chartConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithChartConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConfigurationArgs();
        @configure(@item);
        @selfRef.ChartConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithColumnHierarchies(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnHierarchyArgs> columnHierarchies)
    {
        @selfRef.ColumnHierarchies = columnHierarchies;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithColumnHierarchies(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnHierarchyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnHierarchyArgs>();
        @configure(@list);
        @selfRef.ColumnHierarchies = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithColumnHierarchies(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnHierarchyArgs>> @create)
    {
        @selfRef.ColumnHierarchies = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithConditionalFormatting(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingArgs conditionalFormatting)
    {
        @selfRef.ConditionalFormatting = conditionalFormatting;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithConditionalFormatting(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiConditionalFormattingArgs();
        @configure(@item);
        @selfRef.ConditionalFormatting = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithSubtitle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualSubtitleLabelOptionsArgs subtitle)
    {
        @selfRef.Subtitle = subtitle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithSubtitle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualSubtitleLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualSubtitleLabelOptionsArgs();
        @configure(@item);
        @selfRef.Subtitle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithTitle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualTitleLabelOptionsArgs title)
    {
        @selfRef.Title = title;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithTitle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualTitleLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateVisualTitleLabelOptionsArgs();
        @configure(@item);
        @selfRef.Title = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithVisualContentAltText(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::System.String visualContentAltText)
    {
        @selfRef.VisualContentAltText = visualContentAltText;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs WithVisualId(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateKpiVisualArgs @selfRef, global::System.String visualId)
    {
        @selfRef.VisualId = visualId;
        return @selfRef;
    }

}
