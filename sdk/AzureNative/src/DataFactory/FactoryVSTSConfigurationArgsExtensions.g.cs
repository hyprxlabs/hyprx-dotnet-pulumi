// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class FactoryVSTSConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs WithAccountName(this global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs @selfRef, global::System.String accountName)
    {
        @selfRef.AccountName = accountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs WithCollaborationBranch(this global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs @selfRef, global::System.String collaborationBranch)
    {
        @selfRef.CollaborationBranch = collaborationBranch;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs WithDisablePublish(this global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs @selfRef, bool disablePublish = true)
    {
        @selfRef.DisablePublish = disablePublish;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs WithLastCommitId(this global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs @selfRef, global::System.String lastCommitId)
    {
        @selfRef.LastCommitId = lastCommitId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs WithProjectName(this global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs @selfRef, global::System.String projectName)
    {
        @selfRef.ProjectName = projectName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs WithRepositoryName(this global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs @selfRef, global::System.String repositoryName)
    {
        @selfRef.RepositoryName = repositoryName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs WithRootFolder(this global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs @selfRef, global::System.String rootFolder)
    {
        @selfRef.RootFolder = rootFolder;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs WithTenantId(this global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs @selfRef, global::System.String tenantId)
    {
        @selfRef.TenantId = tenantId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.FactoryVSTSConfigurationArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
