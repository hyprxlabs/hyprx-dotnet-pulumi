// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.GameLift.Inputs;

namespace Pulumi.AwsNative.GameLift;

public static partial class ContainerGroupDefinitionContainerMountPointArgsExtensions
{
    public static global::Pulumi.AwsNative.GameLift.Inputs.ContainerGroupDefinitionContainerMountPointArgs WithAccessLevel(this global::Pulumi.AwsNative.GameLift.Inputs.ContainerGroupDefinitionContainerMountPointArgs @selfRef, global::Pulumi.AwsNative.GameLift.ContainerGroupDefinitionContainerMountPointAccessLevel accessLevel)
    {
        @selfRef.AccessLevel = accessLevel;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GameLift.Inputs.ContainerGroupDefinitionContainerMountPointArgs WithAccessLevel(this global::Pulumi.AwsNative.GameLift.Inputs.ContainerGroupDefinitionContainerMountPointArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.GameLift.ContainerGroupDefinitionContainerMountPointAccessLevel> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.GameLift.ContainerGroupDefinitionContainerMountPointAccessLevel>();
        @configure(@item);
        @selfRef.AccessLevel = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GameLift.Inputs.ContainerGroupDefinitionContainerMountPointArgs WithContainerPath(this global::Pulumi.AwsNative.GameLift.Inputs.ContainerGroupDefinitionContainerMountPointArgs @selfRef, global::System.String containerPath)
    {
        @selfRef.ContainerPath = containerPath;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GameLift.Inputs.ContainerGroupDefinitionContainerMountPointArgs WithInstancePath(this global::Pulumi.AwsNative.GameLift.Inputs.ContainerGroupDefinitionContainerMountPointArgs @selfRef, global::System.String instancePath)
    {
        @selfRef.InstancePath = instancePath;
        return @selfRef;
    }

}
