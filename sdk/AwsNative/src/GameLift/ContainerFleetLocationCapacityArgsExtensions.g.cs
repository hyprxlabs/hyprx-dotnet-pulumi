// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.GameLift.Inputs;

namespace Pulumi.AwsNative.GameLift;

public static partial class ContainerFleetLocationCapacityArgsExtensions
{
    public static global::Pulumi.AwsNative.GameLift.Inputs.ContainerFleetLocationCapacityArgs WithDesiredEc2Instances(this global::Pulumi.AwsNative.GameLift.Inputs.ContainerFleetLocationCapacityArgs @selfRef, global::System.Int32 desiredEc2Instances)
    {
        @selfRef.DesiredEc2Instances = desiredEc2Instances;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GameLift.Inputs.ContainerFleetLocationCapacityArgs WithMaxSize(this global::Pulumi.AwsNative.GameLift.Inputs.ContainerFleetLocationCapacityArgs @selfRef, global::System.Int32 maxSize)
    {
        @selfRef.MaxSize = maxSize;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GameLift.Inputs.ContainerFleetLocationCapacityArgs WithMinSize(this global::Pulumi.AwsNative.GameLift.Inputs.ContainerFleetLocationCapacityArgs @selfRef, global::System.Int32 minSize)
    {
        @selfRef.MinSize = minSize;
        return @selfRef;
    }

}
