// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.SqlVirtualMachine.Inputs;

namespace Pulumi.AzureNative.SqlVirtualMachine;

public static partial class WsfcDomainProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs WithClusterBootstrapAccount(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs @selfRef, global::System.String clusterBootstrapAccount)
    {
        @selfRef.ClusterBootstrapAccount = clusterBootstrapAccount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs WithClusterOperatorAccount(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs @selfRef, global::System.String clusterOperatorAccount)
    {
        @selfRef.ClusterOperatorAccount = clusterOperatorAccount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs WithClusterSubnetType(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.SqlVirtualMachine.ClusterSubnetType> clusterSubnetType)
    {
        @selfRef.ClusterSubnetType = clusterSubnetType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs WithDomainFqdn(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs @selfRef, global::System.String domainFqdn)
    {
        @selfRef.DomainFqdn = domainFqdn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs WithFileShareWitnessPath(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs @selfRef, global::System.String fileShareWitnessPath)
    {
        @selfRef.FileShareWitnessPath = fileShareWitnessPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs WithIsSqlServiceAccountGmsa(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs @selfRef, bool isSqlServiceAccountGmsa = true)
    {
        @selfRef.IsSqlServiceAccountGmsa = isSqlServiceAccountGmsa;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs WithOuPath(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs @selfRef, global::System.String ouPath)
    {
        @selfRef.OuPath = ouPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs WithSqlServiceAccount(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs @selfRef, global::System.String sqlServiceAccount)
    {
        @selfRef.SqlServiceAccount = sqlServiceAccount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs WithStorageAccountPrimaryKey(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs @selfRef, global::System.String storageAccountPrimaryKey)
    {
        @selfRef.StorageAccountPrimaryKey = storageAccountPrimaryKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs WithStorageAccountUrl(this global::Pulumi.AzureNative.SqlVirtualMachine.Inputs.WsfcDomainProfileArgs @selfRef, global::System.String storageAccountUrl)
    {
        @selfRef.StorageAccountUrl = storageAccountUrl;
        return @selfRef;
    }

}
