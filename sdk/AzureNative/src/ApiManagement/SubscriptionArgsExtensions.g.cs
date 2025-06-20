// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApiManagement;

public static partial class SubscriptionArgsExtensions
{
    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithAllowTracing(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, bool allowTracing = true)
    {
        @selfRef.AllowTracing = allowTracing;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithAppType(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, global::System.String appType)
    {
        @selfRef.AppType = appType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithDisplayName(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithNotify(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, bool notify = true)
    {
        @selfRef.Notify = notify;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithOwnerId(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, global::System.String ownerId)
    {
        @selfRef.OwnerId = ownerId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithPrimaryKey(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, global::System.String primaryKey)
    {
        @selfRef.PrimaryKey = primaryKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithResourceGroupName(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithScope(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, global::System.String scope)
    {
        @selfRef.Scope = scope;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithSecondaryKey(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, global::System.String secondaryKey)
    {
        @selfRef.SecondaryKey = secondaryKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithServiceName(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, global::System.String serviceName)
    {
        @selfRef.ServiceName = serviceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithSid(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, global::System.String sid)
    {
        @selfRef.Sid = sid;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithState(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, global::Pulumi.AzureNative.ApiManagement.SubscriptionState state)
    {
        @selfRef.State = state;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs WithState(this global::Pulumi.AzureNative.ApiManagement.SubscriptionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ApiManagement.SubscriptionState> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.ApiManagement.SubscriptionState>();
        @configure(@item);
        @selfRef.State = @item;
        return @selfRef;
    }

}
