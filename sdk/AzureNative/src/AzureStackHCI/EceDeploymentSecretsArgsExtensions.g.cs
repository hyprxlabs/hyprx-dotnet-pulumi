// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureStackHCI.Inputs;

namespace Pulumi.AzureNative.AzureStackHCI;

public static partial class EceDeploymentSecretsArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.EceDeploymentSecretsArgs WithEceSecretName(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.EceDeploymentSecretsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AzureStackHCI.EceSecrets> eceSecretName)
    {
        @selfRef.EceSecretName = eceSecretName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.EceDeploymentSecretsArgs WithSecretLocation(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.EceDeploymentSecretsArgs @selfRef, global::System.String secretLocation)
    {
        @selfRef.SecretLocation = secretLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.Inputs.EceDeploymentSecretsArgs WithSecretName(this global::Pulumi.AzureNative.AzureStackHCI.Inputs.EceDeploymentSecretsArgs @selfRef, global::System.String secretName)
    {
        @selfRef.SecretName = secretName;
        return @selfRef;
    }

}
