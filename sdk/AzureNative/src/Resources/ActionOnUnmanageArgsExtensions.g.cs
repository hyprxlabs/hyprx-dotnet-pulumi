// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Resources.Inputs;

namespace Pulumi.AzureNative.Resources;

public static partial class ActionOnUnmanageArgsExtensions
{
    public static global::Pulumi.AzureNative.Resources.Inputs.ActionOnUnmanageArgs WithManagementGroups(this global::Pulumi.AzureNative.Resources.Inputs.ActionOnUnmanageArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Resources.DeploymentStacksDeleteDetachEnum> managementGroups)
    {
        @selfRef.ManagementGroups = managementGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Resources.Inputs.ActionOnUnmanageArgs WithResourceGroups(this global::Pulumi.AzureNative.Resources.Inputs.ActionOnUnmanageArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Resources.DeploymentStacksDeleteDetachEnum> resourceGroups)
    {
        @selfRef.ResourceGroups = resourceGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Resources.Inputs.ActionOnUnmanageArgs WithResources(this global::Pulumi.AzureNative.Resources.Inputs.ActionOnUnmanageArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Resources.DeploymentStacksDeleteDetachEnum> resources)
    {
        @selfRef.Resources = resources;
        return @selfRef;
    }

}
