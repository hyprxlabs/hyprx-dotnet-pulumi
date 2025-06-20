// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.EventHub;

public static partial class NamespaceAuthorizationRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.EventHub.NamespaceAuthorizationRuleArgs WithAuthorizationRuleName(this global::Pulumi.AzureNative.EventHub.NamespaceAuthorizationRuleArgs @selfRef, global::System.String authorizationRuleName)
    {
        @selfRef.AuthorizationRuleName = authorizationRuleName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceAuthorizationRuleArgs WithNamespaceName(this global::Pulumi.AzureNative.EventHub.NamespaceAuthorizationRuleArgs @selfRef, global::System.String namespaceName)
    {
        @selfRef.NamespaceName = namespaceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceAuthorizationRuleArgs WithResourceGroupName(this global::Pulumi.AzureNative.EventHub.NamespaceAuthorizationRuleArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceAuthorizationRuleArgs WithRights(this global::Pulumi.AzureNative.EventHub.NamespaceAuthorizationRuleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.EventHub.AccessRights>> rights)
    {
        @selfRef.Rights = rights;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceAuthorizationRuleArgs WithRights(this global::Pulumi.AzureNative.EventHub.NamespaceAuthorizationRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.EventHub.AccessRights>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.EventHub.AccessRights>>();
        @configure(@list);
        @selfRef.Rights = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EventHub.NamespaceAuthorizationRuleArgs WithRights(this global::Pulumi.AzureNative.EventHub.NamespaceAuthorizationRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.EventHub.AccessRights>>> @create)
    {
        @selfRef.Rights = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
