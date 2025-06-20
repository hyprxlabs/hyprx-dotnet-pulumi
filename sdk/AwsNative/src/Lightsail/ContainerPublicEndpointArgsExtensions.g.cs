// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Lightsail.Inputs;

namespace Pulumi.AwsNative.Lightsail;

public static partial class ContainerPublicEndpointArgsExtensions
{
    public static global::Pulumi.AwsNative.Lightsail.Inputs.ContainerPublicEndpointArgs WithContainerName(this global::Pulumi.AwsNative.Lightsail.Inputs.ContainerPublicEndpointArgs @selfRef, global::System.String containerName)
    {
        @selfRef.ContainerName = containerName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.Inputs.ContainerPublicEndpointArgs WithContainerPort(this global::Pulumi.AwsNative.Lightsail.Inputs.ContainerPublicEndpointArgs @selfRef, global::System.Int32 containerPort)
    {
        @selfRef.ContainerPort = containerPort;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.Inputs.ContainerPublicEndpointArgs WithHealthCheckConfig(this global::Pulumi.AwsNative.Lightsail.Inputs.ContainerPublicEndpointArgs @selfRef, global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs healthCheckConfig)
    {
        @selfRef.HealthCheckConfig = healthCheckConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Lightsail.Inputs.ContainerPublicEndpointArgs WithHealthCheckConfig(this global::Pulumi.AwsNative.Lightsail.Inputs.ContainerPublicEndpointArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Lightsail.Inputs.ContainerHealthCheckConfigArgs();
        @configure(@item);
        @selfRef.HealthCheckConfig = @item;
        return @selfRef;
    }

}
