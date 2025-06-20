// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ecr;

public static partial class RepositoryExtensions
{

    extension(Repository)
    {
        public static Repository New(string @id, global::Pulumi.AwsNative.Ecr.RepositoryArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Repository(@id, @args, @options);
        }

        public static Repository New(string @id, global::System.Action<global::Pulumi.AwsNative.Ecr.RepositoryArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ecr.RepositoryArgs @args = new();
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

            return new Repository(@id, @args, @options);
        }

    }

}
