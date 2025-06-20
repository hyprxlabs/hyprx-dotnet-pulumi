// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ses;

public static partial class MailManagerIngressPointExtensions
{

    extension(MailManagerIngressPoint)
    {
        public static MailManagerIngressPoint New(string @id, global::Pulumi.AwsNative.Ses.MailManagerIngressPointArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new MailManagerIngressPoint(@id, @args, @options);
        }

        public static MailManagerIngressPoint New(string @id, global::System.Action<global::Pulumi.AwsNative.Ses.MailManagerIngressPointArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Ses.MailManagerIngressPointArgs @args = new();
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

            return new MailManagerIngressPoint(@id, @args, @options);
        }

    }

}
