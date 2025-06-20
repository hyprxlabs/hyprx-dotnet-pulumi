// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class ManagedClusterPodIdentityProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs WithAllowNetworkPluginKubenet(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs @selfRef, bool allowNetworkPluginKubenet = true)
    {
        @selfRef.AllowNetworkPluginKubenet = allowNetworkPluginKubenet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs WithEnabled(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityArgs> userAssignedIdentities)
    {
        @selfRef.UserAssignedIdentities = userAssignedIdentities;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityArgs>();
        @configure(@list);
        @selfRef.UserAssignedIdentities = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs WithUserAssignedIdentities(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityArgs>> @create)
    {
        @selfRef.UserAssignedIdentities = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs WithUserAssignedIdentityExceptions(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityExceptionArgs> userAssignedIdentityExceptions)
    {
        @selfRef.UserAssignedIdentityExceptions = userAssignedIdentityExceptions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs WithUserAssignedIdentityExceptions(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityExceptionArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityExceptionArgs>();
        @configure(@list);
        @selfRef.UserAssignedIdentityExceptions = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs WithUserAssignedIdentityExceptions(this global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerService.Inputs.ManagedClusterPodIdentityExceptionArgs>> @create)
    {
        @selfRef.UserAssignedIdentityExceptions = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
