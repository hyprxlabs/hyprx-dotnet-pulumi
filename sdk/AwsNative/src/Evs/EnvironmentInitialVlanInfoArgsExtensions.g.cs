// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Evs.Inputs;

namespace Pulumi.AwsNative.Evs;

public static partial class EnvironmentInitialVlanInfoArgsExtensions
{
    public static global::Pulumi.AwsNative.Evs.Inputs.EnvironmentInitialVlanInfoArgs WithCidr(this global::Pulumi.AwsNative.Evs.Inputs.EnvironmentInitialVlanInfoArgs @selfRef, global::System.String cidr)
    {
        @selfRef.Cidr = cidr;
        return @selfRef;
    }

}
