// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RecoveryServices.Inputs;

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class UserAssignedIdentityPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.UserAssignedIdentityPropertiesArgs WithClientId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.UserAssignedIdentityPropertiesArgs @selfRef, global::System.String clientId)
    {
        @selfRef.ClientId = clientId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.UserAssignedIdentityPropertiesArgs WithPrincipalId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.UserAssignedIdentityPropertiesArgs @selfRef, global::System.String principalId)
    {
        @selfRef.PrincipalId = principalId;
        return @selfRef;
    }

}
