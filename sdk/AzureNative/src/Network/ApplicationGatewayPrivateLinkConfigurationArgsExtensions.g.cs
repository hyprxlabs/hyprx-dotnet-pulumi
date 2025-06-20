// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class ApplicationGatewayPrivateLinkConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkConfigurationArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkConfigurationArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkConfigurationArgs WithIpConfigurations(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkIpConfigurationArgs> ipConfigurations)
    {
        @selfRef.IpConfigurations = ipConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkConfigurationArgs WithIpConfigurations(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkIpConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkIpConfigurationArgs>();
        @configure(@list);
        @selfRef.IpConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkConfigurationArgs WithIpConfigurations(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkIpConfigurationArgs>> @create)
    {
        @selfRef.IpConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkConfigurationArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayPrivateLinkConfigurationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
