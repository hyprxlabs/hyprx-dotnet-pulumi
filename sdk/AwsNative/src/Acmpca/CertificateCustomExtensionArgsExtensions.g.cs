// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Acmpca.Inputs;

namespace Pulumi.AwsNative.Acmpca;

public static partial class CertificateCustomExtensionArgsExtensions
{
    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateCustomExtensionArgs WithCritical(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateCustomExtensionArgs @selfRef, bool critical = true)
    {
        @selfRef.Critical = critical;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateCustomExtensionArgs WithObjectIdentifier(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateCustomExtensionArgs @selfRef, global::System.String objectIdentifier)
    {
        @selfRef.ObjectIdentifier = objectIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateCustomExtensionArgs WithValue(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateCustomExtensionArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
