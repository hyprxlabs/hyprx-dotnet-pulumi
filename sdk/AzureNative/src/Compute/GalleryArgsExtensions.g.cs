// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Compute;

public static partial class GalleryArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithDescription(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithGalleryName(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::System.String galleryName)
    {
        @selfRef.GalleryName = galleryName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithIdentity(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.GalleryIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithIdentity(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.GalleryIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.GalleryIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithLocation(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithResourceGroupName(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithSharingProfile(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.SharingProfileArgs sharingProfile)
    {
        @selfRef.SharingProfile = sharingProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithSharingProfile(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.SharingProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.SharingProfileArgs();
        @configure(@item);
        @selfRef.SharingProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithSoftDeletePolicy(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.SoftDeletePolicyArgs softDeletePolicy)
    {
        @selfRef.SoftDeletePolicy = softDeletePolicy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithSoftDeletePolicy(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.SoftDeletePolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.SoftDeletePolicyArgs();
        @configure(@item);
        @selfRef.SoftDeletePolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithTags(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithTags(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.GalleryArgs WithTags(this global::Pulumi.AzureNative.Compute.GalleryArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
