// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.IoTHub.Inputs;

namespace Pulumi.AzureNative.IoTHub;

public static partial class ManagedIdentityArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTHub.Inputs.ManagedIdentityArgs WithUserAssignedIdentity(this global::Pulumi.AzureNative.IoTHub.Inputs.ManagedIdentityArgs @selfRef, global::System.String userAssignedIdentity)
    {
        @selfRef.UserAssignedIdentity = userAssignedIdentity;
        return @selfRef;
    }

}
