// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.QBusiness;

public static partial class PermissionExtensions
{

    extension(Permission)
    {
        public static Permission New(string @id, global::Pulumi.AwsNative.QBusiness.PermissionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Permission(@id, @args, @options);
        }

        public static Permission New(string @id, global::System.Action<global::Pulumi.AwsNative.QBusiness.PermissionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.QBusiness.PermissionArgs @args = new();
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

            return new Permission(@id, @args, @options);
        }

    }

}
