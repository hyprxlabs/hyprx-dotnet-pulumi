// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.RecommendationsService;

public static partial class ModelingExtensions
{

    extension(Modeling)
    {
        public static Modeling New(string @id, global::Pulumi.AzureNative.RecommendationsService.ModelingArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Modeling(@id, @args, @options);
        }

        public static Modeling New(string @id, global::System.Action<global::Pulumi.AzureNative.RecommendationsService.ModelingArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.RecommendationsService.ModelingArgs @args = new();
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

            return new Modeling(@id, @args, @options);
        }

    }

}
