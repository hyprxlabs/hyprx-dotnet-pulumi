// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DevHub.Inputs;

namespace Pulumi.AzureNative.DevHub;

public static partial class GitHubWorkflowProfileOidcCredentialsArgsExtensions
{
    public static global::Pulumi.AzureNative.DevHub.Inputs.GitHubWorkflowProfileOidcCredentialsArgs WithAzureClientId(this global::Pulumi.AzureNative.DevHub.Inputs.GitHubWorkflowProfileOidcCredentialsArgs @selfRef, global::System.String azureClientId)
    {
        @selfRef.AzureClientId = azureClientId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DevHub.Inputs.GitHubWorkflowProfileOidcCredentialsArgs WithAzureTenantId(this global::Pulumi.AzureNative.DevHub.Inputs.GitHubWorkflowProfileOidcCredentialsArgs @selfRef, global::System.String azureTenantId)
    {
        @selfRef.AzureTenantId = azureTenantId;
        return @selfRef;
    }

}
