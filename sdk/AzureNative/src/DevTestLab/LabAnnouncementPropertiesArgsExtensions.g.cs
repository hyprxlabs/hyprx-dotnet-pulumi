// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DevTestLab.Inputs;

namespace Pulumi.AzureNative.DevTestLab;

public static partial class LabAnnouncementPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabAnnouncementPropertiesArgs WithEnabled(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabAnnouncementPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DevTestLab.EnableStatus> enabled)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabAnnouncementPropertiesArgs WithExpirationDate(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabAnnouncementPropertiesArgs @selfRef, global::System.String expirationDate)
    {
        @selfRef.ExpirationDate = expirationDate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabAnnouncementPropertiesArgs WithExpired(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabAnnouncementPropertiesArgs @selfRef, bool expired = true)
    {
        @selfRef.Expired = expired;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabAnnouncementPropertiesArgs WithMarkdown(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabAnnouncementPropertiesArgs @selfRef, global::System.String markdown)
    {
        @selfRef.Markdown = markdown;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevTestLab.Inputs.LabAnnouncementPropertiesArgs WithTitle(this global::Pulumi.AzureNative.DevTestLab.Inputs.LabAnnouncementPropertiesArgs @selfRef, global::System.String title)
    {
        @selfRef.Title = title;
        return @selfRef;
    }

}
