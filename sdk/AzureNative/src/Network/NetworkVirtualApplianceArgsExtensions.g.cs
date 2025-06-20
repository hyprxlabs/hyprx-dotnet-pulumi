// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Network;

public static partial class NetworkVirtualApplianceArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithAdditionalNics(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceAdditionalNicPropertiesArgs> additionalNics)
    {
        @selfRef.AdditionalNics = additionalNics;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithAdditionalNics(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceAdditionalNicPropertiesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceAdditionalNicPropertiesArgs>();
        @configure(@list);
        @selfRef.AdditionalNics = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithAdditionalNics(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceAdditionalNicPropertiesArgs>> @create)
    {
        @selfRef.AdditionalNics = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithBootStrapConfigurationBlobs(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> bootStrapConfigurationBlobs)
    {
        @selfRef.BootStrapConfigurationBlobs = bootStrapConfigurationBlobs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithBootStrapConfigurationBlobs(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.BootStrapConfigurationBlobs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithBootStrapConfigurationBlobs(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.BootStrapConfigurationBlobs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithCloudInitConfiguration(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.String cloudInitConfiguration)
    {
        @selfRef.CloudInitConfiguration = cloudInitConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithCloudInitConfigurationBlobs(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Collections.Generic.List<global::System.String> cloudInitConfigurationBlobs)
    {
        @selfRef.CloudInitConfigurationBlobs = cloudInitConfigurationBlobs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithCloudInitConfigurationBlobs(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.CloudInitConfigurationBlobs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithCloudInitConfigurationBlobs(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.CloudInitConfigurationBlobs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithDelegation(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.DelegationPropertiesArgs delegation)
    {
        @selfRef.Delegation = delegation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithDelegation(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.DelegationPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.DelegationPropertiesArgs();
        @configure(@item);
        @selfRef.Delegation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithId(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithIdentity(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs identity)
    {
        @selfRef.Identity = identity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithIdentity(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.ManagedServiceIdentityArgs();
        @configure(@item);
        @selfRef.Identity = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithInternetIngressPublicIps(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.InternetIngressPublicIpsPropertiesArgs> internetIngressPublicIps)
    {
        @selfRef.InternetIngressPublicIps = internetIngressPublicIps;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithInternetIngressPublicIps(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.InternetIngressPublicIpsPropertiesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.InternetIngressPublicIpsPropertiesArgs>();
        @configure(@list);
        @selfRef.InternetIngressPublicIps = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithInternetIngressPublicIps(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.InternetIngressPublicIpsPropertiesArgs>> @create)
    {
        @selfRef.InternetIngressPublicIps = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithLocation(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithNetworkProfile(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.NetworkVirtualAppliancePropertiesFormatNetworkProfileArgs networkProfile)
    {
        @selfRef.NetworkProfile = networkProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithNetworkProfile(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.NetworkVirtualAppliancePropertiesFormatNetworkProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.NetworkVirtualAppliancePropertiesFormatNetworkProfileArgs();
        @configure(@item);
        @selfRef.NetworkProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithNetworkVirtualApplianceName(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.String networkVirtualApplianceName)
    {
        @selfRef.NetworkVirtualApplianceName = networkVirtualApplianceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithNvaSku(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceSkuPropertiesArgs nvaSku)
    {
        @selfRef.NvaSku = nvaSku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithNvaSku(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceSkuPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.VirtualApplianceSkuPropertiesArgs();
        @configure(@item);
        @selfRef.NvaSku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithResourceGroupName(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithSshPublicKey(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.String sshPublicKey)
    {
        @selfRef.SshPublicKey = sshPublicKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithTags(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithTags(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithTags(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithVirtualApplianceAsn(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Double virtualApplianceAsn)
    {
        @selfRef.VirtualApplianceAsn = virtualApplianceAsn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithVirtualHub(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs virtualHub)
    {
        @selfRef.VirtualHub = virtualHub;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs WithVirtualHub(this global::Pulumi.AzureNative.Network.NetworkVirtualApplianceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.VirtualHub = @item;
        return @selfRef;
    }

}
