// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Detective;

public static partial class OrganizationAdminExtensions
{

    extension(OrganizationAdmin)
    {
        public static OrganizationAdmin New(string @id, global::Pulumi.AwsNative.Detective.OrganizationAdminArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new OrganizationAdmin(@id, @args, @options);
        }

        public static OrganizationAdmin New(string @id, global::System.Action<global::Pulumi.AwsNative.Detective.OrganizationAdminArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Detective.OrganizationAdminArgs @args = new();
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

            return new OrganizationAdmin(@id, @args, @options);
        }

    }

}
