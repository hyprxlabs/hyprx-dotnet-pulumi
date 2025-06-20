// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerRegistry.Inputs;

namespace Pulumi.AzureNative.ContainerRegistry;

public static partial class PipelineRunRequestArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs WithArtifacts(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs @selfRef, global::System.Collections.Generic.List<global::System.String> artifacts)
    {
        @selfRef.Artifacts = artifacts;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs WithArtifacts(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Artifacts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs WithArtifacts(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Artifacts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs WithCatalogDigest(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs @selfRef, global::System.String catalogDigest)
    {
        @selfRef.CatalogDigest = catalogDigest;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs WithPipelineResourceId(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs @selfRef, global::System.String pipelineResourceId)
    {
        @selfRef.PipelineResourceId = pipelineResourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs WithSource(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs @selfRef, global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunSourcePropertiesArgs source)
    {
        @selfRef.Source = source;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs WithSource(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunSourcePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunSourcePropertiesArgs();
        @configure(@item);
        @selfRef.Source = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs WithTarget(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs @selfRef, global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunTargetPropertiesArgs target)
    {
        @selfRef.Target = target;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs WithTarget(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunRequestArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunTargetPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerRegistry.Inputs.PipelineRunTargetPropertiesArgs();
        @configure(@item);
        @selfRef.Target = @item;
        return @selfRef;
    }

}
