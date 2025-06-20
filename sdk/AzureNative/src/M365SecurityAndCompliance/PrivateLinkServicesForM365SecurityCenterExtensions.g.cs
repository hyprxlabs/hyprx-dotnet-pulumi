// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.M365SecurityAndCompliance;

public static partial class PrivateLinkServicesForM365SecurityCenterExtensions
{

    extension(PrivateLinkServicesForM365SecurityCenter)
    {
        public static PrivateLinkServicesForM365SecurityCenter New(string @id, global::Pulumi.AzureNative.M365SecurityAndCompliance.PrivateLinkServicesForM365SecurityCenterArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new PrivateLinkServicesForM365SecurityCenter(@id, @args, @options);
        }

        public static PrivateLinkServicesForM365SecurityCenter New(string @id, global::System.Action<global::Pulumi.AzureNative.M365SecurityAndCompliance.PrivateLinkServicesForM365SecurityCenterArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.M365SecurityAndCompliance.PrivateLinkServicesForM365SecurityCenterArgs @args = new();
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

            return new PrivateLinkServicesForM365SecurityCenter(@id, @args, @options);
        }

    }

}
