// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.M365SecurityAndCompliance;

public static partial class PrivateLinkServicesForSCCPowershellExtensions
{

    extension(PrivateLinkServicesForSCCPowershell)
    {
        public static PrivateLinkServicesForSCCPowershell New(string @id, global::Pulumi.AzureNative.M365SecurityAndCompliance.PrivateLinkServicesForSCCPowershellArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new PrivateLinkServicesForSCCPowershell(@id, @args, @options);
        }

        public static PrivateLinkServicesForSCCPowershell New(string @id, global::System.Action<global::Pulumi.AzureNative.M365SecurityAndCompliance.PrivateLinkServicesForSCCPowershellArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.M365SecurityAndCompliance.PrivateLinkServicesForSCCPowershellArgs @args = new();
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

            return new PrivateLinkServicesForSCCPowershell(@id, @args, @options);
        }

    }

}
