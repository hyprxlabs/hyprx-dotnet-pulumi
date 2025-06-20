// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataMigration.Inputs;

namespace Pulumi.AzureNative.DataMigration;

public static partial class ConnectToTargetSqlDbTaskPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs WithClientData(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> clientData)
    {
        @selfRef.ClientData = clientData;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs WithClientData(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.ClientData = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs WithClientData(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.ClientData = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs WithCreatedOn(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs @selfRef, global::System.String createdOn)
    {
        @selfRef.CreatedOn = createdOn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs WithInput(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskInputArgs input)
    {
        @selfRef.Input = input;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs WithInput(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskInputArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskInputArgs();
        @configure(@item);
        @selfRef.Input = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs WithTaskType(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlDbTaskPropertiesArgs @selfRef, global::System.String taskType)
    {
        @selfRef.TaskType = taskType;
        return @selfRef;
    }

}
