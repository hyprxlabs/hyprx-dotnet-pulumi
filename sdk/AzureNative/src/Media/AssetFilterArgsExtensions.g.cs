// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Media;

public static partial class AssetFilterArgsExtensions
{
    public static global::Pulumi.AzureNative.Media.AssetFilterArgs WithAccountName(this global::Pulumi.AzureNative.Media.AssetFilterArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.AssetFilterArgs WithAssetName(this global::Pulumi.AzureNative.Media.AssetFilterArgs @selfRef, global::System.String assetName)
    {
        @selfRef.AssetName = assetName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.AssetFilterArgs WithFilterName(this global::Pulumi.AzureNative.Media.AssetFilterArgs @selfRef, global::System.String filterName)
    {
        @selfRef.FilterName = filterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.AssetFilterArgs WithFirstQuality(this global::Pulumi.AzureNative.Media.AssetFilterArgs @selfRef, global::Pulumi.AzureNative.Media.Inputs.FirstQualityArgs firstQuality)
    {
        @selfRef.FirstQuality = firstQuality;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.AssetFilterArgs WithFirstQuality(this global::Pulumi.AzureNative.Media.AssetFilterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Media.Inputs.FirstQualityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Media.Inputs.FirstQualityArgs();
        @configure(@item);
        @selfRef.FirstQuality = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.AssetFilterArgs WithPresentationTimeRange(this global::Pulumi.AzureNative.Media.AssetFilterArgs @selfRef, global::Pulumi.AzureNative.Media.Inputs.PresentationTimeRangeArgs presentationTimeRange)
    {
        @selfRef.PresentationTimeRange = presentationTimeRange;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.AssetFilterArgs WithPresentationTimeRange(this global::Pulumi.AzureNative.Media.AssetFilterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Media.Inputs.PresentationTimeRangeArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Media.Inputs.PresentationTimeRangeArgs();
        @configure(@item);
        @selfRef.PresentationTimeRange = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.AssetFilterArgs WithResourceGroupName(this global::Pulumi.AzureNative.Media.AssetFilterArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.AssetFilterArgs WithTracks(this global::Pulumi.AzureNative.Media.AssetFilterArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.FilterTrackSelectionArgs> tracks)
    {
        @selfRef.Tracks = tracks;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.AssetFilterArgs WithTracks(this global::Pulumi.AzureNative.Media.AssetFilterArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.FilterTrackSelectionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Media.Inputs.FilterTrackSelectionArgs>();
        @configure(@list);
        @selfRef.Tracks = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.AssetFilterArgs WithTracks(this global::Pulumi.AzureNative.Media.AssetFilterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Media.Inputs.FilterTrackSelectionArgs>> @create)
    {
        @selfRef.Tracks = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
