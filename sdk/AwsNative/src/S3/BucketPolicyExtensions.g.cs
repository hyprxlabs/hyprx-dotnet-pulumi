// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.S3;

public static partial class BucketPolicyExtensions
{

    extension(BucketPolicy)
    {
        public static BucketPolicy New(string @id, global::Pulumi.AwsNative.S3.BucketPolicyArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new BucketPolicy(@id, @args, @options);
        }

        public static BucketPolicy New(string @id, global::System.Action<global::Pulumi.AwsNative.S3.BucketPolicyArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.S3.BucketPolicyArgs @args = new();
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

            return new BucketPolicy(@id, @args, @options);
        }

    }

}
