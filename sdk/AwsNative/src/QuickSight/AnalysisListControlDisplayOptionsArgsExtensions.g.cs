// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisListControlDisplayOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs WithInfoIconLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSheetControlInfoIconLabelOptionsArgs infoIconLabelOptions)
    {
        @selfRef.InfoIconLabelOptions = infoIconLabelOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs WithInfoIconLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSheetControlInfoIconLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisSheetControlInfoIconLabelOptionsArgs();
        @configure(@item);
        @selfRef.InfoIconLabelOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs WithSearchOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlSearchOptionsArgs searchOptions)
    {
        @selfRef.SearchOptions = searchOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs WithSearchOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlSearchOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlSearchOptionsArgs();
        @configure(@item);
        @selfRef.SearchOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs WithSelectAllOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlSelectAllOptionsArgs selectAllOptions)
    {
        @selfRef.SelectAllOptions = selectAllOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs WithSelectAllOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlSelectAllOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlSelectAllOptionsArgs();
        @configure(@item);
        @selfRef.SelectAllOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs WithTitleOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLabelOptionsArgs titleOptions)
    {
        @selfRef.TitleOptions = titleOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs WithTitleOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisListControlDisplayOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisLabelOptionsArgs();
        @configure(@item);
        @selfRef.TitleOptions = @item;
        return @selfRef;
    }

}
