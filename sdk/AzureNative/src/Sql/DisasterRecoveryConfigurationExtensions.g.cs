// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Sql;

public static partial class DisasterRecoveryConfigurationExtensions
{

    extension(DisasterRecoveryConfiguration)
    {
        public static DisasterRecoveryConfiguration New(string @id, global::Pulumi.AzureNative.Sql.DisasterRecoveryConfigurationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new DisasterRecoveryConfiguration(@id, @args, @options);
        }

        public static DisasterRecoveryConfiguration New(string @id, global::System.Action<global::Pulumi.AzureNative.Sql.DisasterRecoveryConfigurationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Sql.DisasterRecoveryConfigurationArgs @args = new();
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

            return new DisasterRecoveryConfiguration(@id, @args, @options);
        }

    }

}
