// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateFilterCrossSheetControlArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterCrossSheetControlArgs WithCascadingControlConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterCrossSheetControlArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCascadingControlConfigurationArgs cascadingControlConfiguration)
    {
        @selfRef.CascadingControlConfiguration = cascadingControlConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterCrossSheetControlArgs WithCascadingControlConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterCrossSheetControlArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCascadingControlConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateCascadingControlConfigurationArgs();
        @configure(@item);
        @selfRef.CascadingControlConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterCrossSheetControlArgs WithFilterControlId(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterCrossSheetControlArgs @selfRef, global::System.String filterControlId)
    {
        @selfRef.FilterControlId = filterControlId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterCrossSheetControlArgs WithSourceFilterId(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateFilterCrossSheetControlArgs @selfRef, global::System.String sourceFilterId)
    {
        @selfRef.SourceFilterId = sourceFilterId;
        return @selfRef;
    }

}
