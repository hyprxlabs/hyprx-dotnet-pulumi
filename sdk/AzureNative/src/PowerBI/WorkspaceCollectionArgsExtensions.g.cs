// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.PowerBI;

public static partial class WorkspaceCollectionArgsExtensions
{
    public static global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs WithLocation(this global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs WithResourceGroupName(this global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs WithSku(this global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs @selfRef, global::Pulumi.AzureNative.PowerBI.Inputs.AzureSkuArgs sku)
    {
        @selfRef.Sku = sku;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs WithSku(this global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.PowerBI.Inputs.AzureSkuArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.PowerBI.Inputs.AzureSkuArgs();
        @configure(@item);
        @selfRef.Sku = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs WithTags(this global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs WithTags(this global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs WithTags(this global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs WithWorkspaceCollectionName(this global::Pulumi.AzureNative.PowerBI.WorkspaceCollectionArgs @selfRef, global::System.String workspaceCollectionName)
    {
        @selfRef.WorkspaceCollectionName = workspaceCollectionName;
        return @selfRef;
    }

}
