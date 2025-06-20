// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Marketplace;

public static partial class PrivateStoreCollectionArgsExtensions
{
    public static global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs WithAllSubscriptions(this global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs @selfRef, bool allSubscriptions = true)
    {
        @selfRef.AllSubscriptions = allSubscriptions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs WithClaim(this global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs @selfRef, global::System.String claim)
    {
        @selfRef.Claim = claim;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs WithCollectionId(this global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs @selfRef, global::System.String collectionId)
    {
        @selfRef.CollectionId = collectionId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs WithCollectionName(this global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs @selfRef, global::System.String collectionName)
    {
        @selfRef.CollectionName = collectionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs WithEnabled(this global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs WithPrivateStoreId(this global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs @selfRef, global::System.String privateStoreId)
    {
        @selfRef.PrivateStoreId = privateStoreId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs WithSubscriptionsList(this global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subscriptionsList)
    {
        @selfRef.SubscriptionsList = subscriptionsList;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs WithSubscriptionsList(this global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SubscriptionsList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs WithSubscriptionsList(this global::Pulumi.AzureNative.Marketplace.PrivateStoreCollectionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SubscriptionsList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
