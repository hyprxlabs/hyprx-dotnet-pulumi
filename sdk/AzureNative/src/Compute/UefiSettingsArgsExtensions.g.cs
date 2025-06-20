// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class UefiSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.UefiSettingsArgs WithSecureBootEnabled(this global::Pulumi.AzureNative.Compute.Inputs.UefiSettingsArgs @selfRef, bool secureBootEnabled = true)
    {
        @selfRef.SecureBootEnabled = secureBootEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.UefiSettingsArgs WithVTpmEnabled(this global::Pulumi.AzureNative.Compute.Inputs.UefiSettingsArgs @selfRef, bool vTpmEnabled = true)
    {
        @selfRef.VTpmEnabled = vTpmEnabled;
        return @selfRef;
    }

}
