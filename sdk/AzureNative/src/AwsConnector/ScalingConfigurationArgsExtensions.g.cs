// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class ScalingConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigurationArgs WithAutoPause(this global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigurationArgs @selfRef, bool autoPause = true)
    {
        @selfRef.AutoPause = autoPause;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigurationArgs WithMaxCapacity(this global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigurationArgs @selfRef, global::System.Int32 maxCapacity)
    {
        @selfRef.MaxCapacity = maxCapacity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigurationArgs WithMinCapacity(this global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigurationArgs @selfRef, global::System.Int32 minCapacity)
    {
        @selfRef.MinCapacity = minCapacity;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigurationArgs WithSecondsBeforeTimeout(this global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigurationArgs @selfRef, global::System.Int32 secondsBeforeTimeout)
    {
        @selfRef.SecondsBeforeTimeout = secondsBeforeTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigurationArgs WithSecondsUntilAutoPause(this global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigurationArgs @selfRef, global::System.Int32 secondsUntilAutoPause)
    {
        @selfRef.SecondsUntilAutoPause = secondsUntilAutoPause;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigurationArgs WithTimeoutAction(this global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigurationArgs @selfRef, global::System.String timeoutAction)
    {
        @selfRef.TimeoutAction = timeoutAction;
        return @selfRef;
    }

}
