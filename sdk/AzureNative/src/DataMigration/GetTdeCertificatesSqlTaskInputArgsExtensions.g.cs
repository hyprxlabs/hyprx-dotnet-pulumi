// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataMigration.Inputs;

namespace Pulumi.AzureNative.DataMigration;

public static partial class GetTdeCertificatesSqlTaskInputArgsExtensions
{
    public static global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs WithBackupFileShare(this global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.FileShareArgs backupFileShare)
    {
        @selfRef.BackupFileShare = backupFileShare;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs WithBackupFileShare(this global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.FileShareArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.FileShareArgs();
        @configure(@item);
        @selfRef.BackupFileShare = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs WithConnectionInfo(this global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs @selfRef, global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs connectionInfo)
    {
        @selfRef.ConnectionInfo = connectionInfo;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs WithConnectionInfo(this global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataMigration.Inputs.SqlConnectionInfoArgs();
        @configure(@item);
        @selfRef.ConnectionInfo = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs WithSelectedCertificates(this global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataMigration.Inputs.SelectedCertificateInputArgs> selectedCertificates)
    {
        @selfRef.SelectedCertificates = selectedCertificates;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs WithSelectedCertificates(this global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataMigration.Inputs.SelectedCertificateInputArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataMigration.Inputs.SelectedCertificateInputArgs>();
        @configure(@list);
        @selfRef.SelectedCertificates = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs WithSelectedCertificates(this global::Pulumi.AzureNative.DataMigration.Inputs.GetTdeCertificatesSqlTaskInputArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataMigration.Inputs.SelectedCertificateInputArgs>> @create)
    {
        @selfRef.SelectedCertificates = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
