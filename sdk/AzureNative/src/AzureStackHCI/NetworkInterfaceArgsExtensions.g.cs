// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AzureStackHCI;

public static partial class NetworkInterfaceArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithCreateFromLocal(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, bool createFromLocal = true)
    {
        @selfRef.CreateFromLocal = createFromLocal;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithDnsSettings(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.InterfaceDNSSettingsArgs dnsSettings)
    {
        @selfRef.DnsSettings = dnsSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithDnsSettings(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.InterfaceDNSSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.InterfaceDNSSettingsArgs();
        @configure(@item);
        @selfRef.DnsSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithExtendedLocation(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.ExtendedLocationArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithExtendedLocation(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.ExtendedLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.ExtendedLocationArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithIpConfigurations(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.IPConfigurationArgs> ipConfigurations)
    {
        @selfRef.IpConfigurations = ipConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithIpConfigurations(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.IPConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AzureStackHCI.Inputs.IPConfigurationArgs>();
        @configure(@list);
        @selfRef.IpConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithIpConfigurations(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AzureStackHCI.Inputs.IPConfigurationArgs>> @create)
    {
        @selfRef.IpConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithLocation(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithMacAddress(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.String macAddress)
    {
        @selfRef.MacAddress = macAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithNetworkInterfaceName(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.String networkInterfaceName)
    {
        @selfRef.NetworkInterfaceName = networkInterfaceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithNetworkSecurityGroup(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::Pulumi.AzureNative.AzureStackHCI.Inputs.NetworkSecurityGroupArmReferenceArgs networkSecurityGroup)
    {
        @selfRef.NetworkSecurityGroup = networkSecurityGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithNetworkSecurityGroup(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AzureStackHCI.Inputs.NetworkSecurityGroupArmReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AzureStackHCI.Inputs.NetworkSecurityGroupArmReferenceArgs();
        @configure(@item);
        @selfRef.NetworkSecurityGroup = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithResourceGroupName(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithTags(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithTags(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs WithTags(this global::Pulumi.AzureNative.AzureStackHCI.NetworkInterfaceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
