// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ecs.Inputs;

namespace Pulumi.AwsNative.Ecs;

public static partial class TaskSetLoadBalancerArgsExtensions
{
    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskSetLoadBalancerArgs WithContainerName(this global::Pulumi.AwsNative.Ecs.Inputs.TaskSetLoadBalancerArgs @selfRef, global::System.String containerName)
    {
        @selfRef.ContainerName = containerName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskSetLoadBalancerArgs WithContainerPort(this global::Pulumi.AwsNative.Ecs.Inputs.TaskSetLoadBalancerArgs @selfRef, global::System.Int32 containerPort)
    {
        @selfRef.ContainerPort = containerPort;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskSetLoadBalancerArgs WithTargetGroupArn(this global::Pulumi.AwsNative.Ecs.Inputs.TaskSetLoadBalancerArgs @selfRef, global::System.String targetGroupArn)
    {
        @selfRef.TargetGroupArn = targetGroupArn;
        return @selfRef;
    }

}
