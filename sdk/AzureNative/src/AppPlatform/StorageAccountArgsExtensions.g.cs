// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AppPlatform.Inputs;

namespace Pulumi.AzureNative.AppPlatform;

public static partial class StorageAccountArgsExtensions
{
    public static global::Pulumi.AzureNative.AppPlatform.Inputs.StorageAccountArgs WithAccountKey(this global::Pulumi.AzureNative.AppPlatform.Inputs.StorageAccountArgs @selfRef, global::System.String accountKey)
    {
        @selfRef.AccountKey = accountKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.StorageAccountArgs WithAccountName(this global::Pulumi.AzureNative.AppPlatform.Inputs.StorageAccountArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AppPlatform.Inputs.StorageAccountArgs WithStorageType(this global::Pulumi.AzureNative.AppPlatform.Inputs.StorageAccountArgs @selfRef, global::System.String storageType)
    {
        @selfRef.StorageType = storageType;
        return @selfRef;
    }

}
