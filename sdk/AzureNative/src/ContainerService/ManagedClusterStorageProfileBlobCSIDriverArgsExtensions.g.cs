// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class ManagedClusterStorageProfileBlobCSIDriverArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterStorageProfileBlobCSIDriverArgs WithEnabled(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterStorageProfileBlobCSIDriverArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

}
