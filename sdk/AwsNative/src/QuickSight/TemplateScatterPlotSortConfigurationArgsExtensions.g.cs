// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class TemplateScatterPlotSortConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateScatterPlotSortConfigurationArgs WithScatterPlotLimitConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateScatterPlotSortConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.TemplateItemsLimitConfigurationArgs scatterPlotLimitConfiguration)
    {
        @selfRef.ScatterPlotLimitConfiguration = scatterPlotLimitConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.TemplateScatterPlotSortConfigurationArgs WithScatterPlotLimitConfiguration(this global::Pulumi.AwsNative.QuickSight.Inputs.TemplateScatterPlotSortConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.TemplateItemsLimitConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.TemplateItemsLimitConfigurationArgs();
        @configure(@item);
        @selfRef.ScatterPlotLimitConfiguration = @item;
        return @selfRef;
    }

}
