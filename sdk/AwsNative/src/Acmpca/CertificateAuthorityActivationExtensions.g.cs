// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Acmpca;

public static partial class CertificateAuthorityActivationExtensions
{

    extension(CertificateAuthorityActivation)
    {
        public static CertificateAuthorityActivation New(string @id, global::Pulumi.AwsNative.Acmpca.CertificateAuthorityActivationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new CertificateAuthorityActivation(@id, @args, @options);
        }

        public static CertificateAuthorityActivation New(string @id, global::System.Action<global::Pulumi.AwsNative.Acmpca.CertificateAuthorityActivationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Acmpca.CertificateAuthorityActivationArgs @args = new();
            global::Pulumi.CustomResourceOptions? @options = null;
            if (@configureArgs is not null)
            {
                @configureArgs(@args);
            }

            if (@configureOptions is not null)
            {
                @options = new();
                @configureOptions(@options);
            }

            return new CertificateAuthorityActivation(@id, @args, @options);
        }

    }

}
