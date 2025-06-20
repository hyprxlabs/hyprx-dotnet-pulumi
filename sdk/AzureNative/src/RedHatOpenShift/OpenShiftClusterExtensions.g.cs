// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.RedHatOpenShift;

public static partial class OpenShiftClusterExtensions
{

    extension(OpenShiftCluster)
    {
        public static OpenShiftCluster New(string @id, global::Pulumi.AzureNative.RedHatOpenShift.OpenShiftClusterArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new OpenShiftCluster(@id, @args, @options);
        }

        public static OpenShiftCluster New(string @id, global::System.Action<global::Pulumi.AzureNative.RedHatOpenShift.OpenShiftClusterArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.RedHatOpenShift.OpenShiftClusterArgs @args = new();
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

            return new OpenShiftCluster(@id, @args, @options);
        }

    }

}
