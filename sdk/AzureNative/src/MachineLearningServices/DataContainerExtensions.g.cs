// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class DataContainerExtensions
{

    extension(DataContainer)
    {
        public static DataContainer New(string @id, global::Pulumi.AzureNative.MachineLearningServices.DataContainerArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new DataContainer(@id, @args, @options);
        }

        public static DataContainer New(string @id, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.DataContainerArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.MachineLearningServices.DataContainerArgs @args = new();
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

            return new DataContainer(@id, @args, @options);
        }

    }

}
