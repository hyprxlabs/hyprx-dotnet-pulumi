// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.IoTOperationsDataProcessor;

public static partial class PipelineArgsExtensions
{
    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithDescription(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithEnabled(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithExtendedLocation(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsDataProcessor.Inputs.ExtendedLocationArgs extendedLocation)
    {
        @selfRef.ExtendedLocation = extendedLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithExtendedLocation(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsDataProcessor.Inputs.ExtendedLocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsDataProcessor.Inputs.ExtendedLocationArgs();
        @configure(@item);
        @selfRef.ExtendedLocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithInput(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::Pulumi.AzureNative.IoTOperationsDataProcessor.Inputs.PipelineInputArgs input)
    {
        @selfRef.Input = input;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithInput(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.IoTOperationsDataProcessor.Inputs.PipelineInputArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.IoTOperationsDataProcessor.Inputs.PipelineInputArgs();
        @configure(@item);
        @selfRef.Input = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithInstanceName(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.String instanceName)
    {
        @selfRef.InstanceName = instanceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithLocation(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithPipelineName(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.String pipelineName)
    {
        @selfRef.PipelineName = pipelineName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithResourceGroupName(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithStages(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.IoTOperationsDataProcessor.Inputs.PipelineStageArgs> stages)
    {
        @selfRef.Stages = stages;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithStages(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.IoTOperationsDataProcessor.Inputs.PipelineStageArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.IoTOperationsDataProcessor.Inputs.PipelineStageArgs>();
        @configure(@dict);
        @selfRef.Stages = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithStages(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.IoTOperationsDataProcessor.Inputs.PipelineStageArgs>> @create)
    {
        @selfRef.Stages = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs WithTags(this global::Pulumi.AzureNative.IoTOperationsDataProcessor.PipelineArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
