// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Web;

public static partial class WebAppSourceControlSlotArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs WithBranch(this global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs @selfRef, global::System.String branch)
    {
        @selfRef.Branch = branch;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs WithDeploymentRollbackEnabled(this global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs @selfRef, bool deploymentRollbackEnabled = true)
    {
        @selfRef.DeploymentRollbackEnabled = deploymentRollbackEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs WithGitHubActionConfiguration(this global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs @selfRef, global::Pulumi.AzureNative.Web.Inputs.GitHubActionConfigurationArgs gitHubActionConfiguration)
    {
        @selfRef.GitHubActionConfiguration = gitHubActionConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs WithGitHubActionConfiguration(this global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.Inputs.GitHubActionConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Web.Inputs.GitHubActionConfigurationArgs();
        @configure(@item);
        @selfRef.GitHubActionConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs WithIsGitHubAction(this global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs @selfRef, bool isGitHubAction = true)
    {
        @selfRef.IsGitHubAction = isGitHubAction;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs WithIsManualIntegration(this global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs @selfRef, bool isManualIntegration = true)
    {
        @selfRef.IsManualIntegration = isManualIntegration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs WithIsMercurial(this global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs @selfRef, bool isMercurial = true)
    {
        @selfRef.IsMercurial = isMercurial;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs WithKind(this global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs @selfRef, global::System.String kind)
    {
        @selfRef.Kind = kind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs WithName(this global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs WithRepoUrl(this global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs @selfRef, global::System.String repoUrl)
    {
        @selfRef.RepoUrl = repoUrl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs WithResourceGroupName(this global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs WithSlot(this global::Pulumi.AzureNative.Web.WebAppSourceControlSlotArgs @selfRef, global::System.String slot)
    {
        @selfRef.Slot = slot;
        return @selfRef;
    }

}
