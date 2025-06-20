// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataMigration.Inputs;

namespace Pulumi.AzureNative.DataMigration;

public static partial class ConnectToTargetSqlMITaskInputArgsExtensions
{
    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlMITaskInputArgs WithCollectAgentJobs(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlMITaskInputArgs @selfRef, bool collectAgentJobs = true)
    {
        @selfRef.CollectAgentJobs = collectAgentJobs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlMITaskInputArgs WithCollectLogins(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlMITaskInputArgs @selfRef, bool collectLogins = true)
    {
        @selfRef.CollectLogins = collectLogins;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlMITaskInputArgs WithTargetConnectionInfo(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlMITaskInputArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs targetConnectionInfo)
    {
        @selfRef.TargetConnectionInfo = targetConnectionInfo;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlMITaskInputArgs WithTargetConnectionInfo(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlMITaskInputArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs();
        @configure(@item);
        @selfRef.TargetConnectionInfo = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlMITaskInputArgs WithValidateSsisCatalogOnly(this global::Pulumi.AzureNative.DataMigration.Inputs.ConnectToTargetSqlMITaskInputArgs @selfRef, bool validateSsisCatalogOnly = true)
    {
        @selfRef.ValidateSsisCatalogOnly = validateSsisCatalogOnly;
        return @selfRef;
    }

}
