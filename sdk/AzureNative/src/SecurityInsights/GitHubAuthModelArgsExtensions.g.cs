// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SecurityInsights.Inputs;

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class GitHubAuthModelArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.GitHubAuthModelArgs WithInstallationId(this global::Pulumi.AzureNative.SecurityInsights.Inputs.GitHubAuthModelArgs @selfRef, global::System.String installationId)
    {
        @selfRef.InstallationId = installationId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.Inputs.GitHubAuthModelArgs WithType(this global::Pulumi.AzureNative.SecurityInsights.Inputs.GitHubAuthModelArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
