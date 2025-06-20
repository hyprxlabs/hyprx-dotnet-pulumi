// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class RegistryEnvironmentVersionExtensions
{

    extension(RegistryEnvironmentVersion)
    {
        public static RegistryEnvironmentVersion New(string @id, global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new RegistryEnvironmentVersion(@id, @args, @options);
        }

        public static RegistryEnvironmentVersion New(string @id, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.MachineLearningServices.RegistryEnvironmentVersionArgs @args = new();
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

            return new RegistryEnvironmentVersion(@id, @args, @options);
        }

    }

}
