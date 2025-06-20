// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Route53;

public static partial class CidrCollectionExtensions
{

    extension(CidrCollection)
    {
        public static CidrCollection New(string @id, global::Pulumi.AwsNative.Route53.CidrCollectionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new CidrCollection(@id, @args, @options);
        }

        public static CidrCollection New(string @id, global::System.Action<global::Pulumi.AwsNative.Route53.CidrCollectionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Route53.CidrCollectionArgs @args = new();
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

            return new CidrCollection(@id, @args, @options);
        }

    }

}
