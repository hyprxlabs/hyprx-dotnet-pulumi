// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.NotificationHubs;

public static partial class NotificationHubAuthorizationRuleExtensions
{

    extension(NotificationHubAuthorizationRule)
    {
        public static NotificationHubAuthorizationRule New(string @id, global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new NotificationHubAuthorizationRule(@id, @args, @options);
        }

        public static NotificationHubAuthorizationRule New(string @id, global::System.Action<global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @args = new();
            global::Pulumi.CustomResourceOptions? @options = null;
            if (@configureArgs is not null)
            {
                @configureArgs(@args);
            }

            if (@configureOptions is not null)
            {
                @options = new();
                @configureOptions(@options);
            }

            return new NotificationHubAuthorizationRule(@id, @args, @options);
        }

    }

}
