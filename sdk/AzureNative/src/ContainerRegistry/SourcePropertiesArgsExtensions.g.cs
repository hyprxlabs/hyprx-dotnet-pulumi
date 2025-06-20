// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerRegistry.Inputs;

namespace Pulumi.AzureNative.ContainerRegistry;

public static partial class SourcePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.SourcePropertiesArgs WithBranch(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.SourcePropertiesArgs @selfRef, global::System.String branch)
    {
        @selfRef.Branch = branch;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.SourcePropertiesArgs WithRepositoryUrl(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.SourcePropertiesArgs @selfRef, global::System.String repositoryUrl)
    {
        @selfRef.RepositoryUrl = repositoryUrl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.SourcePropertiesArgs WithSourceControlAuthProperties(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.SourcePropertiesArgs @selfRef, global::Pulumi.AzureNative.ContainerRegistry.Inputs.AuthInfoArgs sourceControlAuthProperties)
    {
        @selfRef.SourceControlAuthProperties = sourceControlAuthProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.SourcePropertiesArgs WithSourceControlAuthProperties(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.SourcePropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerRegistry.Inputs.AuthInfoArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerRegistry.Inputs.AuthInfoArgs();
        @configure(@item);
        @selfRef.SourceControlAuthProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.SourcePropertiesArgs WithSourceControlType(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.SourcePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ContainerRegistry.SourceControlType> sourceControlType)
    {
        @selfRef.SourceControlType = sourceControlType;
        return @selfRef;
    }

}
