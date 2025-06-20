// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.AppConfig;

public static partial class ExtensionAssociationExtensions
{

    extension(ExtensionAssociation)
    {
        public static ExtensionAssociation New(string @id, global::Pulumi.AwsNative.AppConfig.ExtensionAssociationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ExtensionAssociation(@id, @args, @options);
        }

        public static ExtensionAssociation New(string @id, global::System.Action<global::Pulumi.AwsNative.AppConfig.ExtensionAssociationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.AppConfig.ExtensionAssociationArgs @args = new();
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

            return new ExtensionAssociation(@id, @args, @options);
        }

    }

}
