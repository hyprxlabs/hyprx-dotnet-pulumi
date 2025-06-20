// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.CloudFront;

public static partial class ConnectionGroupExtensions
{

    extension(ConnectionGroup)
    {
        public static ConnectionGroup New(string @id, global::Pulumi.AwsNative.CloudFront.ConnectionGroupArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ConnectionGroup(@id, @args, @options);
        }

        public static ConnectionGroup New(string @id, global::System.Action<global::Pulumi.AwsNative.CloudFront.ConnectionGroupArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.CloudFront.ConnectionGroupArgs @args = new();
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

            return new ConnectionGroup(@id, @args, @options);
        }

    }

}
