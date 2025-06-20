// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ses;

public static partial class MailManagerTrafficPolicyExtensions
{

    extension(MailManagerTrafficPolicy)
    {
        public static MailManagerTrafficPolicy New(string @id, global::Pulumi.AwsNative.Ses.MailManagerTrafficPolicyArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new MailManagerTrafficPolicy(@id, @args, @options);
        }

        public static MailManagerTrafficPolicy New(string @id, global::System.Action<global::Pulumi.AwsNative.Ses.MailManagerTrafficPolicyArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ses.MailManagerTrafficPolicyArgs @args = new();
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

            return new MailManagerTrafficPolicy(@id, @args, @options);
        }

    }

}
