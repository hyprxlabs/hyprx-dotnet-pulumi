// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.StorageMover;

public static partial class JobDefinitionArgsExtensions
{
    public static global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs WithAgentName(this global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs @selfRef, global::System.String agentName)
    {
        @selfRef.AgentName = agentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs WithCopyMode(this global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.StorageMover.CopyMode> copyMode)
    {
        @selfRef.CopyMode = copyMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs WithDescription(this global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs WithJobDefinitionName(this global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs @selfRef, global::System.String jobDefinitionName)
    {
        @selfRef.JobDefinitionName = jobDefinitionName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs WithProjectName(this global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs @selfRef, global::System.String projectName)
    {
        @selfRef.ProjectName = projectName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs WithResourceGroupName(this global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs WithSourceName(this global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs @selfRef, global::System.String sourceName)
    {
        @selfRef.SourceName = sourceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs WithSourceSubpath(this global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs @selfRef, global::System.String sourceSubpath)
    {
        @selfRef.SourceSubpath = sourceSubpath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs WithStorageMoverName(this global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs @selfRef, global::System.String storageMoverName)
    {
        @selfRef.StorageMoverName = storageMoverName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs WithTargetName(this global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs @selfRef, global::System.String targetName)
    {
        @selfRef.TargetName = targetName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs WithTargetSubpath(this global::Pulumi.AzureNative.StorageMover.JobDefinitionArgs @selfRef, global::System.String targetSubpath)
    {
        @selfRef.TargetSubpath = targetSubpath;
        return @selfRef;
    }

}
