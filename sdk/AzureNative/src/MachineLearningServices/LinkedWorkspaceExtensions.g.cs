// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class LinkedWorkspaceExtensions
{

    extension(LinkedWorkspace)
    {
        public static LinkedWorkspace New(string @id, global::Pulumi.AzureNative.MachineLearningServices.LinkedWorkspaceArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new LinkedWorkspace(@id, @args, @options);
        }

        public static LinkedWorkspace New(string @id, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.LinkedWorkspaceArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.MachineLearningServices.LinkedWorkspaceArgs @args = new();
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

            return new LinkedWorkspace(@id, @args, @options);
        }

    }

}
