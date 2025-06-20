// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class ModelVersionExtensions
{

    extension(ModelVersion)
    {
        public static ModelVersion New(string @id, global::Pulumi.AzureNative.MachineLearningServices.ModelVersionArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ModelVersion(@id, @args, @options);
        }

        public static ModelVersion New(string @id, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.ModelVersionArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.MachineLearningServices.ModelVersionArgs @args = new();
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

            return new ModelVersion(@id, @args, @options);
        }

    }

}
