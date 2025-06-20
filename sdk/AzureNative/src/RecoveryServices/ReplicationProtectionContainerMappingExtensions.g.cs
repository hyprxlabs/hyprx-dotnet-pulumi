// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class ReplicationProtectionContainerMappingExtensions
{

    extension(ReplicationProtectionContainerMapping)
    {
        public static ReplicationProtectionContainerMapping New(string @id, global::Pulumi.AzureNative.RecoveryServices.ReplicationProtectionContainerMappingArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ReplicationProtectionContainerMapping(@id, @args, @options);
        }

        public static ReplicationProtectionContainerMapping New(string @id, global::System.Action<global::Pulumi.AzureNative.RecoveryServices.ReplicationProtectionContainerMappingArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.RecoveryServices.ReplicationProtectionContainerMappingArgs @args = new();
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

            return new ReplicationProtectionContainerMapping(@id, @args, @options);
        }

    }

}
