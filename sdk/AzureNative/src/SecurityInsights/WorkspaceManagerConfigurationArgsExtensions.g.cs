// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class WorkspaceManagerConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.WorkspaceManagerConfigurationArgs WithMode(this global::Pulumi.AzureNative.SecurityInsights.WorkspaceManagerConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SecurityInsights.Mode> mode)
    {
        @selfRef.Mode = mode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WorkspaceManagerConfigurationArgs WithResourceGroupName(this global::Pulumi.AzureNative.SecurityInsights.WorkspaceManagerConfigurationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WorkspaceManagerConfigurationArgs WithWorkspaceManagerConfigurationName(this global::Pulumi.AzureNative.SecurityInsights.WorkspaceManagerConfigurationArgs @selfRef, global::System.String workspaceManagerConfigurationName)
    {
        @selfRef.WorkspaceManagerConfigurationName = workspaceManagerConfigurationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WorkspaceManagerConfigurationArgs WithWorkspaceName(this global::Pulumi.AzureNative.SecurityInsights.WorkspaceManagerConfigurationArgs @selfRef, global::System.String workspaceName)
    {
        @selfRef.WorkspaceName = workspaceName;
        return @selfRef;
    }

}
