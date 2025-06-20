// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class EndpointDeploymentConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.EndpointDeploymentConfigArgs WithAutoRollbackConfiguration(this global::Pulumi.AwsNative.SageMaker.Inputs.EndpointDeploymentConfigArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAutoRollbackConfigArgs autoRollbackConfiguration)
    {
        @selfRef.AutoRollbackConfiguration = autoRollbackConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.EndpointDeploymentConfigArgs WithAutoRollbackConfiguration(this global::Pulumi.AwsNative.SageMaker.Inputs.EndpointDeploymentConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAutoRollbackConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.EndpointAutoRollbackConfigArgs();
        @configure(@item);
        @selfRef.AutoRollbackConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.EndpointDeploymentConfigArgs WithBlueGreenUpdatePolicy(this global::Pulumi.AwsNative.SageMaker.Inputs.EndpointDeploymentConfigArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.EndpointBlueGreenUpdatePolicyArgs blueGreenUpdatePolicy)
    {
        @selfRef.BlueGreenUpdatePolicy = blueGreenUpdatePolicy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.EndpointDeploymentConfigArgs WithBlueGreenUpdatePolicy(this global::Pulumi.AwsNative.SageMaker.Inputs.EndpointDeploymentConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.EndpointBlueGreenUpdatePolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.EndpointBlueGreenUpdatePolicyArgs();
        @configure(@item);
        @selfRef.BlueGreenUpdatePolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.EndpointDeploymentConfigArgs WithRollingUpdatePolicy(this global::Pulumi.AwsNative.SageMaker.Inputs.EndpointDeploymentConfigArgs @selfRef, global::Pulumi.AwsNative.SageMaker.Inputs.EndpointRollingUpdatePolicyArgs rollingUpdatePolicy)
    {
        @selfRef.RollingUpdatePolicy = rollingUpdatePolicy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.EndpointDeploymentConfigArgs WithRollingUpdatePolicy(this global::Pulumi.AwsNative.SageMaker.Inputs.EndpointDeploymentConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.SageMaker.Inputs.EndpointRollingUpdatePolicyArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.SageMaker.Inputs.EndpointRollingUpdatePolicyArgs();
        @configure(@item);
        @selfRef.RollingUpdatePolicy = @item;
        return @selfRef;
    }

}
