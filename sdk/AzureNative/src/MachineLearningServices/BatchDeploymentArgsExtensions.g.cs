// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class BatchDeploymentArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithCodeConfiguration(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.CodeConfigurationArgs codeConfiguration)
    {
        @selfRef.CodeConfiguration = codeConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithCodeConfiguration(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.CodeConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.CodeConfigurationArgs();
        @configure(@item);
        @selfRef.CodeConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithCompute(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.String compute)
    {
        @selfRef.Compute = compute;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithDeploymentConfiguration(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchPipelineComponentDeploymentConfigurationArgs deploymentConfiguration)
    {
        @selfRef.DeploymentConfiguration = deploymentConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithDeploymentConfiguration(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchPipelineComponentDeploymentConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchPipelineComponentDeploymentConfigurationArgs();
        @configure(@item);
        @selfRef.DeploymentConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithDescription(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithEnvironmentId(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.String environmentId)
    {
        @selfRef.EnvironmentId = environmentId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithEnvironmentVariables(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> environmentVariables)
    {
        @selfRef.EnvironmentVariables = environmentVariables;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithEnvironmentVariables(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.EnvironmentVariables = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithEnvironmentVariables(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.EnvironmentVariables = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithErrorThreshold(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Int32 errorThreshold)
    {
        @selfRef.ErrorThreshold = errorThreshold;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithLoggingLevel(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.BatchLoggingLevel> loggingLevel)
    {
        @selfRef.LoggingLevel = loggingLevel;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithMaxConcurrencyPerInstance(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Int32 maxConcurrencyPerInstance)
    {
        @selfRef.MaxConcurrencyPerInstance = maxConcurrencyPerInstance;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithMiniBatchSize(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Double miniBatchSize)
    {
        @selfRef.MiniBatchSize = miniBatchSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithOutputAction(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.BatchOutputAction> outputAction)
    {
        @selfRef.OutputAction = outputAction;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithOutputFileName(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.String outputFileName)
    {
        @selfRef.OutputFileName = outputFileName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Properties = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithProperties(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Properties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithResources(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.DeploymentResourceConfigurationArgs resources)
    {
        @selfRef.Resources = resources;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithResources(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.DeploymentResourceConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.DeploymentResourceConfigurationArgs();
        @configure(@item);
        @selfRef.Resources = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithRetrySettings(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchRetrySettingsArgs retrySettings)
    {
        @selfRef.RetrySettings = retrySettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs WithRetrySettings(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchDeploymentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchRetrySettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.MachineLearningServices.Inputs.BatchRetrySettingsArgs();
        @configure(@item);
        @selfRef.RetrySettings = @item;
        return @selfRef;
    }

}
