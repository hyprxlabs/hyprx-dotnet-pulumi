// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridCompute.Inputs;

namespace Pulumi.AzureNative.HybridCompute;

public static partial class RunCommandManagedIdentityArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridCompute.Inputs.RunCommandManagedIdentityArgs WithClientId(this global::Pulumi.AzureNative.HybridCompute.Inputs.RunCommandManagedIdentityArgs @selfRef, global::System.String clientId)
    {
        @selfRef.ClientId = clientId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridCompute.Inputs.RunCommandManagedIdentityArgs WithObjectId(this global::Pulumi.AzureNative.HybridCompute.Inputs.RunCommandManagedIdentityArgs @selfRef, global::System.String objectId)
    {
        @selfRef.ObjectId = objectId;
        return @selfRef;
    }

}
