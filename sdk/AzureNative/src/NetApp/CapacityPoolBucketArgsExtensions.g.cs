// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.NetApp;

public static partial class CapacityPoolBucketArgsExtensions
{
    public static global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs WithAccountName(this global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs WithBucketName(this global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs @selfRef, global::System.String bucketName)
    {
        @selfRef.BucketName = bucketName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs WithFileSystemUser(this global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs @selfRef, global::Pulumi.AzureNative.NetApp.Inputs.FileSystemUserArgs fileSystemUser)
    {
        @selfRef.FileSystemUser = fileSystemUser;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs WithFileSystemUser(this global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.NetApp.Inputs.FileSystemUserArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.NetApp.Inputs.FileSystemUserArgs();
        @configure(@item);
        @selfRef.FileSystemUser = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs WithPath(this global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs @selfRef, global::System.String path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs WithPoolName(this global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs @selfRef, global::System.String poolName)
    {
        @selfRef.PoolName = poolName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs WithResourceGroupName(this global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs WithServer(this global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs @selfRef, global::Pulumi.AzureNative.NetApp.Inputs.BucketServerPropertiesArgs server)
    {
        @selfRef.Server = server;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs WithServer(this global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.NetApp.Inputs.BucketServerPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.NetApp.Inputs.BucketServerPropertiesArgs();
        @configure(@item);
        @selfRef.Server = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs WithVolumeName(this global::Pulumi.AzureNative.NetApp.CapacityPoolBucketArgs @selfRef, global::System.String volumeName)
    {
        @selfRef.VolumeName = volumeName;
        return @selfRef;
    }

}
