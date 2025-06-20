// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class LoggingConfigArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs WithApplicationLogLevel(this global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AwsConnector.LoggingConfigApplicationLogLevel> applicationLogLevel)
    {
        @selfRef.ApplicationLogLevel = applicationLogLevel;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs WithFailureFeedbackRoleArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs @selfRef, global::System.String failureFeedbackRoleArn)
    {
        @selfRef.FailureFeedbackRoleArn = failureFeedbackRoleArn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs WithLogFormat(this global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AwsConnector.LoggingConfigLogFormat> logFormat)
    {
        @selfRef.LogFormat = logFormat;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs WithLogGroup(this global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs @selfRef, global::System.String logGroup)
    {
        @selfRef.LogGroup = logGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs WithProtocol(this global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AwsConnector.LoggingConfigProtocol> protocol)
    {
        @selfRef.Protocol = protocol;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs WithSuccessFeedbackRoleArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs @selfRef, global::System.String successFeedbackRoleArn)
    {
        @selfRef.SuccessFeedbackRoleArn = successFeedbackRoleArn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs WithSuccessFeedbackSampleRate(this global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs @selfRef, global::System.String successFeedbackSampleRate)
    {
        @selfRef.SuccessFeedbackSampleRate = successFeedbackSampleRate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs WithSystemLogLevel(this global::Pulumi.AzureNative.AwsConnector.Inputs.LoggingConfigArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AwsConnector.LoggingConfigSystemLogLevel> systemLogLevel)
    {
        @selfRef.SystemLogLevel = systemLogLevel;
        return @selfRef;
    }

}
