// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.EventHub;

public static partial class EventHubAuthorizationRuleExtensions
{

    extension(EventHubAuthorizationRule)
    {
        public static EventHubAuthorizationRule New(string @id, global::Pulumi.AzureNative.EventHub.EventHubAuthorizationRuleArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new EventHubAuthorizationRule(@id, @args, @options);
        }

        public static EventHubAuthorizationRule New(string @id, global::System.Action<global::Pulumi.AzureNative.EventHub.EventHubAuthorizationRuleArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.EventHub.EventHubAuthorizationRuleArgs @args = new();
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

            return new EventHubAuthorizationRule(@id, @args, @options);
        }

    }

}
