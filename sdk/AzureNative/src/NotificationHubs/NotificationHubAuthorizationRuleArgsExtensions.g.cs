// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.NotificationHubs;

public static partial class NotificationHubAuthorizationRuleArgsExtensions
{
    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithAuthorizationRuleName(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.String authorizationRuleName)
    {
        @selfRef.AuthorizationRuleName = authorizationRuleName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithLocation(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithNamespaceName(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.String namespaceName)
    {
        @selfRef.NamespaceName = namespaceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithNotificationHubName(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.String notificationHubName)
    {
        @selfRef.NotificationHubName = notificationHubName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithPrimaryKey(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.String primaryKey)
    {
        @selfRef.PrimaryKey = primaryKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithResourceGroupName(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithRights(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.NotificationHubs.AccessRights>> rights)
    {
        @selfRef.Rights = rights;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithRights(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.NotificationHubs.AccessRights>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.NotificationHubs.AccessRights>>();
        @configure(@list);
        @selfRef.Rights = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithRights(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.NotificationHubs.AccessRights>>> @create)
    {
        @selfRef.Rights = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithSecondaryKey(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.String secondaryKey)
    {
        @selfRef.SecondaryKey = secondaryKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithTags(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithTags(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs WithTags(this global::Pulumi.AzureNative.NotificationHubs.NotificationHubAuthorizationRuleArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
