// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AzureDataTransfer.Inputs;

namespace Pulumi.AzureNative.AzureDataTransfer;

public static partial class SubscriberArgsExtensions
{
    public static global::Pulumi.AzureNative.AzureDataTransfer.Inputs.SubscriberArgs WithEmail(this global::Pulumi.AzureNative.AzureDataTransfer.Inputs.SubscriberArgs @selfRef, global::System.String email)
    {
        @selfRef.Email = email;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AzureDataTransfer.Inputs.SubscriberArgs WithNotifications(this global::Pulumi.AzureNative.AzureDataTransfer.Inputs.SubscriberArgs @selfRef, global::System.Double notifications)
    {
        @selfRef.Notifications = notifications;
        return @selfRef;
    }

}
