// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerRegistry.Inputs;

namespace Pulumi.AzureNative.ContainerRegistry;

public static partial class PipelineRunSourcePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunSourcePropertiesArgs WithName(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunSourcePropertiesArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunSourcePropertiesArgs WithType(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunSourcePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ContainerRegistry.PipelineRunSourceType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
