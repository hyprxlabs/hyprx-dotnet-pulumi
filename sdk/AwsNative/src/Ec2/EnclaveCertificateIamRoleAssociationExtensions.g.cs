// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class EnclaveCertificateIamRoleAssociationExtensions
{

    extension(EnclaveCertificateIamRoleAssociation)
    {
        public static EnclaveCertificateIamRoleAssociation New(string @id, global::Pulumi.AwsNative.Ec2.EnclaveCertificateIamRoleAssociationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new EnclaveCertificateIamRoleAssociation(@id, @args, @options);
        }

        public static EnclaveCertificateIamRoleAssociation New(string @id, global::System.Action<global::Pulumi.AwsNative.Ec2.EnclaveCertificateIamRoleAssociationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ec2.EnclaveCertificateIamRoleAssociationArgs @args = new();
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

            return new EnclaveCertificateIamRoleAssociation(@id, @args, @options);
        }

    }

}
