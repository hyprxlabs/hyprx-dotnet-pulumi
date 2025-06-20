// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateFunnelChartSortConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartSortConfigurationArgs WithCategoryItemsLimit(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartSortConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateItemsLimitConfigurationArgs categoryItemsLimit)
    {
        @selfRef.CategoryItemsLimit = categoryItemsLimit;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartSortConfigurationArgs WithCategoryItemsLimit(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartSortConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateItemsLimitConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateItemsLimitConfigurationArgs();
        @configure(@item);
        @selfRef.CategoryItemsLimit = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartSortConfigurationArgs WithCategorySort(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartSortConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldSortOptionsArgs> categorySort)
    {
        @selfRef.CategorySort = categorySort;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartSortConfigurationArgs WithCategorySort(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartSortConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldSortOptionsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldSortOptionsArgs>();
        @configure(@list);
        @selfRef.CategorySort = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartSortConfigurationArgs WithCategorySort(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFunnelChartSortConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFieldSortOptionsArgs>> @create)
    {
        @selfRef.CategorySort = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
