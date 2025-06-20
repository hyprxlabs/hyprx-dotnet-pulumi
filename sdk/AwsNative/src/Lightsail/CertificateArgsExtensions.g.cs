// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Lightsail;

public static partial class CertificateArgsExtensions
{
    public static global::Pulumi.AwsNative.Lightsail.CertificateArgs WithCertificateName(this global::Pulumi.AwsNative.Lightsail.CertificateArgs @selfRef, global::System.String certificateName)
    {
        @selfRef.CertificateName = certificateName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.CertificateArgs WithDomainName(this global::Pulumi.AwsNative.Lightsail.CertificateArgs @selfRef, global::System.String domainName)
    {
        @selfRef.DomainName = domainName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.CertificateArgs WithSubjectAlternativeNames(this global::Pulumi.AwsNative.Lightsail.CertificateArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subjectAlternativeNames)
    {
        @selfRef.SubjectAlternativeNames = subjectAlternativeNames;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.CertificateArgs WithSubjectAlternativeNames(this global::Pulumi.AwsNative.Lightsail.CertificateArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SubjectAlternativeNames = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.CertificateArgs WithSubjectAlternativeNames(this global::Pulumi.AwsNative.Lightsail.CertificateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SubjectAlternativeNames = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.CertificateArgs WithTags(this global::Pulumi.AwsNative.Lightsail.CertificateArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.CertificateArgs WithTags(this global::Pulumi.AwsNative.Lightsail.CertificateArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.CertificateArgs WithTags(this global::Pulumi.AwsNative.Lightsail.CertificateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
