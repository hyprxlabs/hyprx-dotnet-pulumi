// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class UserInitiatedRedeployArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.UserInitiatedRedeployArgs WithAutomaticallyApprove(this global::Pulumi.AzureNative.Compute.Inputs.UserInitiatedRedeployArgs @selfRef, bool automaticallyApprove = true)
    {
        @selfRef.AutomaticallyApprove = automaticallyApprove;
        return @selfRef;
    }

}
