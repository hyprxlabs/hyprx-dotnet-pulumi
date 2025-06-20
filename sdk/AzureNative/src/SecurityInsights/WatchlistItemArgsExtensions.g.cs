// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.SecurityInsights;

public static partial class WatchlistItemArgsExtensions
{
    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithCreated(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.String created)
    {
        @selfRef.Created = created;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithCreatedBy(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::Pulumi.AzureNative.SecurityInsights.Inputs.WatchlistUserInfoArgs createdBy)
    {
        @selfRef.CreatedBy = createdBy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithCreatedBy(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.SecurityInsights.Inputs.WatchlistUserInfoArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.SecurityInsights.Inputs.WatchlistUserInfoArgs();
        @configure(@item);
        @selfRef.CreatedBy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithEntityMapping(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.Object entityMapping)
    {
        @selfRef.EntityMapping = entityMapping;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithEntityMapping(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.EntityMapping = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithIsDeleted(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, bool isDeleted = true)
    {
        @selfRef.IsDeleted = isDeleted;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithItemsKeyValue(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.Object itemsKeyValue)
    {
        @selfRef.ItemsKeyValue = itemsKeyValue;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithItemsKeyValue(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ItemsKeyValue = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithResourceGroupName(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithTenantId(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.String tenantId)
    {
        @selfRef.TenantId = tenantId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithUpdated(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.String updated)
    {
        @selfRef.Updated = updated;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithUpdatedBy(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::Pulumi.AzureNative.SecurityInsights.Inputs.WatchlistUserInfoArgs updatedBy)
    {
        @selfRef.UpdatedBy = updatedBy;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithUpdatedBy(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.SecurityInsights.Inputs.WatchlistUserInfoArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.SecurityInsights.Inputs.WatchlistUserInfoArgs();
        @configure(@item);
        @selfRef.UpdatedBy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithWatchlistAlias(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.String watchlistAlias)
    {
        @selfRef.WatchlistAlias = watchlistAlias;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithWatchlistItemId(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.String watchlistItemId)
    {
        @selfRef.WatchlistItemId = watchlistItemId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithWatchlistItemType(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.String watchlistItemType)
    {
        @selfRef.WatchlistItemType = watchlistItemType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs WithWorkspaceName(this global::Pulumi.AzureNative.SecurityInsights.WatchlistItemArgs @selfRef, global::System.String workspaceName)
    {
        @selfRef.WorkspaceName = workspaceName;
        return @selfRef;
    }

}
