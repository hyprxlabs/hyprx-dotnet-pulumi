// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ec2;

public static partial class SubnetNetworkAclAssociationExtensions
{

    extension(SubnetNetworkAclAssociation)
    {
        public static SubnetNetworkAclAssociation New(string @id, global::Pulumi.AwsNative.Ec2.SubnetNetworkAclAssociationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new SubnetNetworkAclAssociation(@id, @args, @options);
        }

        public static SubnetNetworkAclAssociation New(string @id, global::System.Action<global::Pulumi.AwsNative.Ec2.SubnetNetworkAclAssociationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ec2.SubnetNetworkAclAssociationArgs @args = new();
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

            return new SubnetNetworkAclAssociation(@id, @args, @options);
        }

    }

}
