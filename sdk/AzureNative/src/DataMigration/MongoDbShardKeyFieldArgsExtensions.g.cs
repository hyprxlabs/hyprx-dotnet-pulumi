// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataMigration.Inputs;

namespace Pulumi.AzureNative.DataMigration;

public static partial class MongoDbShardKeyFieldArgsExtensions
{
    public static global::Pulumi.AzureNative.DataMigration.Inputs.MongoDbShardKeyFieldArgs WithName(this global::Pulumi.AzureNative.DataMigration.Inputs.MongoDbShardKeyFieldArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MongoDbShardKeyFieldArgs WithOrder(this global::Pulumi.AzureNative.DataMigration.Inputs.MongoDbShardKeyFieldArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataMigration.MongoDbShardKeyOrder> order)
    {
        @selfRef.Order = order;
        return @selfRef;
    }

}
