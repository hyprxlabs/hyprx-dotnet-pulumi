// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateBodySectionDynamicCategoryDimensionConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateBodySectionDynamicCategoryDimensionConfigurationArgs WithColumn(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateBodySectionDynamicCategoryDimensionConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnIdentifierArgs column)
    {
        @selfRef.Column = column;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateBodySectionDynamicCategoryDimensionConfigurationArgs WithColumn(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateBodySectionDynamicCategoryDimensionConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnIdentifierArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnIdentifierArgs();
        @configure(@item);
        @selfRef.Column = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateBodySectionDynamicCategoryDimensionConfigurationArgs WithLimit(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateBodySectionDynamicCategoryDimensionConfigurationArgs @selfRef, global::System.Double limit)
    {
        @selfRef.Limit = limit;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateBodySectionDynamicCategoryDimensionConfigurationArgs WithSortByMetrics(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateBodySectionDynamicCategoryDimensionConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnSortArgs> sortByMetrics)
    {
        @selfRef.SortByMetrics = sortByMetrics;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateBodySectionDynamicCategoryDimensionConfigurationArgs WithSortByMetrics(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateBodySectionDynamicCategoryDimensionConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnSortArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnSortArgs>();
        @configure(@list);
        @selfRef.SortByMetrics = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateBodySectionDynamicCategoryDimensionConfigurationArgs WithSortByMetrics(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateBodySectionDynamicCategoryDimensionConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateColumnSortArgs>> @create)
    {
        @selfRef.SortByMetrics = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
