// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class ApplicationGatewayListenerArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithFrontendIPConfiguration(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs frontendIPConfiguration)
    {
        @selfRef.FrontendIPConfiguration = frontendIPConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithFrontendIPConfiguration(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.FrontendIPConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithFrontendPort(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs frontendPort)
    {
        @selfRef.FrontendPort = frontendPort;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithFrontendPort(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.FrontendPort = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithHostNames(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::System.Collections.Generic.List<global::System.String> hostNames)
    {
        @selfRef.HostNames = hostNames;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithHostNames(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.HostNames = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithHostNames(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.HostNames = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithProtocol(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.ApplicationGatewayProtocol> protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithSslCertificate(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs sslCertificate)
    {
        @selfRef.SslCertificate = sslCertificate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithSslCertificate(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.SslCertificate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithSslProfile(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs sslProfile)
    {
        @selfRef.SslProfile = sslProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs WithSslProfile(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayListenerArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Network.Inputs.SubResourceArgs();
        @configure(@item);
        @selfRef.SslProfile = @item;
        return @selfRef;
    }

}
