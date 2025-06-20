// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ConfidentialLedger.Inputs;

namespace Pulumi.AzureNative.ConfidentialLedger;

public static partial class MemberIdentityCertificateArgsExtensions
{
    public static global::Pulumi.AzureNative.ConfidentialLedger.Inputs.MemberIdentityCertificateArgs WithCertificate(this global::Pulumi.AzureNative.ConfidentialLedger.Inputs.MemberIdentityCertificateArgs @selfRef, global::System.String certificate)
    {
        @selfRef.Certificate = certificate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.Inputs.MemberIdentityCertificateArgs WithEncryptionkey(this global::Pulumi.AzureNative.ConfidentialLedger.Inputs.MemberIdentityCertificateArgs @selfRef, global::System.String encryptionkey)
    {
        @selfRef.Encryptionkey = encryptionkey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.Inputs.MemberIdentityCertificateArgs WithTags(this global::Pulumi.AzureNative.ConfidentialLedger.Inputs.MemberIdentityCertificateArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ConfidentialLedger.Inputs.CertificateTagsArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.Inputs.MemberIdentityCertificateArgs WithTags(this global::Pulumi.AzureNative.ConfidentialLedger.Inputs.MemberIdentityCertificateArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ConfidentialLedger.Inputs.CertificateTagsArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ConfidentialLedger.Inputs.CertificateTagsArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ConfidentialLedger.Inputs.MemberIdentityCertificateArgs WithTags(this global::Pulumi.AzureNative.ConfidentialLedger.Inputs.MemberIdentityCertificateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ConfidentialLedger.Inputs.CertificateTagsArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
