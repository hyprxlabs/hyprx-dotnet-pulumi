// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.CloudFormation.Inputs;

namespace Pulumi.AwsNative.CloudFormation;

public static partial class TypeActivationLoggingConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.CloudFormation.Inputs.TypeActivationLoggingConfigArgs WithLogGroupName(this global::Pulumi.AwsNative.CloudFormation.Inputs.TypeActivationLoggingConfigArgs @selfRef, global::System.String logGroupName)
    {
        @selfRef.LogGroupName = logGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudFormation.Inputs.TypeActivationLoggingConfigArgs WithLogRoleArn(this global::Pulumi.AwsNative.CloudFormation.Inputs.TypeActivationLoggingConfigArgs @selfRef, global::System.String logRoleArn)
    {
        @selfRef.LogRoleArn = logRoleArn;
        return @selfRef;
    }

}
