// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class LabelingJobArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithComponentId(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.String componentId)
    {
        @selfRef.ComponentId = componentId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithComputeId(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.String computeId)
    {
        @selfRef.ComputeId = computeId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithDataConfiguration(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingDataConfigurationArgs dataConfiguration)
    {
        @selfRef.DataConfiguration = dataConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithDataConfiguration(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingDataConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingDataConfigurationArgs();
        @configure(@item);
        @selfRef.DataConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithDescription(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithDisplayName(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithExperimentName(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.String experimentName)
    {
        @selfRef.ExperimentName = experimentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithIsArchived(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, bool isArchived = true)
    {
        @selfRef.IsArchived = isArchived;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithJobInstructions(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobInstructionsArgs jobInstructions)
    {
        @selfRef.JobInstructions = jobInstructions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithJobInstructions(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobInstructionsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobInstructionsArgs();
        @configure(@item);
        @selfRef.JobInstructions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithJobType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.String jobType)
    {
        @selfRef.JobType = jobType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithLabelCategories(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelCategoryArgs> labelCategories)
    {
        @selfRef.LabelCategories = labelCategories;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithLabelCategories(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelCategoryArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelCategoryArgs>();
        @configure(@dict);
        @selfRef.LabelCategories = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithLabelCategories(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelCategoryArgs>> @create)
    {
        @selfRef.LabelCategories = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithLabelingJobMediaProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobImagePropertiesArgs, global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobTextPropertiesArgs> labelingJobMediaProperties)
    {
        @selfRef.LabelingJobMediaProperties = labelingJobMediaProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithMlAssistConfiguration(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.MachineLearningServices.Inputs.MLAssistConfigurationDisabledArgs, global::Pulumi.AzureNative.MachineLearningServices.Inputs.MLAssistConfigurationEnabledArgs> mlAssistConfiguration)
    {
        @selfRef.MlAssistConfiguration = mlAssistConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithNotificationSetting(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.NotificationSettingArgs notificationSetting)
    {
        @selfRef.NotificationSetting = notificationSetting;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithNotificationSetting(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.NotificationSettingArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.NotificationSettingArgs();
        @configure(@item);
        @selfRef.NotificationSetting = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Properties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Properties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithSecretsConfiguration(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.SecretConfigurationArgs> secretsConfiguration)
    {
        @selfRef.SecretsConfiguration = secretsConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithSecretsConfiguration(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.SecretConfigurationArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.SecretConfigurationArgs>();
        @configure(@dict);
        @selfRef.SecretsConfiguration = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithSecretsConfiguration(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.SecretConfigurationArgs>> @create)
    {
        @selfRef.SecretsConfiguration = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithServices(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.JobServiceArgs> services)
    {
        @selfRef.Services = services;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithServices(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.JobServiceArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.JobServiceArgs>();
        @configure(@dict);
        @selfRef.Services = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithServices(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.MachineLearningServices.Inputs.JobServiceArgs>> @create)
    {
        @selfRef.Services = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithTags(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithTags(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs WithTags(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.LabelingJobArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
