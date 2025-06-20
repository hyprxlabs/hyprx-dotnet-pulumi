// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class TriggerPipelineReferenceArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.Object> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Object>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.Object>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.Object>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs WithPipelineReference(this global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.PipelineReferenceArgs pipelineReference)
    {
        @selfRef.PipelineReference = pipelineReference;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs WithPipelineReference(this global::Pulumi.AzureNative.DataFactory.Inputs.TriggerPipelineReferenceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.PipelineReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.PipelineReferenceArgs();
        @configure(@item);
        @selfRef.PipelineReference = @item;
        return @selfRef;
    }

}
