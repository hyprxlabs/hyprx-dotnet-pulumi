// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.VerifiedPermissions.Inputs;

namespace Pulumi.AwsNative.VerifiedPermissions;

public static partial class PolicyStaticPolicyDefinitionArgsExtensions
{
    public static global::Pulumi.AwsNative.VerifiedPermissions.Inputs.PolicyStaticPolicyDefinitionArgs WithDescription(this global::Pulumi.AwsNative.VerifiedPermissions.Inputs.PolicyStaticPolicyDefinitionArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.VerifiedPermissions.Inputs.PolicyStaticPolicyDefinitionArgs WithStatement(this global::Pulumi.AwsNative.VerifiedPermissions.Inputs.PolicyStaticPolicyDefinitionArgs @selfRef, global::System.String statement)
    {
        @selfRef.Statement = statement;
        return @selfRef;
    }

}
