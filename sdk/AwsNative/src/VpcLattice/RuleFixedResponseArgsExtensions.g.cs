// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.VpcLattice.Inputs;

namespace Pulumi.AwsNative.VpcLattice;

public static partial class RuleFixedResponseArgsExtensions
{
    public static global::Pulumi.AwsNative.VpcLattice.Inputs.RuleFixedResponseArgs WithStatusCode(this global::Pulumi.AwsNative.VpcLattice.Inputs.RuleFixedResponseArgs @selfRef, global::System.Int32 statusCode)
    {
        @selfRef.StatusCode = statusCode;
        return @selfRef;
    }

}
