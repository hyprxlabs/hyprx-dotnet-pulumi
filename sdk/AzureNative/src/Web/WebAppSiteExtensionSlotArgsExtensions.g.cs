// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Web;

public static partial class WebAppSiteExtensionSlotArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.WebAppSiteExtensionSlotArgs WithName(this global::Pulumi.AzureNative.Web.WebAppSiteExtensionSlotArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSiteExtensionSlotArgs WithResourceGroupName(this global::Pulumi.AzureNative.Web.WebAppSiteExtensionSlotArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSiteExtensionSlotArgs WithSiteExtensionId(this global::Pulumi.AzureNative.Web.WebAppSiteExtensionSlotArgs @selfRef, global::System.String siteExtensionId)
    {
        @selfRef.SiteExtensionId = siteExtensionId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSiteExtensionSlotArgs WithSlot(this global::Pulumi.AzureNative.Web.WebAppSiteExtensionSlotArgs @selfRef, global::System.String slot)
    {
        @selfRef.Slot = slot;
        return @selfRef;
    }

}
