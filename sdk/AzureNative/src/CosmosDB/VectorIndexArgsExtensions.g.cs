// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.CosmosDB.Inputs;

namespace Pulumi.AzureNative.CosmosDB;

public static partial class VectorIndexArgsExtensions
{
    public static global::Pulumi.AzureNative.CosmosDB.Inputs.VectorIndexArgs WithPath(this global::Pulumi.AzureNative.CosmosDB.Inputs.VectorIndexArgs @selfRef, global::System.String path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.VectorIndexArgs WithType(this global::Pulumi.AzureNative.CosmosDB.Inputs.VectorIndexArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CosmosDB.VectorIndexType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
