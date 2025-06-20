// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Iam;

public static partial class UserPolicyExtensions
{

    extension(UserPolicy)
    {
        public static UserPolicy New(string @id, global::Pulumi.AwsNative.Iam.UserPolicyArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new UserPolicy(@id, @args, @options);
        }

        public static UserPolicy New(string @id, global::System.Action<global::Pulumi.AwsNative.Iam.UserPolicyArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Iam.UserPolicyArgs @args = new();
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

            return new UserPolicy(@id, @args, @options);
        }

    }

}
