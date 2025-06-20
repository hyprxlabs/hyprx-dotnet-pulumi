// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.App;

public static partial class ConnectedEnvironmentsStorageArgsExtensions
{
    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsStorageArgs WithConnectedEnvironmentName(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsStorageArgs @selfRef, global::System.String connectedEnvironmentName)
    {
        @selfRef.ConnectedEnvironmentName = connectedEnvironmentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsStorageArgs WithProperties(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsStorageArgs @selfRef, global::Pulumi.AzureNative.App.Inputs.ConnectedEnvironmentStoragePropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsStorageArgs WithProperties(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsStorageArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.App.Inputs.ConnectedEnvironmentStoragePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.App.Inputs.ConnectedEnvironmentStoragePropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsStorageArgs WithResourceGroupName(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsStorageArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsStorageArgs WithStorageName(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsStorageArgs @selfRef, global::System.String storageName)
    {
        @selfRef.StorageName = storageName;
        return @selfRef;
    }

}
