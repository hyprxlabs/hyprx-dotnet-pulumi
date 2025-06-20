// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataMigration.Inputs;

namespace Pulumi.AzureNative.DataMigration;

public static partial class ConnectToTargetSqlDbTaskInputArgsExtensions
{
    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskInputArgs WithQueryObjectCounts(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskInputArgs @selfRef, bool queryObjectCounts = true)
    {
        @selfRef.QueryObjectCounts = queryObjectCounts;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskInputArgs WithTargetConnectionInfo(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskInputArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs targetConnectionInfo)
    {
        @selfRef.TargetConnectionInfo = targetConnectionInfo;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskInputArgs WithTargetConnectionInfo(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskInputArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs();
        @configure(@item);
        @selfRef.TargetConnectionInfo = @item;
        return @selfRef;
    }

}
