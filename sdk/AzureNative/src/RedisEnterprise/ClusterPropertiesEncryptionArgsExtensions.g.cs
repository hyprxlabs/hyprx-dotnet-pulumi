// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RedisEnterprise.Inputs;

namespace Pulumi.AzureNative.RedisEnterprise;

public static partial class ClusterPropertiesEncryptionArgsExtensions
{
    public static global::Pulumi.AzureNative.RedisEnterprise.Inputs.ClusterPropertiesEncryptionArgs WithCustomerManagedKeyEncryption(this global::Pulumi.AzureNative.RedisEnterprise.Inputs.ClusterPropertiesEncryptionArgs @selfRef, global::Pulumi.AzureNative.RedisEnterprise.Inputs.ClusterPropertiesCustomerManagedKeyEncryptionArgs customerManagedKeyEncryption)
    {
        @selfRef.CustomerManagedKeyEncryption = customerManagedKeyEncryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RedisEnterprise.Inputs.ClusterPropertiesEncryptionArgs WithCustomerManagedKeyEncryption(this global::Pulumi.AzureNative.RedisEnterprise.Inputs.ClusterPropertiesEncryptionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.RedisEnterprise.Inputs.ClusterPropertiesCustomerManagedKeyEncryptionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.RedisEnterprise.Inputs.ClusterPropertiesCustomerManagedKeyEncryptionArgs();
        @configure(@item);
        @selfRef.CustomerManagedKeyEncryption = @item;
        return @selfRef;
    }

}
