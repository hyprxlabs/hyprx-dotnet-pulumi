// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisDefaultFreeFormLayoutConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefaultFreeFormLayoutConfigurationArgs WithCanvasSizeOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefaultFreeFormLayoutConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFreeFormLayoutCanvasSizeOptionsArgs canvasSizeOptions)
    {
        @selfRef.CanvasSizeOptions = canvasSizeOptions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefaultFreeFormLayoutConfigurationArgs WithCanvasSizeOptions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisDefaultFreeFormLayoutConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFreeFormLayoutCanvasSizeOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisFreeFormLayoutCanvasSizeOptionsArgs();
        @configure(@item);
        @selfRef.CanvasSizeOptions = @item;
        return @selfRef;
    }

}
