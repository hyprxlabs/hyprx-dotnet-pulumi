// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SecurityHub.Inputs;

namespace Pulumi.AwsNative.SecurityHub;

public static partial class StandardsControlArgsExtensions
{
    public static global::Pulumi.AwsNative.SecurityHub.Inputs.StandardsControlArgs WithReason(this global::Pulumi.AwsNative.SecurityHub.Inputs.StandardsControlArgs @selfRef, global::System.String reason)
    {
        @selfRef.Reason = reason;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SecurityHub.Inputs.StandardsControlArgs WithStandardsControlArn(this global::Pulumi.AwsNative.SecurityHub.Inputs.StandardsControlArgs @selfRef, global::System.String standardsControlArn)
    {
        @selfRef.StandardsControlArn = standardsControlArn;
        return @selfRef;
    }

}
