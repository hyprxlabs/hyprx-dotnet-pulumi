// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.GreengrassV2.Inputs;

namespace Pulumi.AwsNative.GreengrassV2;

public static partial class DeploymentIoTJobTimeoutConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.GreengrassV2.Inputs.DeploymentIoTJobTimeoutConfigArgs WithInProgressTimeoutInMinutes(this global::Pulumi.AwsNative.GreengrassV2.Inputs.DeploymentIoTJobTimeoutConfigArgs @selfRef, global::System.Int32 inProgressTimeoutInMinutes)
    {
        @selfRef.InProgressTimeoutInMinutes = inProgressTimeoutInMinutes;
        return @selfRef;
    }

}
