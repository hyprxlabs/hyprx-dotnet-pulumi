// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DBforMySQL.Inputs;

namespace Pulumi.AzureNative.DBforMySQL;

public static partial class MySQLServerSkuArgsExtensions
{
    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.MySQLServerSkuArgs WithName(this global::Pulumi.AzureNative.DBforMySQL.Inputs.MySQLServerSkuArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DBforMySQL.Inputs.MySQLServerSkuArgs WithTier(this global::Pulumi.AzureNative.DBforMySQL.Inputs.MySQLServerSkuArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DBforMySQL.ServerSkuTier> tier)
    {
        @selfRef.Tier = tier;
        return @selfRef;
    }

}
