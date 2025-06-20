// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.LoadTestService;

public static partial class LoadTestProfileMappingExtensions
{

    extension(LoadTestProfileMapping)
    {
        public static LoadTestProfileMapping New(string @id, global::Pulumi.AzureNative.LoadTestService.LoadTestProfileMappingArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new LoadTestProfileMapping(@id, @args, @options);
        }

        public static LoadTestProfileMapping New(string @id, global::System.Action<global::Pulumi.AzureNative.LoadTestService.LoadTestProfileMappingArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.LoadTestService.LoadTestProfileMappingArgs @args = new();
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

            return new LoadTestProfileMapping(@id, @args, @options);
        }

    }

}
