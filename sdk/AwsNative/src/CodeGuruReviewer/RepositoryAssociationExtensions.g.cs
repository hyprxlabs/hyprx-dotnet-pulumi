// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.CodeGuruReviewer;

public static partial class RepositoryAssociationExtensions
{

    extension(RepositoryAssociation)
    {
        public static RepositoryAssociation New(string @id, global::Pulumi.AwsNative.CodeGuruReviewer.RepositoryAssociationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new RepositoryAssociation(@id, @args, @options);
        }

        public static RepositoryAssociation New(string @id, global::System.Action<global::Pulumi.AwsNative.CodeGuruReviewer.RepositoryAssociationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.CodeGuruReviewer.RepositoryAssociationArgs @args = new();
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

            return new RepositoryAssociation(@id, @args, @options);
        }

    }

}
