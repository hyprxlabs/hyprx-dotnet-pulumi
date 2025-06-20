// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.CosmosDB.Inputs;

namespace Pulumi.AzureNative.CosmosDB;

public static partial class MongoDBCollectionResourceArgsExtensions
{
    public static global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs WithAnalyticalStorageTtl(this global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs @selfRef, global::System.Int32 analyticalStorageTtl)
    {
        @selfRef.AnalyticalStorageTtl = analyticalStorageTtl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs WithCreateMode(this global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CosmosDB.CreateMode> createMode)
    {
        @selfRef.CreateMode = createMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs WithId(this global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs WithIndexes(this global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.CosmosDB.Inputs.MongoIndexArgs> indexes)
    {
        @selfRef.Indexes = indexes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs WithIndexes(this global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.CosmosDB.Inputs.MongoIndexArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.CosmosDB.Inputs.MongoIndexArgs>();
        @configure(@list);
        @selfRef.Indexes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs WithIndexes(this global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.CosmosDB.Inputs.MongoIndexArgs>> @create)
    {
        @selfRef.Indexes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs WithRestoreParameters(this global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs @selfRef, global::Pulumi.AzureNative.CosmosDB.Inputs.ResourceRestoreParametersArgs restoreParameters)
    {
        @selfRef.RestoreParameters = restoreParameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs WithRestoreParameters(this global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.CosmosDB.Inputs.ResourceRestoreParametersArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.CosmosDB.Inputs.ResourceRestoreParametersArgs();
        @configure(@item);
        @selfRef.RestoreParameters = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs WithShardKey(this global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> shardKey)
    {
        @selfRef.ShardKey = shardKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs WithShardKey(this global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.ShardKey = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs WithShardKey(this global::Pulumi.AzureNative.CosmosDB.Inputs.MongoDBCollectionResourceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.ShardKey = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
