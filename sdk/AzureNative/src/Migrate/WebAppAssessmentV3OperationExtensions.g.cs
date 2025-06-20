// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Migrate;

public static partial class WebAppAssessmentV3OperationExtensions
{

    extension(WebAppAssessmentV3Operation)
    {
        public static WebAppAssessmentV3Operation New(string @id, global::Pulumi.AzureNative.Migrate.WebAppAssessmentV3OperationArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new WebAppAssessmentV3Operation(@id, @args, @options);
        }

        public static WebAppAssessmentV3Operation New(string @id, global::System.Action<global::Pulumi.AzureNative.Migrate.WebAppAssessmentV3OperationArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.Migrate.WebAppAssessmentV3OperationArgs @args = new();
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

            return new WebAppAssessmentV3Operation(@id, @args, @options);
        }

    }

}
