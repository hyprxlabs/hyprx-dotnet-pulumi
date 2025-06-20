// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridContainerService.Inputs;

namespace Pulumi.AzureNative.HybridContainerService;

public static partial class WindowsProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.WindowsProfileArgs WithAdminPassword(this global::Pulumi.AzureNative.HybridContainerService.Inputs.WindowsProfileArgs @selfRef, global::System.String adminPassword)
    {
        @selfRef.AdminPassword = adminPassword;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.WindowsProfileArgs WithAdminUsername(this global::Pulumi.AzureNative.HybridContainerService.Inputs.WindowsProfileArgs @selfRef, global::System.String adminUsername)
    {
        @selfRef.AdminUsername = adminUsername;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.WindowsProfileArgs WithEnableCsiProxy(this global::Pulumi.AzureNative.HybridContainerService.Inputs.WindowsProfileArgs @selfRef, bool enableCsiProxy = true)
    {
        @selfRef.EnableCsiProxy = enableCsiProxy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.WindowsProfileArgs WithLicenseType(this global::Pulumi.AzureNative.HybridContainerService.Inputs.WindowsProfileArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.HybridContainerService.LicenseType> licenseType)
    {
        @selfRef.LicenseType = licenseType;
        return @selfRef;
    }

}
