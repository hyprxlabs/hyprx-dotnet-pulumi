// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Iam.Inputs;

namespace Pulumi.AwsNative.Iam;

public static partial class RolePolicyArgsExtensions
{
    public static global::Pulumi.AwsNative.Iam.Inputs.RolePolicyArgs WithPolicyDocument(this global::Pulumi.AwsNative.Iam.Inputs.RolePolicyArgs @selfRef, global::System.Object policyDocument)
    {
        @selfRef.PolicyDocument = policyDocument;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.Inputs.RolePolicyArgs WithPolicyDocument(this global::Pulumi.AwsNative.Iam.Inputs.RolePolicyArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.PolicyDocument = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Iam.Inputs.RolePolicyArgs WithPolicyName(this global::Pulumi.AwsNative.Iam.Inputs.RolePolicyArgs @selfRef, global::System.String policyName)
    {
        @selfRef.PolicyName = policyName;
        return @selfRef;
    }

}
