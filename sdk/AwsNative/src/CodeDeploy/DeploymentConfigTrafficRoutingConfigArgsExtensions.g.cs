// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CodeDeploy.Inputs;

namespace Pulumi.AwsNative.CodeDeploy;

public static partial class DeploymentConfigTrafficRoutingConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTrafficRoutingConfigArgs WithTimeBasedCanary(this global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTrafficRoutingConfigArgs @selfRef, global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTimeBasedCanaryArgs timeBasedCanary)
    {
        @selfRef.TimeBasedCanary = timeBasedCanary;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTrafficRoutingConfigArgs WithTimeBasedCanary(this global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTrafficRoutingConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTimeBasedCanaryArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTimeBasedCanaryArgs();
        @configure(@item);
        @selfRef.TimeBasedCanary = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTrafficRoutingConfigArgs WithTimeBasedLinear(this global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTrafficRoutingConfigArgs @selfRef, global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTimeBasedLinearArgs timeBasedLinear)
    {
        @selfRef.TimeBasedLinear = timeBasedLinear;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTrafficRoutingConfigArgs WithTimeBasedLinear(this global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTrafficRoutingConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTimeBasedLinearArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTimeBasedLinearArgs();
        @configure(@item);
        @selfRef.TimeBasedLinear = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTrafficRoutingConfigArgs WithType(this global::Pulumi.AwsNative.CodeDeploy.Inputs.DeploymentConfigTrafficRoutingConfigArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
