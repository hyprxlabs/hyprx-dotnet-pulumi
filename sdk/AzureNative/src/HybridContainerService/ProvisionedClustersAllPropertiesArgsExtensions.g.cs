// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridContainerService.Inputs;

namespace Pulumi.AzureNative.HybridContainerService;

public static partial class ProvisionedClustersAllPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithAadProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::Pulumi.AzureNative.HybridContainerService.Inputs.AADProfileArgs aadProfile)
    {
        @selfRef.AadProfile = aadProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithAadProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridContainerService.Inputs.AADProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridContainerService.Inputs.AADProfileArgs();
        @configure(@item);
        @selfRef.AadProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithAddonProfiles(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.HybridContainerService.Inputs.AddonProfilesArgs> addonProfiles)
    {
        @selfRef.AddonProfiles = addonProfiles;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithAddonProfiles(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.HybridContainerService.Inputs.AddonProfilesArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.HybridContainerService.Inputs.AddonProfilesArgs>();
        @configure(@dict);
        @selfRef.AddonProfiles = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithAddonProfiles(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.HybridContainerService.Inputs.AddonProfilesArgs>> @create)
    {
        @selfRef.AddonProfiles = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithAgentPoolProfiles(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.HybridContainerService.Inputs.NamedAgentPoolProfileArgs> agentPoolProfiles)
    {
        @selfRef.AgentPoolProfiles = agentPoolProfiles;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithAgentPoolProfiles(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.HybridContainerService.Inputs.NamedAgentPoolProfileArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.HybridContainerService.Inputs.NamedAgentPoolProfileArgs>();
        @configure(@list);
        @selfRef.AgentPoolProfiles = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithAgentPoolProfiles(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.HybridContainerService.Inputs.NamedAgentPoolProfileArgs>> @create)
    {
        @selfRef.AgentPoolProfiles = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithCloudProviderProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::Pulumi.AzureNative.HybridContainerService.Inputs.CloudProviderProfileArgs cloudProviderProfile)
    {
        @selfRef.CloudProviderProfile = cloudProviderProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithCloudProviderProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridContainerService.Inputs.CloudProviderProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridContainerService.Inputs.CloudProviderProfileArgs();
        @configure(@item);
        @selfRef.CloudProviderProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithControlPlane(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::Pulumi.AzureNative.HybridContainerService.Inputs.ControlPlaneProfileArgs controlPlane)
    {
        @selfRef.ControlPlane = controlPlane;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithControlPlane(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridContainerService.Inputs.ControlPlaneProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridContainerService.Inputs.ControlPlaneProfileArgs();
        @configure(@item);
        @selfRef.ControlPlane = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithEnableRbac(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, bool enableRbac = true)
    {
        @selfRef.EnableRbac = enableRbac;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithFeatures(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersCommonPropertiesFeaturesArgs features)
    {
        @selfRef.Features = features;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithFeatures(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersCommonPropertiesFeaturesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersCommonPropertiesFeaturesArgs();
        @configure(@item);
        @selfRef.Features = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithHttpProxyConfig(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::Pulumi.AzureNative.HybridContainerService.Inputs.HttpProxyConfigArgs httpProxyConfig)
    {
        @selfRef.HttpProxyConfig = httpProxyConfig;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithHttpProxyConfig(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridContainerService.Inputs.HttpProxyConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridContainerService.Inputs.HttpProxyConfigArgs();
        @configure(@item);
        @selfRef.HttpProxyConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithKubernetesVersion(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.String kubernetesVersion)
    {
        @selfRef.KubernetesVersion = kubernetesVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithLinuxProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::Pulumi.AzureNative.HybridContainerService.Inputs.LinuxProfilePropertiesArgs linuxProfile)
    {
        @selfRef.LinuxProfile = linuxProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithLinuxProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridContainerService.Inputs.LinuxProfilePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridContainerService.Inputs.LinuxProfilePropertiesArgs();
        @configure(@item);
        @selfRef.LinuxProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithNetworkProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::Pulumi.AzureNative.HybridContainerService.Inputs.NetworkProfileArgs networkProfile)
    {
        @selfRef.NetworkProfile = networkProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithNetworkProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridContainerService.Inputs.NetworkProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridContainerService.Inputs.NetworkProfileArgs();
        @configure(@item);
        @selfRef.NetworkProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithNodeResourceGroup(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.String nodeResourceGroup)
    {
        @selfRef.NodeResourceGroup = nodeResourceGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithWindowsProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::Pulumi.AzureNative.HybridContainerService.Inputs.WindowsProfileArgs windowsProfile)
    {
        @selfRef.WindowsProfile = windowsProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs WithWindowsProfile(this global::Pulumi.AzureNative.HybridContainerService.Inputs.ProvisionedClustersAllPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridContainerService.Inputs.WindowsProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridContainerService.Inputs.WindowsProfileArgs();
        @configure(@item);
        @selfRef.WindowsProfile = @item;
        return @selfRef;
    }

}
