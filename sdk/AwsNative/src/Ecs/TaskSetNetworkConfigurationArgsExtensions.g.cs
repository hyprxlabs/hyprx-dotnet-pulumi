// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ecs.Inputs;

namespace Pulumi.AwsNative.Ecs;

public static partial class TaskSetNetworkConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskSetNetworkConfigurationArgs WithAwsVpcConfiguration(this global::Pulumi.AwsNative.Ecs.Inputs.TaskSetNetworkConfigurationArgs @selfRef, global::Pulumi.AwsNative.Ecs.Inputs.TaskSetAwsVpcConfigurationArgs awsVpcConfiguration)
    {
        @selfRef.AwsVpcConfiguration = awsVpcConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.TaskSetNetworkConfigurationArgs WithAwsVpcConfiguration(this global::Pulumi.AwsNative.Ecs.Inputs.TaskSetNetworkConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ecs.Inputs.TaskSetAwsVpcConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ecs.Inputs.TaskSetAwsVpcConfigurationArgs();
        @configure(@item);
        @selfRef.AwsVpcConfiguration = @item;
        return @selfRef;
    }

}
