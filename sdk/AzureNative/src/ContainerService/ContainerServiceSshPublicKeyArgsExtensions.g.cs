// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class ContainerServiceSshPublicKeyArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.ContainerServiceSshPublicKeyArgs WithKeyData(this global::Pulumi.AzureNative.ContainerService.Inputs.ContainerServiceSshPublicKeyArgs @selfRef, global::System.String keyData)
    {
        @selfRef.KeyData = keyData;
        return @selfRef;
    }

}
