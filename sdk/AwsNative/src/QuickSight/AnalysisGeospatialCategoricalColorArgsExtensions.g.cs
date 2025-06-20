// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisGeospatialCategoricalColorArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs WithCategoryDataColors(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalDataColorArgs> categoryDataColors)
    {
        @selfRef.CategoryDataColors = categoryDataColors;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs WithCategoryDataColors(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalDataColorArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalDataColorArgs>();
        @configure(@list);
        @selfRef.CategoryDataColors = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs WithCategoryDataColors(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalDataColorArgs>> @create)
    {
        @selfRef.CategoryDataColors = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs WithDefaultOpacity(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs @selfRef, global::System.Double defaultOpacity)
    {
        @selfRef.DefaultOpacity = defaultOpacity;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs WithNullDataSettings(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialNullDataSettingsArgs nullDataSettings)
    {
        @selfRef.NullDataSettings = nullDataSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs WithNullDataSettings(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialNullDataSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialNullDataSettingsArgs();
        @configure(@item);
        @selfRef.NullDataSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs WithNullDataVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisVisibility nullDataVisibility)
    {
        @selfRef.NullDataVisibility = nullDataVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs WithNullDataVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialCategoricalColorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisVisibility> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisVisibility>();
        @configure(@item);
        @selfRef.NullDataVisibility = @item;
        return @selfRef;
    }

}
