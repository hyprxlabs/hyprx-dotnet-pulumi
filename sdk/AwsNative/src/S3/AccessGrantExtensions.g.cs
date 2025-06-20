// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.S3;

public static partial class AccessGrantExtensions
{

    extension(AccessGrant)
    {
        public static AccessGrant New(string @id, global::Pulumi.AwsNative.S3.AccessGrantArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new AccessGrant(@id, @args, @options);
        }

        public static AccessGrant New(string @id, global::System.Action<global::Pulumi.AwsNative.S3.AccessGrantArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.S3.AccessGrantArgs @args = new();
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

            return new AccessGrant(@id, @args, @options);
        }

    }

}
