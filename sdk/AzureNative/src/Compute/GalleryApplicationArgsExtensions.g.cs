// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Compute;

public static partial class GalleryApplicationArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithCustomActions(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionArgs> customActions)
    {
        @selfRef.CustomActions = customActions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithCustomActions(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionArgs>();
        @configure(@list);
        @selfRef.CustomActions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithCustomActions(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Compute.Inputs.GalleryApplicationCustomActionArgs>> @create)
    {
        @selfRef.CustomActions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithDescription(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithEndOfLifeDate(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.String endOfLifeDate)
    {
        @selfRef.EndOfLifeDate = endOfLifeDate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithEula(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.String eula)
    {
        @selfRef.Eula = eula;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithGalleryApplicationName(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.String galleryApplicationName)
    {
        @selfRef.GalleryApplicationName = galleryApplicationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithGalleryName(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.String galleryName)
    {
        @selfRef.GalleryName = galleryName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithLocation(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithPrivacyStatementUri(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.String privacyStatementUri)
    {
        @selfRef.PrivacyStatementUri = privacyStatementUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithReleaseNoteUri(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.String releaseNoteUri)
    {
        @selfRef.ReleaseNoteUri = releaseNoteUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithResourceGroupName(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithSupportedOSType(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::Pulumi.AzureNative.Compute.OperatingSystemTypes supportedOSType)
    {
        @selfRef.SupportedOSType = supportedOSType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithSupportedOSType(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.OperatingSystemTypes> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.Compute.OperatingSystemTypes>();
        @configure(@item);
        @selfRef.SupportedOSType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithTags(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithTags(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryApplicationArgs WithTags(this global::Pulumi.AzureNative.Compute.GalleryApplicationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
