// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataBox.Inputs;

namespace Pulumi.AzureNative.DataBox;

public static partial class ManagedDiskDetailsArgsExtensions
{
    public static global::Pulumi.AzureNative.DataBox.Inputs.ManagedDiskDetailsArgs WithDataAccountType(this global::Pulumi.AzureNative.DataBox.Inputs.ManagedDiskDetailsArgs @selfRef, global::System.String dataAccountType)
    {
        @selfRef.DataAccountType = dataAccountType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBox.Inputs.ManagedDiskDetailsArgs WithResourceGroupId(this global::Pulumi.AzureNative.DataBox.Inputs.ManagedDiskDetailsArgs @selfRef, global::System.String resourceGroupId)
    {
        @selfRef.ResourceGroupId = resourceGroupId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBox.Inputs.ManagedDiskDetailsArgs WithSharePassword(this global::Pulumi.AzureNative.DataBox.Inputs.ManagedDiskDetailsArgs @selfRef, global::System.String sharePassword)
    {
        @selfRef.SharePassword = sharePassword;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataBox.Inputs.ManagedDiskDetailsArgs WithStagingStorageAccountId(this global::Pulumi.AzureNative.DataBox.Inputs.ManagedDiskDetailsArgs @selfRef, global::System.String stagingStorageAccountId)
    {
        @selfRef.StagingStorageAccountId = stagingStorageAccountId;
        return @selfRef;
    }

}
