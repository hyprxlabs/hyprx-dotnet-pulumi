// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.GuestConfiguration;

public static partial class GuestConfigurationConnectedVMwarevSphereAssignmentExtensions
{

    extension(GuestConfigurationConnectedVMwarevSphereAssignment)
    {
        public static GuestConfigurationConnectedVMwarevSphereAssignment New(string @id, global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new GuestConfigurationConnectedVMwarevSphereAssignment(@id, @args, @options);
        }

        public static GuestConfigurationConnectedVMwarevSphereAssignment New(string @id, global::System.Action<global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.GuestConfiguration.GuestConfigurationConnectedVMwarevSphereAssignmentArgs @args = new();
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

            return new GuestConfigurationConnectedVMwarevSphereAssignment(@id, @args, @options);
        }

    }

}
