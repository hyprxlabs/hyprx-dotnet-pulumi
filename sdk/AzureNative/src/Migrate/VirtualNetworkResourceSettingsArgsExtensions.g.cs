// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Migrate.Inputs;

namespace Pulumi.AzureNative.Migrate;

public static partial class VirtualNetworkResourceSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithAddressSpace(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> addressSpace)
    {
        @selfRef.AddressSpace = addressSpace;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithAddressSpace(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AddressSpace = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithAddressSpace(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AddressSpace = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithDnsServers(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.Collections.Generic.List<global::System.String> dnsServers)
    {
        @selfRef.DnsServers = dnsServers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithDnsServers(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.DnsServers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithDnsServers(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.DnsServers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithEnableDdosProtection(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, bool enableDdosProtection = true)
    {
        @selfRef.EnableDdosProtection = enableDdosProtection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithResourceType(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.String resourceType)
    {
        @selfRef.ResourceType = resourceType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithSubnets(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.SubnetResourceSettingsArgs> subnets)
    {
        @selfRef.Subnets = subnets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithSubnets(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.SubnetResourceSettingsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Migrate.Inputs.SubnetResourceSettingsArgs>();
        @configure(@list);
        @selfRef.Subnets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithSubnets(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Migrate.Inputs.SubnetResourceSettingsArgs>> @create)
    {
        @selfRef.Subnets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithTags(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithTags(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithTags(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithTargetResourceGroupName(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.String targetResourceGroupName)
    {
        @selfRef.TargetResourceGroupName = targetResourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs WithTargetResourceName(this global::Pulumi.AzureNative.Migrate.Inputs.VirtualNetworkResourceSettingsArgs @selfRef, global::System.String targetResourceName)
    {
        @selfRef.TargetResourceName = targetResourceName;
        return @selfRef;
    }

}
