// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Web;

public static partial class WebAppSlotConfigurationNamesExtensions
{

    extension(WebAppSlotConfigurationNames)
    {
        public static WebAppSlotConfigurationNames New(string @id, global::Pulumi.AzureNative.Web.WebAppSlotConfigurationNamesArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new WebAppSlotConfigurationNames(@id, @args, @options);
        }

        public static WebAppSlotConfigurationNames New(string @id, global::System.Action<global::Pulumi.AzureNative.Web.WebAppSlotConfigurationNamesArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Web.WebAppSlotConfigurationNamesArgs @args = new();
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

            return new WebAppSlotConfigurationNames(@id, @args, @options);
        }

    }

}
