// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateItemsLimitConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateItemsLimitConfigurationArgs WithItemsLimit(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateItemsLimitConfigurationArgs @selfRef, global::System.Double itemsLimit)
    {
        @selfRef.ItemsLimit = itemsLimit;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateItemsLimitConfigurationArgs WithOtherCategories(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateItemsLimitConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateOtherCategories otherCategories)
    {
        @selfRef.OtherCategories = otherCategories;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateItemsLimitConfigurationArgs WithOtherCategories(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateItemsLimitConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateOtherCategories> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateOtherCategories>();
        @configure(@item);
        @selfRef.OtherCategories = @item;
        return @selfRef;
    }

}
