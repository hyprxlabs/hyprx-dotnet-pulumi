// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisCustomActionUrlOperationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomActionUrlOperationArgs WithUrlTarget(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomActionUrlOperationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisUrlTargetConfiguration urlTarget)
    {
        @selfRef.UrlTarget = urlTarget;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomActionUrlOperationArgs WithUrlTarget(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomActionUrlOperationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisUrlTargetConfiguration> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisUrlTargetConfiguration>();
        @configure(@item);
        @selfRef.UrlTarget = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomActionUrlOperationArgs WithUrlTemplate(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomActionUrlOperationArgs @selfRef, global::System.String urlTemplate)
    {
        @selfRef.UrlTemplate = urlTemplate;
        return @selfRef;
    }

}
