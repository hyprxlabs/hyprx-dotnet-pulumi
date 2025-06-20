// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisPivotTableConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithFieldOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableFieldOptionsArgs fieldOptions)
    {
        @selfRef.FieldOptions = fieldOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithFieldOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableFieldOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableFieldOptionsArgs();
        @configure(@item);
        @selfRef.FieldOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableFieldWellsArgs fieldWells)
    {
        @selfRef.FieldWells = fieldWells;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithFieldWells(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableFieldWellsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableFieldWellsArgs();
        @configure(@item);
        @selfRef.FieldWells = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs interactions)
    {
        @selfRef.Interactions = interactions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs();
        @configure(@item);
        @selfRef.Interactions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithPaginatedReportOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTablePaginatedReportOptionsArgs paginatedReportOptions)
    {
        @selfRef.PaginatedReportOptions = paginatedReportOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithPaginatedReportOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTablePaginatedReportOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTablePaginatedReportOptionsArgs();
        @configure(@item);
        @selfRef.PaginatedReportOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithSortConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableSortConfigurationArgs sortConfiguration)
    {
        @selfRef.SortConfiguration = sortConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithSortConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableSortConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableSortConfigurationArgs();
        @configure(@item);
        @selfRef.SortConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithTableOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableOptionsArgs tableOptions)
    {
        @selfRef.TableOptions = tableOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithTableOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableOptionsArgs();
        @configure(@item);
        @selfRef.TableOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithTotalOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableTotalOptionsArgs totalOptions)
    {
        @selfRef.TotalOptions = totalOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs WithTotalOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableTotalOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisPivotTableTotalOptionsArgs();
        @configure(@item);
        @selfRef.TotalOptions = @item;
        return @selfRef;
    }

}
