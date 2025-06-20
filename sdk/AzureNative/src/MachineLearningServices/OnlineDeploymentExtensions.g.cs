// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class OnlineDeploymentExtensions
{

    extension(OnlineDeployment)
    {
        public static OnlineDeployment New(string @id, global::Pulumi.AzureNative.MachineLearningServices.OnlineDeploymentArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new OnlineDeployment(@id, @args, @options);
        }

        public static OnlineDeployment New(string @id, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.OnlineDeploymentArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.MachineLearningServices.OnlineDeploymentArgs @args = new();
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

            return new OnlineDeployment(@id, @args, @options);
        }

    }

}
