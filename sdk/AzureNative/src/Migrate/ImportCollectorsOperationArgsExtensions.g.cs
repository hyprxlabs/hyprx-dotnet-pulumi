// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Migrate;

public static partial class ImportCollectorsOperationArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.ImportCollectorsOperationArgs WithDiscoverySiteId(this global::Pulumi.AzureNative.Migrate.ImportCollectorsOperationArgs @selfRef, global::System.String discoverySiteId)
    {
        @selfRef.DiscoverySiteId = discoverySiteId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.ImportCollectorsOperationArgs WithImportCollectorName(this global::Pulumi.AzureNative.Migrate.ImportCollectorsOperationArgs @selfRef, global::System.String importCollectorName)
    {
        @selfRef.ImportCollectorName = importCollectorName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.ImportCollectorsOperationArgs WithProjectName(this global::Pulumi.AzureNative.Migrate.ImportCollectorsOperationArgs @selfRef, global::System.String projectName)
    {
        @selfRef.ProjectName = projectName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.ImportCollectorsOperationArgs WithProvisioningState(this global::Pulumi.AzureNative.Migrate.ImportCollectorsOperationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.ProvisioningState> provisioningState)
    {
        @selfRef.ProvisioningState = provisioningState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.ImportCollectorsOperationArgs WithResourceGroupName(this global::Pulumi.AzureNative.Migrate.ImportCollectorsOperationArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

}
