// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class PipelineJobArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithComponentId(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.String componentId)
    {
        @selfRef.ComponentId = componentId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithComputeId(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.String computeId)
    {
        @selfRef.ComputeId = computeId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithDescription(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithDisplayName(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithExperimentName(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.String experimentName)
    {
        @selfRef.ExperimentName = experimentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithInputs(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.Object> inputs)
    {
        @selfRef.Inputs = inputs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithInputs(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Object>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.Object>();
        @configure(@dict);
        @selfRef.Inputs = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithInputs(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.Object>> @create)
    {
        @selfRef.Inputs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithIsArchived(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, bool isArchived = true)
    {
        @selfRef.IsArchived = isArchived;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithJobType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.String jobType)
    {
        @selfRef.JobType = jobType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithJobs(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.Object> jobs)
    {
        @selfRef.Jobs = jobs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithJobs(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Object>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.Object>();
        @configure(@dict);
        @selfRef.Jobs = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithJobs(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.Object>> @create)
    {
        @selfRef.Jobs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithNotificationSetting(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.NotificationSettingArgs notificationSetting)
    {
        @selfRef.NotificationSetting = notificationSetting;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithNotificationSetting(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.NotificationSettingArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.NotificationSettingArgs();
        @configure(@item);
        @selfRef.NotificationSetting = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithOutputs(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.Object> outputs)
    {
        @selfRef.Outputs = outputs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithOutputs(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.Object>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.Object>();
        @configure(@dict);
        @selfRef.Outputs = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithOutputs(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.Object>> @create)
    {
        @selfRef.Outputs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Properties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Properties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithServices(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.JobServiceArgs> services)
    {
        @selfRef.Services = services;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithServices(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.JobServiceArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.JobServiceArgs>();
        @configure(@dict);
        @selfRef.Services = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithServices(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.JobServiceArgs>> @create)
    {
        @selfRef.Services = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithSettings(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Object settings)
    {
        @selfRef.Settings = settings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithSettings(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Settings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithSourceJobId(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.String sourceJobId)
    {
        @selfRef.SourceJobId = sourceJobId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithTags(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithTags(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs WithTags(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.PipelineJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
