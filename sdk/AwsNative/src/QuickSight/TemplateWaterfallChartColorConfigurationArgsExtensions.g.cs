// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateWaterfallChartColorConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateWaterfallChartColorConfigurationArgs WithGroupColorConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateWaterfallChartColorConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateWaterfallChartGroupColorConfigurationArgs groupColorConfiguration)
    {
        @selfRef.GroupColorConfiguration = groupColorConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateWaterfallChartColorConfigurationArgs WithGroupColorConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateWaterfallChartColorConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateWaterfallChartGroupColorConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateWaterfallChartGroupColorConfigurationArgs();
        @configure(@item);
        @selfRef.GroupColorConfiguration = @item;
        return @selfRef;
    }

}
