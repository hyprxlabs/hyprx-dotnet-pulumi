// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class WorkspaceConnectionAccessKeyArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.WorkspaceConnectionAccessKeyArgs WithAccessKeyId(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.WorkspaceConnectionAccessKeyArgs @selfRef, global::System.String accessKeyId)
    {
        @selfRef.AccessKeyId = accessKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.WorkspaceConnectionAccessKeyArgs WithSecretAccessKey(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.WorkspaceConnectionAccessKeyArgs @selfRef, global::System.String secretAccessKey)
    {
        @selfRef.SecretAccessKey = secretAccessKey;
        return @selfRef;
    }

}
