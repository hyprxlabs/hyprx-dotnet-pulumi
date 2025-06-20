// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateFilterListControlArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs WithCascadingControlConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCascadingControlConfigurationArgs cascadingControlConfiguration)
    {
        @selfRef.CascadingControlConfiguration = cascadingControlConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs WithCascadingControlConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCascadingControlConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCascadingControlConfigurationArgs();
        @configure(@item);
        @selfRef.CascadingControlConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs WithDisplayOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateListControlDisplayOptionsArgs displayOptions)
    {
        @selfRef.DisplayOptions = displayOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs WithDisplayOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateListControlDisplayOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateListControlDisplayOptionsArgs();
        @configure(@item);
        @selfRef.DisplayOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs WithFilterControlId(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs @selfRef, global::System.String filterControlId)
    {
        @selfRef.FilterControlId = filterControlId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs WithSelectableValues(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterSelectableValuesArgs selectableValues)
    {
        @selfRef.SelectableValues = selectableValues;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs WithSelectableValues(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterSelectableValuesArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterSelectableValuesArgs();
        @configure(@item);
        @selfRef.SelectableValues = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs WithSourceFilterId(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs @selfRef, global::System.String sourceFilterId)
    {
        @selfRef.SourceFilterId = sourceFilterId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs WithTitle(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs @selfRef, global::System.String title)
    {
        @selfRef.Title = title;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs WithType(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateSheetControlListType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs WithType(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterListControlArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateSheetControlListType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateSheetControlListType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
