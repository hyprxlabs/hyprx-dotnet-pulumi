// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.PaymentCryptography;

public static partial class KeyExtensions
{

    extension(Key)
    {
        public static Key New(string @id, global::Pulumi.AwsNative.PaymentCryptography.KeyArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Key(@id, @args, @options);
        }

        public static Key New(string @id, global::System.Action<global::Pulumi.AwsNative.PaymentCryptography.KeyArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.PaymentCryptography.KeyArgs @args = new();
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

            return new Key(@id, @args, @options);
        }

    }

}
