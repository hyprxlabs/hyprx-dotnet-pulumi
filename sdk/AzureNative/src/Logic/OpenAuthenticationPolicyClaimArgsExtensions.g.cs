// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Logic.Inputs;

namespace Pulumi.AzureNative.Logic;

public static partial class OpenAuthenticationPolicyClaimArgsExtensions
{
    public static global::Pulumi.AzureNative.Logic.Inputs.OpenAuthenticationPolicyClaimArgs WithName(this global::Pulumi.AzureNative.Logic.Inputs.OpenAuthenticationPolicyClaimArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.Inputs.OpenAuthenticationPolicyClaimArgs WithValue(this global::Pulumi.AzureNative.Logic.Inputs.OpenAuthenticationPolicyClaimArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
