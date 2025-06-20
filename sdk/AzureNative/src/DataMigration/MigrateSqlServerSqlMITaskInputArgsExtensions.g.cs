// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataMigration.Inputs;

namespace Pulumi.AzureNative.DataMigration;

public static partial class MigrateSqlServerSqlMITaskInputArgsExtensions
{
    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithAadDomainName(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.String aadDomainName)
    {
        @selfRef.AadDomainName = aadDomainName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithBackupBlobShare(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.BlobShareArgs backupBlobShare)
    {
        @selfRef.BackupBlobShare = backupBlobShare;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithBackupBlobShare(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.BlobShareArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.BlobShareArgs();
        @configure(@item);
        @selfRef.BackupBlobShare = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithBackupFileShare(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.FileShareArgs backupFileShare)
    {
        @selfRef.BackupFileShare = backupFileShare;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithBackupFileShare(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.FileShareArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.FileShareArgs();
        @configure(@item);
        @selfRef.BackupFileShare = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithBackupMode(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataMigration.BackupMode> backupMode)
    {
        @selfRef.BackupMode = backupMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithEncryptedKeyForSecureFields(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.String encryptedKeyForSecureFields)
    {
        @selfRef.EncryptedKeyForSecureFields = encryptedKeyForSecureFields;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithSelectedAgentJobs(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Collections.Generic.List<global::System.String> selectedAgentJobs)
    {
        @selfRef.SelectedAgentJobs = selectedAgentJobs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithSelectedAgentJobs(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SelectedAgentJobs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithSelectedAgentJobs(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SelectedAgentJobs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithSelectedDatabases(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMIDatabaseInputArgs> selectedDatabases)
    {
        @selfRef.SelectedDatabases = selectedDatabases;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithSelectedDatabases(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMIDatabaseInputArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMIDatabaseInputArgs>();
        @configure(@list);
        @selfRef.SelectedDatabases = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithSelectedDatabases(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMIDatabaseInputArgs>> @create)
    {
        @selfRef.SelectedDatabases = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithSelectedLogins(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Collections.Generic.List<global::System.String> selectedLogins)
    {
        @selfRef.SelectedLogins = selectedLogins;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithSelectedLogins(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.SelectedLogins = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithSelectedLogins(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.SelectedLogins = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithSourceConnectionInfo(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs sourceConnectionInfo)
    {
        @selfRef.SourceConnectionInfo = sourceConnectionInfo;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithSourceConnectionInfo(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs();
        @configure(@item);
        @selfRef.SourceConnectionInfo = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithStartedOn(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.String startedOn)
    {
        @selfRef.StartedOn = startedOn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithTargetConnectionInfo(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs targetConnectionInfo)
    {
        @selfRef.TargetConnectionInfo = targetConnectionInfo;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs WithTargetConnectionInfo(this global::Pulumi.AzureNative.DataMigration.Inputs.MigrateSqlServerSqlMITaskInputArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs();
        @configure(@item);
        @selfRef.TargetConnectionInfo = @item;
        return @selfRef;
    }

}
