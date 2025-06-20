// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class P2SVpnServerConfigurationPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithEtag(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.String etag)
    {
        @selfRef.Etag = etag;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithP2SVpnServerConfigRadiusClientRootCertificates(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigRadiusClientRootCertificateArgs> p2SVpnServerConfigRadiusClientRootCertificates)
    {
        @selfRef.P2SVpnServerConfigRadiusClientRootCertificates = p2SVpnServerConfigRadiusClientRootCertificates;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithP2SVpnServerConfigRadiusClientRootCertificates(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigRadiusClientRootCertificateArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigRadiusClientRootCertificateArgs>();
        @configure(@list);
        @selfRef.P2SVpnServerConfigRadiusClientRootCertificates = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithP2SVpnServerConfigRadiusClientRootCertificates(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigRadiusClientRootCertificateArgs>> @create)
    {
        @selfRef.P2SVpnServerConfigRadiusClientRootCertificates = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithP2SVpnServerConfigRadiusServerRootCertificates(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigRadiusServerRootCertificateArgs> p2SVpnServerConfigRadiusServerRootCertificates)
    {
        @selfRef.P2SVpnServerConfigRadiusServerRootCertificates = p2SVpnServerConfigRadiusServerRootCertificates;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithP2SVpnServerConfigRadiusServerRootCertificates(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigRadiusServerRootCertificateArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigRadiusServerRootCertificateArgs>();
        @configure(@list);
        @selfRef.P2SVpnServerConfigRadiusServerRootCertificates = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithP2SVpnServerConfigRadiusServerRootCertificates(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigRadiusServerRootCertificateArgs>> @create)
    {
        @selfRef.P2SVpnServerConfigRadiusServerRootCertificates = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithP2SVpnServerConfigVpnClientRevokedCertificates(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigVpnClientRevokedCertificateArgs> p2SVpnServerConfigVpnClientRevokedCertificates)
    {
        @selfRef.P2SVpnServerConfigVpnClientRevokedCertificates = p2SVpnServerConfigVpnClientRevokedCertificates;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithP2SVpnServerConfigVpnClientRevokedCertificates(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigVpnClientRevokedCertificateArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigVpnClientRevokedCertificateArgs>();
        @configure(@list);
        @selfRef.P2SVpnServerConfigVpnClientRevokedCertificates = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithP2SVpnServerConfigVpnClientRevokedCertificates(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigVpnClientRevokedCertificateArgs>> @create)
    {
        @selfRef.P2SVpnServerConfigVpnClientRevokedCertificates = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithP2SVpnServerConfigVpnClientRootCertificates(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigVpnClientRootCertificateArgs> p2SVpnServerConfigVpnClientRootCertificates)
    {
        @selfRef.P2SVpnServerConfigVpnClientRootCertificates = p2SVpnServerConfigVpnClientRootCertificates;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithP2SVpnServerConfigVpnClientRootCertificates(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigVpnClientRootCertificateArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigVpnClientRootCertificateArgs>();
        @configure(@list);
        @selfRef.P2SVpnServerConfigVpnClientRootCertificates = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithP2SVpnServerConfigVpnClientRootCertificates(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigVpnClientRootCertificateArgs>> @create)
    {
        @selfRef.P2SVpnServerConfigVpnClientRootCertificates = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithRadiusServerAddress(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.String radiusServerAddress)
    {
        @selfRef.RadiusServerAddress = radiusServerAddress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithRadiusServerSecret(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.String radiusServerSecret)
    {
        @selfRef.RadiusServerSecret = radiusServerSecret;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithVpnClientIpsecPolicies(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.IpsecPolicyArgs> vpnClientIpsecPolicies)
    {
        @selfRef.VpnClientIpsecPolicies = vpnClientIpsecPolicies;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithVpnClientIpsecPolicies(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.IpsecPolicyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.IpsecPolicyArgs>();
        @configure(@list);
        @selfRef.VpnClientIpsecPolicies = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithVpnClientIpsecPolicies(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.IpsecPolicyArgs>> @create)
    {
        @selfRef.VpnClientIpsecPolicies = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithVpnProtocols(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.VpnGatewayTunnelingProtocol>> vpnProtocols)
    {
        @selfRef.VpnProtocols = vpnProtocols;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithVpnProtocols(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.VpnGatewayTunnelingProtocol>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.VpnGatewayTunnelingProtocol>>();
        @configure(@list);
        @selfRef.VpnProtocols = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs WithVpnProtocols(this global::Pulumi.AzureNative.Network.Inputs.P2SVpnServerConfigurationPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.VpnGatewayTunnelingProtocol>>> @create)
    {
        @selfRef.VpnProtocols = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
