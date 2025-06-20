// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Acmpca.Inputs;

namespace Pulumi.AwsNative.Acmpca;

public static partial class CertificatePolicyInformationArgsExtensions
{
    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificatePolicyInformationArgs WithCertPolicyId(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificatePolicyInformationArgs @selfRef, global::System.String certPolicyId)
    {
        @selfRef.CertPolicyId = certPolicyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificatePolicyInformationArgs WithPolicyQualifiers(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificatePolicyInformationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Acmpca.Inputs.CertificatePolicyQualifierInfoArgs> policyQualifiers)
    {
        @selfRef.PolicyQualifiers = policyQualifiers;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificatePolicyInformationArgs WithPolicyQualifiers(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificatePolicyInformationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Acmpca.Inputs.CertificatePolicyQualifierInfoArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Acmpca.Inputs.CertificatePolicyQualifierInfoArgs>();
        @configure(@list);
        @selfRef.PolicyQualifiers = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificatePolicyInformationArgs WithPolicyQualifiers(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificatePolicyInformationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Acmpca.Inputs.CertificatePolicyQualifierInfoArgs>> @create)
    {
        @selfRef.PolicyQualifiers = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
