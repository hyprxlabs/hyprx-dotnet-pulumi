// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.AutoScaling.Inputs;

namespace Pulumi.AwsNative.AutoScaling;

public static partial class AutoScalingGroupLifecycleHookSpecificationArgsExtensions
{
    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs WithDefaultResult(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs @selfRef, global::System.String defaultResult)
    {
        @selfRef.DefaultResult = defaultResult;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs WithHeartbeatTimeout(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs @selfRef, global::System.Int32 heartbeatTimeout)
    {
        @selfRef.HeartbeatTimeout = heartbeatTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs WithLifecycleHookName(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs @selfRef, global::System.String lifecycleHookName)
    {
        @selfRef.LifecycleHookName = lifecycleHookName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs WithLifecycleTransition(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs @selfRef, global::System.String lifecycleTransition)
    {
        @selfRef.LifecycleTransition = lifecycleTransition;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs WithNotificationMetadata(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs @selfRef, global::System.String notificationMetadata)
    {
        @selfRef.NotificationMetadata = notificationMetadata;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs WithNotificationTargetArn(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs @selfRef, global::System.String notificationTargetArn)
    {
        @selfRef.NotificationTargetArn = notificationTargetArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs WithRoleArn(this global::Pulumi.AwsNative.AutoScaling.Inputs.AutoScalingGroupLifecycleHookSpecificationArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

}
