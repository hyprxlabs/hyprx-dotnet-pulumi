// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Connect;

public static partial class UserExtensions
{

    extension(User)
    {
        public static User New(string @id, global::Pulumi.AwsNative.Connect.UserArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new User(@id, @args, @options);
        }

        public static User New(string @id, global::System.Action<global::Pulumi.AwsNative.Connect.UserArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Connect.UserArgs @args = new();
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

            return new User(@id, @args, @options);
        }

    }

}
