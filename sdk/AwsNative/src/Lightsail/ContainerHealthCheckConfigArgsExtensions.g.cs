// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lightsail.Inputs;

namespace Pulumi.AwsNative.Lightsail;

public static partial class ContainerHealthCheckConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs WithHealthyThreshold(this global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs @selfRef, global::System.Int32 healthyThreshold)
    {
        @selfRef.HealthyThreshold = healthyThreshold;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs WithIntervalSeconds(this global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs @selfRef, global::System.Int32 intervalSeconds)
    {
        @selfRef.IntervalSeconds = intervalSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs WithPath(this global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs @selfRef, global::System.String path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs WithSuccessCodes(this global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs @selfRef, global::System.String successCodes)
    {
        @selfRef.SuccessCodes = successCodes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs WithTimeoutSeconds(this global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs @selfRef, global::System.Int32 timeoutSeconds)
    {
        @selfRef.TimeoutSeconds = timeoutSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs WithUnhealthyThreshold(this global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs @selfRef, global::System.Int32 unhealthyThreshold)
    {
        @selfRef.UnhealthyThreshold = unhealthyThreshold;
        return @selfRef;
    }

}
