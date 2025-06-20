// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApiManagement;

public static partial class GatewayHostnameConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs WithCertificateId(this global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs @selfRef, global::System.String certificateId)
    {
        @selfRef.CertificateId = certificateId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs WithGatewayId(this global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs @selfRef, global::System.String gatewayId)
    {
        @selfRef.GatewayId = gatewayId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs WithHcId(this global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs @selfRef, global::System.String hcId)
    {
        @selfRef.HcId = hcId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs WithHostname(this global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs @selfRef, global::System.String hostname)
    {
        @selfRef.Hostname = hostname;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs WithHttp2Enabled(this global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs @selfRef, bool http2Enabled = true)
    {
        @selfRef.Http2Enabled = http2Enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs WithNegotiateClientCertificate(this global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs @selfRef, bool negotiateClientCertificate = true)
    {
        @selfRef.NegotiateClientCertificate = negotiateClientCertificate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs WithResourceGroupName(this global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs WithServiceName(this global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs @selfRef, global::System.String serviceName)
    {
        @selfRef.ServiceName = serviceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs WithTls10Enabled(this global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs @selfRef, bool tls10Enabled = true)
    {
        @selfRef.Tls10Enabled = tls10Enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs WithTls11Enabled(this global::Pulumi.AzureNative.ApiManagement.GatewayHostnameConfigurationArgs @selfRef, bool tls11Enabled = true)
    {
        @selfRef.Tls11Enabled = tls11Enabled;
        return @selfRef;
    }

}
