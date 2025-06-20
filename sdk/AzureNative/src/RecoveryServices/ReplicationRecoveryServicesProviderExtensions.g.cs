// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class ReplicationRecoveryServicesProviderExtensions
{

    extension(ReplicationRecoveryServicesProvider)
    {
        public static ReplicationRecoveryServicesProvider New(string @id, global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new ReplicationRecoveryServicesProvider(@id, @args, @options);
        }

        public static ReplicationRecoveryServicesProvider New(string @id, global::System.Action<global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.RecoveryServices.ReplicationRecoveryServicesProviderArgs @args = new();
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

            return new ReplicationRecoveryServicesProvider(@id, @args, @options);
        }

    }

}
