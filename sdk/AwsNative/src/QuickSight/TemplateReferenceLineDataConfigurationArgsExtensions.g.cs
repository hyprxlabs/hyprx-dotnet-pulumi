// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateReferenceLineDataConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs WithAxisBinding(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateAxisBinding axisBinding)
    {
        @selfRef.AxisBinding = axisBinding;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs WithAxisBinding(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateAxisBinding> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateAxisBinding>();
        @configure(@item);
        @selfRef.AxisBinding = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs WithDynamicConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDynamicDataConfigurationArgs dynamicConfiguration)
    {
        @selfRef.DynamicConfiguration = dynamicConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs WithDynamicConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDynamicDataConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDynamicDataConfigurationArgs();
        @configure(@item);
        @selfRef.DynamicConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs WithSeriesType(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.TemplateReferenceLineSeriesType seriesType)
    {
        @selfRef.SeriesType = seriesType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs WithSeriesType(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.TemplateReferenceLineSeriesType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.TemplateReferenceLineSeriesType>();
        @configure(@item);
        @selfRef.SeriesType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs WithStaticConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineStaticDataConfigurationArgs staticConfiguration)
    {
        @selfRef.StaticConfiguration = staticConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs WithStaticConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineDataConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineStaticDataConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateReferenceLineStaticDataConfigurationArgs();
        @configure(@item);
        @selfRef.StaticConfiguration = @item;
        return @selfRef;
    }

}
