// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.CosmosDB.Inputs;

namespace Pulumi.AzureNative.CosmosDB;

public static partial class SpatialSpecArgsExtensions
{
    public static global::Pulumi.AzureNative.CosmosDB.Inputs.SpatialSpecArgs WithPath(this global::Pulumi.AzureNative.CosmosDB.Inputs.SpatialSpecArgs @selfRef, global::System.String path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.SpatialSpecArgs WithTypes(this global::Pulumi.AzureNative.CosmosDB.Inputs.SpatialSpecArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CosmosDB.SpatialType>> types)
    {
        @selfRef.Types = types;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.SpatialSpecArgs WithTypes(this global::Pulumi.AzureNative.CosmosDB.Inputs.SpatialSpecArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CosmosDB.SpatialType>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CosmosDB.SpatialType>>();
        @configure(@list);
        @selfRef.Types = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CosmosDB.Inputs.SpatialSpecArgs WithTypes(this global::Pulumi.AzureNative.CosmosDB.Inputs.SpatialSpecArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CosmosDB.SpatialType>>> @create)
    {
        @selfRef.Types = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
