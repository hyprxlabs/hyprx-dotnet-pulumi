// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisCustomContentConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs WithContentType(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisCustomContentType contentType)
    {
        @selfRef.ContentType = contentType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs WithContentType(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisCustomContentType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisCustomContentType>();
        @configure(@item);
        @selfRef.ContentType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs WithContentUrl(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs @selfRef, global::System.String contentUrl)
    {
        @selfRef.ContentUrl = contentUrl;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs WithImageScaling(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisCustomContentImageScalingConfiguration imageScaling)
    {
        @selfRef.ImageScaling = imageScaling;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs WithImageScaling(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisCustomContentImageScalingConfiguration> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisCustomContentImageScalingConfiguration>();
        @configure(@item);
        @selfRef.ImageScaling = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs @selfRef, global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs interactions)
    {
        @selfRef.Interactions = interactions;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs WithInteractions(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisCustomContentConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisVisualInteractionOptionsArgs();
        @configure(@item);
        @selfRef.Interactions = @item;
        return @selfRef;
    }

}
