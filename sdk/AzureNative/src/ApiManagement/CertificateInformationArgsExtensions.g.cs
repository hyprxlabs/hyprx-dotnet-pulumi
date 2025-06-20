// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ApiManagement.Inputs;

namespace Pulumi.AzureNative.ApiManagement;

public static partial class CertificateInformationArgsExtensions
{
    public static global::Pulumi.AzureNative.ApiManagement.Inputs.CertificateInformationArgs WithExpiry(this global::Pulumi.AzureNative.ApiManagement.Inputs.CertificateInformationArgs @selfRef, global::System.String expiry)
    {
        @selfRef.Expiry = expiry;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.CertificateInformationArgs WithSubject(this global::Pulumi.AzureNative.ApiManagement.Inputs.CertificateInformationArgs @selfRef, global::System.String subject)
    {
        @selfRef.Subject = subject;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.CertificateInformationArgs WithThumbprint(this global::Pulumi.AzureNative.ApiManagement.Inputs.CertificateInformationArgs @selfRef, global::System.String thumbprint)
    {
        @selfRef.Thumbprint = thumbprint;
        return @selfRef;
    }

}
