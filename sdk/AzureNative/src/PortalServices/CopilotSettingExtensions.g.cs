// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.PortalServices;

public static partial class CopilotSettingExtensions
{

    extension(CopilotSetting)
    {
        public static CopilotSetting New(string @id, global::Pulumi.AzureNative.PortalServices.CopilotSettingArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new CopilotSetting(@id, @args, @options);
        }

        public static CopilotSetting New(string @id, global::System.Action<global::Pulumi.AzureNative.PortalServices.CopilotSettingArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.PortalServices.CopilotSettingArgs @args = new();
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

            return new CopilotSetting(@id, @args, @options);
        }

    }

}
