// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ProviderHub;

public static partial class NotificationRegistrationArgsExtensions
{
    public static global::Pulumi.AzureNative.ProviderHub.NotificationRegistrationArgs WithNotificationRegistrationName(this global::Pulumi.AzureNative.ProviderHub.NotificationRegistrationArgs @selfRef, global::System.String notificationRegistrationName)
    {
        @selfRef.NotificationRegistrationName = notificationRegistrationName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.NotificationRegistrationArgs WithProperties(this global::Pulumi.AzureNative.ProviderHub.NotificationRegistrationArgs @selfRef, global::Pulumi.AzureNative.ProviderHub.Inputs.NotificationRegistrationPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.NotificationRegistrationArgs WithProperties(this global::Pulumi.AzureNative.ProviderHub.NotificationRegistrationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ProviderHub.Inputs.NotificationRegistrationPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ProviderHub.Inputs.NotificationRegistrationPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ProviderHub.NotificationRegistrationArgs WithProviderNamespace(this global::Pulumi.AzureNative.ProviderHub.NotificationRegistrationArgs @selfRef, global::System.String providerNamespace)
    {
        @selfRef.ProviderNamespace = providerNamespace;
        return @selfRef;
    }

}
