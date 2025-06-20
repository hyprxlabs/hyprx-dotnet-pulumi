// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataMigration.Inputs;

namespace Pulumi.AzureNative.DataMigration;

public static partial class MigrateSqlServerSqlDbSyncTaskPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskPropertiesArgs WithClientData(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> clientData)
    {
        @selfRef.ClientData = clientData;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskPropertiesArgs WithClientData(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.ClientData = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskPropertiesArgs WithClientData(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.ClientData = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskPropertiesArgs WithInput(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskPropertiesArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskInputArgs input)
    {
        @selfRef.Input = input;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskPropertiesArgs WithInput(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskInputArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskInputArgs();
        @configure(@item);
        @selfRef.Input = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskPropertiesArgs WithTaskType(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlDbSyncTaskPropertiesArgs @selfRef, global::System.String taskType)
    {
        @selfRef.TaskType = taskType;
        return @selfRef;
    }

}
