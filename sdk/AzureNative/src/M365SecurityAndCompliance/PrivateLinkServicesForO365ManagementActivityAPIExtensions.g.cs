// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.M365SecurityAndCompliance;

public static partial class PrivateLinkServicesForO365ManagementActivityAPIExtensions
{

    extension(PrivateLinkServicesForO365ManagementActivityAPI)
    {
        public static PrivateLinkServicesForO365ManagementActivityAPI New(string @id, global::Pulumi.AzureNative.M365SecurityAndCompliance.PrivateLinkServicesForO365ManagementActivityAPIArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new PrivateLinkServicesForO365ManagementActivityAPI(@id, @args, @options);
        }

        public static PrivateLinkServicesForO365ManagementActivityAPI New(string @id, global::System.Action<global::Pulumi.AzureNative.M365SecurityAndCompliance.PrivateLinkServicesForO365ManagementActivityAPIArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.M365SecurityAndCompliance.PrivateLinkServicesForO365ManagementActivityAPIArgs @args = new();
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

            return new PrivateLinkServicesForO365ManagementActivityAPI(@id, @args, @options);
        }

    }

}
