// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.ElastiCache;

public static partial class UserGroupExtensions
{

    extension(UserGroup)
    {
        public static UserGroup New(string @id, global::Pulumi.AwsNative.ElastiCache.UserGroupArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new UserGroup(@id, @args, @options);
        }

        public static UserGroup New(string @id, global::System.Action<global::Pulumi.AwsNative.ElastiCache.UserGroupArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.ElastiCache.UserGroupArgs @args = new();
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

            return new UserGroup(@id, @args, @options);
        }

    }

}
