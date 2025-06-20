// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ServiceBus;

public static partial class NamespaceAuthorizationRuleExtensions
{

    extension(NamespaceAuthorizationRule)
    {
        public static NamespaceAuthorizationRule New(string @id, global::Pulumi.AzureNative.ServiceBus.NamespaceAuthorizationRuleArgs @args, global::Pulumi.CustomResourceOptions? @options = null)
        {
            return new NamespaceAuthorizationRule(@id, @args, @options);
        }

        public static NamespaceAuthorizationRule New(string @id, global::System.Action<global::Pulumi.AzureNative.ServiceBus.NamespaceAuthorizationRuleArgs>? @configureArgs = null, global::System.Action<global::Pulumi.CustomResourceOptions>? @configureOptions = null)
        {
            global::Pulumi.AzureNative.ServiceBus.NamespaceAuthorizationRuleArgs @args = new();
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

            return new NamespaceAuthorizationRule(@id, @args, @options);
        }

    }

}
