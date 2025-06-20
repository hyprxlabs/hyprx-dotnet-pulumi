// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.App;

public static partial class ManagedEnvironmentsStorageArgsExtensions
{
    public static global::Pulumi.AzureNative.App.ManagedEnvironmentsStorageArgs WithEnvironmentName(this global::Pulumi.AzureNative.App.ManagedEnvironmentsStorageArgs @selfRef, global::System.String environmentName)
    {
        @selfRef.EnvironmentName = environmentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ManagedEnvironmentsStorageArgs WithProperties(this global::Pulumi.AzureNative.App.ManagedEnvironmentsStorageArgs @selfRef, global::Pulumi.AzureNative.App.Inputs.ManagedEnvironmentStoragePropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ManagedEnvironmentsStorageArgs WithProperties(this global::Pulumi.AzureNative.App.ManagedEnvironmentsStorageArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.App.Inputs.ManagedEnvironmentStoragePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.App.Inputs.ManagedEnvironmentStoragePropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ManagedEnvironmentsStorageArgs WithResourceGroupName(this global::Pulumi.AzureNative.App.ManagedEnvironmentsStorageArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ManagedEnvironmentsStorageArgs WithStorageName(this global::Pulumi.AzureNative.App.ManagedEnvironmentsStorageArgs @selfRef, global::System.String storageName)
    {
        @selfRef.StorageName = storageName;
        return @selfRef;
    }

}
