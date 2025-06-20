// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ServiceBus;

public static partial class QueueAuthorizationRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs WithAuthorizationRuleName(this global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs @selfRef, global::System.String authorizationRuleName)
    {
        @selfRef.AuthorizationRuleName = authorizationRuleName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs WithNamespaceName(this global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs @selfRef, global::System.String namespaceName)
    {
        @selfRef.NamespaceName = namespaceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs WithQueueName(this global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs @selfRef, global::System.String queueName)
    {
        @selfRef.QueueName = queueName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs WithResourceGroupName(this global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs WithRights(this global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceBus.AccessRights> rights)
    {
        @selfRef.Rights = rights;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs WithRights(this global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceBus.AccessRights>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceBus.AccessRights>();
        @configure(@list);
        @selfRef.Rights = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs WithRights(this global::Pulumi.AzureNative.ServiceBus.QueueAuthorizationRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceBus.AccessRights>> @create)
    {
        @selfRef.Rights = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
