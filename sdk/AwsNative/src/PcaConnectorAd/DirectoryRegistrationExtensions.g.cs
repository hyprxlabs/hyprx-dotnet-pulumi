// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.PcaConnectorAd;

public static partial class DirectoryRegistrationExtensions
{

    extension(DirectoryRegistration)
    {
        public static DirectoryRegistration New(string @id, global::Pulumi.AwsNative.PcaConnectorAd.DirectoryRegistrationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new DirectoryRegistration(@id, @args, @options);
        }

        public static DirectoryRegistration New(string @id, global::System.Action<global::Pulumi.AwsNative.PcaConnectorAd.DirectoryRegistrationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.PcaConnectorAd.DirectoryRegistrationArgs @args = new();
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

            return new DirectoryRegistration(@id, @args, @options);
        }

    }

}
