// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ContainerRegistry;

public static partial class ExportPipelineExtensions
{

    extension(ExportPipeline)
    {
        public static ExportPipeline New(string @id, global::Pulumi.AzureNative.ContainerRegistry.ExportPipelineArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ExportPipeline(@id, @args, @options);
        }

        public static ExportPipeline New(string @id, global::System.Action<global::Pulumi.AzureNative.ContainerRegistry.ExportPipelineArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ContainerRegistry.ExportPipelineArgs @args = new();
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

            return new ExportPipeline(@id, @args, @options);
        }

    }

}
