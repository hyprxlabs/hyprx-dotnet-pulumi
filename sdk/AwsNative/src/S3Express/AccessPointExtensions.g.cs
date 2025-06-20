// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.S3Express;

public static partial class AccessPointExtensions
{

    extension(AccessPoint)
    {
        public static AccessPoint New(string @id, global::Pulumi.AwsNative.S3Express.AccessPointArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new AccessPoint(@id, @args, @options);
        }

        public static AccessPoint New(string @id, global::System.Action<global::Pulumi.AwsNative.S3Express.AccessPointArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.S3Express.AccessPointArgs @args = new();
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

            return new AccessPoint(@id, @args, @options);
        }

    }

}
