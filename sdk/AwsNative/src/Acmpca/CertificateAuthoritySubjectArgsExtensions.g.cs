// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Acmpca.Inputs;

namespace Pulumi.AwsNative.Acmpca;

public static partial class CertificateAuthoritySubjectArgsExtensions
{
    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithCommonName(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String commonName)
    {
        @selfRef.CommonName = commonName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithCountry(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String country)
    {
        @selfRef.Country = country;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithCustomAttributes(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthorityCustomAttributeArgs> customAttributes)
    {
        @selfRef.CustomAttributes = customAttributes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithCustomAttributes(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthorityCustomAttributeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthorityCustomAttributeArgs>();
        @configure(@list);
        @selfRef.CustomAttributes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithCustomAttributes(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthorityCustomAttributeArgs>> @create)
    {
        @selfRef.CustomAttributes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithDistinguishedNameQualifier(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String distinguishedNameQualifier)
    {
        @selfRef.DistinguishedNameQualifier = distinguishedNameQualifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithGenerationQualifier(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String generationQualifier)
    {
        @selfRef.GenerationQualifier = generationQualifier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithGivenName(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String givenName)
    {
        @selfRef.GivenName = givenName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithInitials(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String initials)
    {
        @selfRef.Initials = initials;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithLocality(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String locality)
    {
        @selfRef.Locality = locality;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithOrganization(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String organization)
    {
        @selfRef.Organization = organization;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithOrganizationalUnit(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String organizationalUnit)
    {
        @selfRef.OrganizationalUnit = organizationalUnit;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithPseudonym(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String pseudonym)
    {
        @selfRef.Pseudonym = pseudonym;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithSerialNumber(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String serialNumber)
    {
        @selfRef.SerialNumber = serialNumber;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithState(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithSurname(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String surname)
    {
        @selfRef.Surname = surname;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs WithTitle(this global::Pulumi.AwsNative.Acmpca.Inputs.CertificateAuthoritySubjectArgs @selfRef, global::System.String title)
    {
        @selfRef.Title = title;
        return @selfRef;
    }

}
