// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class ComponentSetupArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.ComponentSetupArgs WithComponentName(this global::Pulumi.AzureNative.DataFactory.Inputs.ComponentSetupArgs @selfRef, global::System.String componentName)
    {
        @selfRef.ComponentName = componentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ComponentSetupArgs WithLicenseKey(this global::Pulumi.AzureNative.DataFactory.Inputs.ComponentSetupArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs, global::Pulumi.AzureNative.DataFactory.Inputs.SecureStringArgs> licenseKey)
    {
        @selfRef.LicenseKey = licenseKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.ComponentSetupArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.ComponentSetupArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
