// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AwsConnector;

public static partial class SecretsManagerSecretExtensions
{

    extension(SecretsManagerSecret)
    {
        public static SecretsManagerSecret New(string @id, global::Pulumi.AzureNative.AwsConnector.SecretsManagerSecretArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new SecretsManagerSecret(@id, @args, @options);
        }

        public static SecretsManagerSecret New(string @id, global::System.Action<global::Pulumi.AzureNative.AwsConnector.SecretsManagerSecretArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.AwsConnector.SecretsManagerSecretArgs @args = new();
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

            return new SecretsManagerSecret(@id, @args, @options);
        }

    }

}
