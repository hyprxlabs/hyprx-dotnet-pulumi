// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.LoadTestService;

public static partial class LoadTestExtensions
{

    extension(LoadTest)
    {
        public static LoadTest New(string @id, global::Pulumi.AzureNative.LoadTestService.LoadTestArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new LoadTest(@id, @args, @options);
        }

        public static LoadTest New(string @id, global::System.Action<global::Pulumi.AzureNative.LoadTestService.LoadTestArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.LoadTestService.LoadTestArgs @args = new();
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

            return new LoadTest(@id, @args, @options);
        }

    }

}
