// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ServiceFabric.Inputs;

namespace Pulumi.AzureNative.ServiceFabric;

public static partial class IpConfigurationPublicIPAddressConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.IpConfigurationPublicIPAddressConfigurationArgs WithIpTags(this global::Pulumi.AzureNative.ServiceFabric.Inputs.IpConfigurationPublicIPAddressConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.IpTagArgs> ipTags)
    {
        @selfRef.IpTags = ipTags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.IpConfigurationPublicIPAddressConfigurationArgs WithIpTags(this global::Pulumi.AzureNative.ServiceFabric.Inputs.IpConfigurationPublicIPAddressConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.IpTagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.IpTagArgs>();
        @configure(@list);
        @selfRef.IpTags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.IpConfigurationPublicIPAddressConfigurationArgs WithIpTags(this global::Pulumi.AzureNative.ServiceFabric.Inputs.IpConfigurationPublicIPAddressConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.IpTagArgs>> @create)
    {
        @selfRef.IpTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.IpConfigurationPublicIPAddressConfigurationArgs WithName(this global::Pulumi.AzureNative.ServiceFabric.Inputs.IpConfigurationPublicIPAddressConfigurationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.IpConfigurationPublicIPAddressConfigurationArgs WithPublicIPAddressVersion(this global::Pulumi.AzureNative.ServiceFabric.Inputs.IpConfigurationPublicIPAddressConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceFabric.PublicIPAddressVersion> publicIPAddressVersion)
    {
        @selfRef.PublicIPAddressVersion = publicIPAddressVersion;
        return @selfRef;
    }

}
