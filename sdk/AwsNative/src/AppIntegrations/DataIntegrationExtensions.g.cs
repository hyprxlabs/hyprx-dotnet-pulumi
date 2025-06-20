// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.AppIntegrations;

public static partial class DataIntegrationExtensions
{

    extension(DataIntegration)
    {
        public static DataIntegration New(string @id, global::Pulumi.AwsNative.AppIntegrations.DataIntegrationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new DataIntegration(@id, @args, @options);
        }

        public static DataIntegration New(string @id, global::System.Action<global::Pulumi.AwsNative.AppIntegrations.DataIntegrationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.AppIntegrations.DataIntegrationArgs @args = new();
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

            return new DataIntegration(@id, @args, @options);
        }

    }

}
