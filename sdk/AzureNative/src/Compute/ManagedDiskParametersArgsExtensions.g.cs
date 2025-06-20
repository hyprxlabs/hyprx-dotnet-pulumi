// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Compute.Inputs;

namespace Pulumi.AzureNative.Compute;

public static partial class ManagedDiskParametersArgsExtensions
{
    public static global::Pulumi.AzureNative.Compute.Inputs.ManagedDiskParametersArgs WithDiskEncryptionSet(this global::Pulumi.AzureNative.Compute.Inputs.ManagedDiskParametersArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.DiskEncryptionSetParametersArgs diskEncryptionSet)
    {
        @selfRef.DiskEncryptionSet = diskEncryptionSet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.ManagedDiskParametersArgs WithDiskEncryptionSet(this global::Pulumi.AzureNative.Compute.Inputs.ManagedDiskParametersArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.DiskEncryptionSetParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.DiskEncryptionSetParametersArgs();
        @configure(@item);
        @selfRef.DiskEncryptionSet = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.ManagedDiskParametersArgs WithId(this global::Pulumi.AzureNative.Compute.Inputs.ManagedDiskParametersArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.ManagedDiskParametersArgs WithSecurityProfile(this global::Pulumi.AzureNative.Compute.Inputs.ManagedDiskParametersArgs @selfRef, global::Pulumi.AzureNative.Compute.Inputs.VMDiskSecurityProfileArgs securityProfile)
    {
        @selfRef.SecurityProfile = securityProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.ManagedDiskParametersArgs WithSecurityProfile(this global::Pulumi.AzureNative.Compute.Inputs.ManagedDiskParametersArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Compute.Inputs.VMDiskSecurityProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Compute.Inputs.VMDiskSecurityProfileArgs();
        @configure(@item);
        @selfRef.SecurityProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Compute.Inputs.ManagedDiskParametersArgs WithStorageAccountType(this global::Pulumi.AzureNative.Compute.Inputs.ManagedDiskParametersArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Compute.StorageAccountTypes> storageAccountType)
    {
        @selfRef.StorageAccountType = storageAccountType;
        return @selfRef;
    }

}
