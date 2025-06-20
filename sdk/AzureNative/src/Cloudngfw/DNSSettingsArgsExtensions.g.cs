// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Cloudngfw.Inputs;

namespace Pulumi.AzureNative.Cloudngfw;

public static partial class DNSSettingsArgsExtensions
{
    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.DNSSettingsArgs WithDnsServers(this global::Pulumi.AzureNative.Cloudngfw.Inputs.DNSSettingsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Cloudngfw.Inputs.IPAddressArgs> dnsServers)
    {
        @selfRef.DnsServers = dnsServers;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.DNSSettingsArgs WithDnsServers(this global::Pulumi.AzureNative.Cloudngfw.Inputs.DNSSettingsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Cloudngfw.Inputs.IPAddressArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Cloudngfw.Inputs.IPAddressArgs>();
        @configure(@list);
        @selfRef.DnsServers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.DNSSettingsArgs WithDnsServers(this global::Pulumi.AzureNative.Cloudngfw.Inputs.DNSSettingsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Cloudngfw.Inputs.IPAddressArgs>> @create)
    {
        @selfRef.DnsServers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.DNSSettingsArgs WithEnableDnsProxy(this global::Pulumi.AzureNative.Cloudngfw.Inputs.DNSSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cloudngfw.DNSProxy> enableDnsProxy)
    {
        @selfRef.EnableDnsProxy = enableDnsProxy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Cloudngfw.Inputs.DNSSettingsArgs WithEnabledDnsType(this global::Pulumi.AzureNative.Cloudngfw.Inputs.DNSSettingsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Cloudngfw.EnabledDNSType> enabledDnsType)
    {
        @selfRef.EnabledDnsType = enabledDnsType;
        return @selfRef;
    }

}
