// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Web;

public static partial class WebAppSitePushSettingsSlotExtensions
{

    extension(WebAppSitePushSettingsSlot)
    {
        public static WebAppSitePushSettingsSlot New(string @id, global::Pulumi.AzureNative.Web.WebAppSitePushSettingsSlotArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new WebAppSitePushSettingsSlot(@id, @args, @options);
        }

        public static WebAppSitePushSettingsSlot New(string @id, global::System.Action<global::Pulumi.AzureNative.Web.WebAppSitePushSettingsSlotArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Web.WebAppSitePushSettingsSlotArgs @args = new();
            global::Pulumi.CustomResourceOptions? @options = null;
            if (@configureArgs is not null)
            {
                @configureArgs(@args);
            }

            if (@configureOptions is not null)
            {
                @options = new();
                @configureOptions(@options);
            }

            return new WebAppSitePushSettingsSlot(@id, @args, @options);
        }

    }

}
