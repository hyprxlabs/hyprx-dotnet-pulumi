// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class DashboardWaterfallVisualArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualCustomActionArgs> actions)
    {
        @selfRef.Actions = actions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualCustomActionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualCustomActionArgs>();
        @configure(@list);
        @selfRef.Actions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithActions(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualCustomActionArgs>> @create)
    {
        @selfRef.Actions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithChartConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartConfigurationArgs chartConfiguration)
    {
        @selfRef.ChartConfiguration = chartConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithChartConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallChartConfigurationArgs();
        @configure(@item);
        @selfRef.ChartConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithColumnHierarchies(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardColumnHierarchyArgs> columnHierarchies)
    {
        @selfRef.ColumnHierarchies = columnHierarchies;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithColumnHierarchies(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardColumnHierarchyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardColumnHierarchyArgs>();
        @configure(@list);
        @selfRef.ColumnHierarchies = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithColumnHierarchies(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardColumnHierarchyArgs>> @create)
    {
        @selfRef.ColumnHierarchies = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithSubtitle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualSubtitleLabelOptionsArgs subtitle)
    {
        @selfRef.Subtitle = subtitle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithSubtitle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualSubtitleLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualSubtitleLabelOptionsArgs();
        @configure(@item);
        @selfRef.Subtitle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithTitle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualTitleLabelOptionsArgs title)
    {
        @selfRef.Title = title;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithTitle(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualTitleLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.DashboardVisualTitleLabelOptionsArgs();
        @configure(@item);
        @selfRef.Title = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithVisualContentAltText(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::System.String visualContentAltText)
    {
        @selfRef.VisualContentAltText = visualContentAltText;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs WithVisualId(this global::Pulumi.AwsNative.QuickSight.Inputs.DashboardWaterfallVisualArgs @selfRef, global::System.String visualId)
    {
        @selfRef.VisualId = visualId;
        return @selfRef;
    }

}
