// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Databricks.Inputs;

namespace Pulumi.AzureNative.Databricks;

public static partial class SkuArgsExtensions
{
    public static global::Pulumi.AzureNative.Databricks.Inputs.SkuArgs WithName(this global::Pulumi.AzureNative.Databricks.Inputs.SkuArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Databricks.Inputs.SkuArgs WithTier(this global::Pulumi.AzureNative.Databricks.Inputs.SkuArgs @selfRef, global::System.String tier)
    {
        @selfRef.Tier = tier;
        return @selfRef;
    }

}
