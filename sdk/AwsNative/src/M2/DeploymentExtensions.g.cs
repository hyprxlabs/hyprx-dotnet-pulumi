// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.M2;

public static partial class DeploymentExtensions
{

    extension(Deployment)
    {
        public static Deployment New(string @id, global::Pulumi.AwsNative.M2.DeploymentArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new Deployment(@id, @args, @options);
        }

        public static Deployment New(string @id, global::System.Action<global::Pulumi.AwsNative.M2.DeploymentArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AwsNative.M2.DeploymentArgs @args = new();
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

            return new Deployment(@id, @args, @options);
        }

    }

}
