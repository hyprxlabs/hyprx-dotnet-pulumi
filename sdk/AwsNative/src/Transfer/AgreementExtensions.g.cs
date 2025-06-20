// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Transfer;

public static partial class AgreementExtensions
{

    extension(Agreement)
    {
        public static Agreement New(string @id, global::Pulumi.AwsNative.Transfer.AgreementArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Agreement(@id, @args, @options);
        }

        public static Agreement New(string @id, global::System.Action<global::Pulumi.AwsNative.Transfer.AgreementArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.Transfer.AgreementArgs @args = new();
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

            return new Agreement(@id, @args, @options);
        }

    }

}
