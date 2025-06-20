// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DBforMySQL.Inputs;

namespace Pulumi.AzureNative.DBforMySQL;

public static partial class StorageArgsExtensions
{
    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.StorageArgs WithAutoGrow(this global::Pulumi.AzureNative.DBforMySQL.Inputs.StorageArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforMySQL.EnableStatusEnum> autoGrow)
    {
        @selfRef.AutoGrow = autoGrow;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.StorageArgs WithAutoIoScaling(this global::Pulumi.AzureNative.DBforMySQL.Inputs.StorageArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforMySQL.EnableStatusEnum> autoIoScaling)
    {
        @selfRef.AutoIoScaling = autoIoScaling;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.StorageArgs WithIops(this global::Pulumi.AzureNative.DBforMySQL.Inputs.StorageArgs @selfRef, global::System.Int32 iops)
    {
        @selfRef.Iops = iops;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.StorageArgs WithLogOnDisk(this global::Pulumi.AzureNative.DBforMySQL.Inputs.StorageArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforMySQL.EnableStatusEnum> logOnDisk)
    {
        @selfRef.LogOnDisk = logOnDisk;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.StorageArgs WithStorageRedundancy(this global::Pulumi.AzureNative.DBforMySQL.Inputs.StorageArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforMySQL.StorageRedundancyEnum> storageRedundancy)
    {
        @selfRef.StorageRedundancy = storageRedundancy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.StorageArgs WithStorageSizeGB(this global::Pulumi.AzureNative.DBforMySQL.Inputs.StorageArgs @selfRef, global::System.Int32 storageSizeGB)
    {
        @selfRef.StorageSizeGB = storageSizeGB;
        return @selfRef;
    }

}
