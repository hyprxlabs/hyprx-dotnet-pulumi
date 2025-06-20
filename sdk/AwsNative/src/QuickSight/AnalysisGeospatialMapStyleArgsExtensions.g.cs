// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.QuickSight.Inputs;

namespace Pulumi.AwsNative.QuickSight;

public static partial class AnalysisGeospatialMapStyleArgsExtensions
{
    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapStyleArgs WithBackgroundColor(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapStyleArgs @selfRef, global::System.String backgroundColor)
    {
        @selfRef.BackgroundColor = backgroundColor;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapStyleArgs WithBaseMapStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapStyleArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisBaseMapStyleType baseMapStyle)
    {
        @selfRef.BaseMapStyle = baseMapStyle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapStyleArgs WithBaseMapStyle(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapStyleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisBaseMapStyleType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisBaseMapStyleType>();
        @configure(@item);
        @selfRef.BaseMapStyle = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapStyleArgs WithBaseMapVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapStyleArgs @selfRef, global::Pulumi.AwsNative.QuickSight.AnalysisVisibility baseMapVisibility)
    {
        @selfRef.BaseMapVisibility = baseMapVisibility;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapStyleArgs WithBaseMapVisibility(this global::Pulumi.AwsNative.QuickSight.Inputs.AnalysisGeospatialMapStyleArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.QuickSight.AnalysisVisibility> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.QuickSight.AnalysisVisibility>();
        @configure(@item);
        @selfRef.BaseMapVisibility = @item;
        return @selfRef;
    }

}
