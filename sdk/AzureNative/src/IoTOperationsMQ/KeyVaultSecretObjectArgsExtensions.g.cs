// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTOperationsMQ.Inputs;

namespace Pulumi.AzureNative.IoTOperationsMQ;

public static partial class KeyVaultSecretObjectArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KeyVaultSecretObjectArgs WithName(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KeyVaultSecretObjectArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KeyVaultSecretObjectArgs WithVersion(this global::Pulumi.AzureNative.IoTOperationsMQ.Inputs.KeyVaultSecretObjectArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
