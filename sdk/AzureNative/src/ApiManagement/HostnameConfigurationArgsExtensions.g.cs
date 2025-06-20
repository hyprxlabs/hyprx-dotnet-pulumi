// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ApiManagement.Inputs;

namespace Pulumi.AzureNative.ApiManagement;

public static partial class HostnameConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs WithCertificate(this global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs @selfRef, global::Pulumi.AzureNative.ApiManagement.Inputs.CertificateInformationArgs certificate)
    {
        @selfRef.Certificate = certificate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs WithCertificate(this global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ApiManagement.Inputs.CertificateInformationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ApiManagement.Inputs.CertificateInformationArgs();
        @configure(@item);
        @selfRef.Certificate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs WithCertificatePassword(this global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs @selfRef, global::System.String certificatePassword)
    {
        @selfRef.CertificatePassword = certificatePassword;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs WithCertificateSource(this global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.CertificateSource> certificateSource)
    {
        @selfRef.CertificateSource = certificateSource;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs WithCertificateStatus(this global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.CertificateStatus> certificateStatus)
    {
        @selfRef.CertificateStatus = certificateStatus;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs WithDefaultSslBinding(this global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs @selfRef, bool defaultSslBinding = true)
    {
        @selfRef.DefaultSslBinding = defaultSslBinding;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs WithEncodedCertificate(this global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs @selfRef, global::System.String encodedCertificate)
    {
        @selfRef.EncodedCertificate = encodedCertificate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs WithHostName(this global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs @selfRef, global::System.String hostName)
    {
        @selfRef.HostName = hostName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs WithIdentityClientId(this global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs @selfRef, global::System.String identityClientId)
    {
        @selfRef.IdentityClientId = identityClientId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs WithKeyVaultId(this global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs @selfRef, global::System.String keyVaultId)
    {
        @selfRef.KeyVaultId = keyVaultId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs WithNegotiateClientCertificate(this global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs @selfRef, bool negotiateClientCertificate = true)
    {
        @selfRef.NegotiateClientCertificate = negotiateClientCertificate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs WithType(this global::Pulumi.AzureNative.ApiManagement.Inputs.HostnameConfigurationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ApiManagement.HostnameType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
