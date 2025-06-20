// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.ApiGateway;

public static partial class DomainNameAccessAssociationExtensions
{

    extension(DomainNameAccessAssociation)
    {
        public static DomainNameAccessAssociation New(string @id, global::Pulumi.AwsNative.ApiGateway.DomainNameAccessAssociationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new DomainNameAccessAssociation(@id, @args, @options);
        }

        public static DomainNameAccessAssociation New(string @id, global::System.Action<global::Pulumi.AwsNative.ApiGateway.DomainNameAccessAssociationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.ApiGateway.DomainNameAccessAssociationArgs @args = new();
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

            return new DomainNameAccessAssociation(@id, @args, @options);
        }

    }

}
