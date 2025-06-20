// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class BlobTriggerArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> annotations)
    {
        @selfRef.Annotations = annotations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.Annotations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.Annotations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs WithFolderPath(this global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs @selfRef, global::System.String folderPath)
    {
        @selfRef.FolderPath = folderPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs WithLinkedService(this global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs linkedService)
    {
        @selfRef.LinkedService = linkedService;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs WithLinkedService(this global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs();
        @configure(@item);
        @selfRef.LinkedService = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs WithMaxConcurrency(this global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs @selfRef, global::System.Int32 maxConcurrency)
    {
        @selfRef.MaxConcurrency = maxConcurrency;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs WithPipelines(this global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs> pipelines)
    {
        @selfRef.Pipelines = pipelines;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs WithPipelines(this global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs>();
        @configure(@list);
        @selfRef.Pipelines = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs WithPipelines(this global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs>> @create)
    {
        @selfRef.Pipelines = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.BlobTriggerArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
