// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateDropDownControlDisplayOptionsArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDropDownControlDisplayOptionsArgs WithInfoIconLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDropDownControlDisplayOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateSheetControlInfoIconLabelOptionsArgs infoIconLabelOptions)
    {
        @selfRef.InfoIconLabelOptions = infoIconLabelOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDropDownControlDisplayOptionsArgs WithInfoIconLabelOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDropDownControlDisplayOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateSheetControlInfoIconLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateSheetControlInfoIconLabelOptionsArgs();
        @configure(@item);
        @selfRef.InfoIconLabelOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDropDownControlDisplayOptionsArgs WithSelectAllOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDropDownControlDisplayOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateListControlSelectAllOptionsArgs selectAllOptions)
    {
        @selfRef.SelectAllOptions = selectAllOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDropDownControlDisplayOptionsArgs WithSelectAllOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDropDownControlDisplayOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateListControlSelectAllOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateListControlSelectAllOptionsArgs();
        @configure(@item);
        @selfRef.SelectAllOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDropDownControlDisplayOptionsArgs WithTitleOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDropDownControlDisplayOptionsArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLabelOptionsArgs titleOptions)
    {
        @selfRef.TitleOptions = titleOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDropDownControlDisplayOptionsArgs WithTitleOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateDropDownControlDisplayOptionsArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLabelOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateLabelOptionsArgs();
        @configure(@item);
        @selfRef.TitleOptions = @item;
        return @selfRef;
    }

}
