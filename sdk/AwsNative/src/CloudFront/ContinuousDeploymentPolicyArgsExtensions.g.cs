// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.CloudFront;

public static partial class ContinuousDeploymentPolicyArgsExtensions
{
    public static global::Pulumi.AwsNative.CloudFront.ContinuousDeploymentPolicyArgs WithContinuousDeploymentPolicyConfig(this global::Pulumi.AwsNative.CloudFront.ContinuousDeploymentPolicyArgs @selfRef, global::Pulumi.AwsNative.CloudFront.Inputs.ContinuousDeploymentPolicyConfigArgs continuousDeploymentPolicyConfig)
    {
        @selfRef.ContinuousDeploymentPolicyConfig = continuousDeploymentPolicyConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFront.ContinuousDeploymentPolicyArgs WithContinuousDeploymentPolicyConfig(this global::Pulumi.AwsNative.CloudFront.ContinuousDeploymentPolicyArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.CloudFront.Inputs.ContinuousDeploymentPolicyConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.CloudFront.Inputs.ContinuousDeploymentPolicyConfigArgs();
        @configure(@item);
        @selfRef.ContinuousDeploymentPolicyConfig = @item;
        return @selfRef;
    }

}
