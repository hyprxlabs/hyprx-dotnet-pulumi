// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ecs.Inputs;

namespace Pulumi.AwsNative.Ecs;

public static partial class TaskDefinitionContainerDependencyArgsExtensions
{
    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionContainerDependencyArgs WithCondition(this global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionContainerDependencyArgs @selfRef, global::System.String condition)
    {
        @selfRef.Condition = condition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionContainerDependencyArgs WithContainerName(this global::Pulumi.AwsNative.Ecs.Inputs.TaskDefinitionContainerDependencyArgs @selfRef, global::System.String containerName)
    {
        @selfRef.ContainerName = containerName;
        return @selfRef;
    }

}
