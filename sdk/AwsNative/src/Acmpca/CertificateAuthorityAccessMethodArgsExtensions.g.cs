// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Acmpca.Inputs;

namespace Pulumi.AwsNative.Acmpca;

public static partial class CertificateAuthorityAccessMethodArgsExtensions
{
    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthorityAccessMethodArgs WithAccessMethodType(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthorityAccessMethodArgs @selfRef, global::System.String accessMethodType)
    {
        @selfRef.AccessMethodType = accessMethodType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthorityAccessMethodArgs WithCustomObjectIdentifier(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthorityAccessMethodArgs @selfRef, global::System.String customObjectIdentifier)
    {
        @selfRef.CustomObjectIdentifier = customObjectIdentifier;
        return @selfRef;
    }

}
