// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Rum.Inputs;

namespace Pulumi.AwsNative.Rum;

public static partial class AppMonitorResourcePolicyArgsExtensions
{
    public static global::Pulumi.AwsNative.Rum.Inputs.AppMonitorResourcePolicyArgs WithPolicyDocument(this global::Pulumi.AwsNative.Rum.Inputs.AppMonitorResourcePolicyArgs @selfRef, global::System.String policyDocument)
    {
        @selfRef.PolicyDocument = policyDocument;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rum.Inputs.AppMonitorResourcePolicyArgs WithPolicyRevisionId(this global::Pulumi.AwsNative.Rum.Inputs.AppMonitorResourcePolicyArgs @selfRef, global::System.String policyRevisionId)
    {
        @selfRef.PolicyRevisionId = policyRevisionId;
        return @selfRef;
    }

}
