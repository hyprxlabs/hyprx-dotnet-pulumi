// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class ReplicationMigrationItemArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs WithFabricName(this global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs @selfRef, global::System.String fabricName)
    {
        @selfRef.FabricName = fabricName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs WithMigrationItemName(this global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs @selfRef, global::System.String migrationItemName)
    {
        @selfRef.MigrationItemName = migrationItemName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs WithProperties(this global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs @selfRef, global::Pulumi.AzureNative.RecoveryServices.Inputs.EnableMigrationInputPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs WithProperties(this global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.RecoveryServices.Inputs.EnableMigrationInputPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.RecoveryServices.Inputs.EnableMigrationInputPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs WithProtectionContainerName(this global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs @selfRef, global::System.String protectionContainerName)
    {
        @selfRef.ProtectionContainerName = protectionContainerName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs WithResourceGroupName(this global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs WithResourceName(this global::Pulumi.AzureNative.RecoveryServices.ReplicationMigrationItemArgs @selfRef, global::System.String resourceName)
    {
        @selfRef.ResourceName = resourceName;
        return @selfRef;
    }

}
