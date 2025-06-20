// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DBforMariaDB.Inputs;

namespace Pulumi.AzureNative.DBforMariaDB;

public static partial class SkuArgsExtensions
{
    public static global::Pulumi.AzureNative.DBforMariaDB.Inputs.SkuArgs WithCapacity(this global::Pulumi.AzureNative.DBforMariaDB.Inputs.SkuArgs @selfRef, global::System.Int32 capacity)
    {
        @selfRef.Capacity = capacity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMariaDB.Inputs.SkuArgs WithFamily(this global::Pulumi.AzureNative.DBforMariaDB.Inputs.SkuArgs @selfRef, global::System.String family)
    {
        @selfRef.Family = family;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMariaDB.Inputs.SkuArgs WithName(this global::Pulumi.AzureNative.DBforMariaDB.Inputs.SkuArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMariaDB.Inputs.SkuArgs WithSize(this global::Pulumi.AzureNative.DBforMariaDB.Inputs.SkuArgs @selfRef, global::System.String size)
    {
        @selfRef.Size = size;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMariaDB.Inputs.SkuArgs WithTier(this global::Pulumi.AzureNative.DBforMariaDB.Inputs.SkuArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforMariaDB.SkuTier> tier)
    {
        @selfRef.Tier = tier;
        return @selfRef;
    }

}
