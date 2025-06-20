// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Cognito;

public static partial class ManagedLoginBrandingExtensions
{

    extension(ManagedLoginBranding)
    {
        public static ManagedLoginBranding New(string @id, global::Pulumi.AwsNative.Cognito.ManagedLoginBrandingArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ManagedLoginBranding(@id, @args, @options);
        }

        public static ManagedLoginBranding New(string @id, global::System.Action<global::Pulumi.AwsNative.Cognito.ManagedLoginBrandingArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Cognito.ManagedLoginBrandingArgs @args = new();
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

            return new ManagedLoginBranding(@id, @args, @options);
        }

    }

}
