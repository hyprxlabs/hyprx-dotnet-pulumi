// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Media.Inputs;

namespace Pulumi.AzureNative.Media;

public static partial class DefaultKeyArgsExtensions
{
    public static global::Pulumi.AzureNative.Media.Inputs.DefaultKeyArgs WithLabel(this global::Pulumi.AzureNative.Media.Inputs.DefaultKeyArgs @selfRef, global::System.String label)
    {
        @selfRef.Label = label;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Media.Inputs.DefaultKeyArgs WithPolicyName(this global::Pulumi.AzureNative.Media.Inputs.DefaultKeyArgs @selfRef, global::System.String policyName)
    {
        @selfRef.PolicyName = policyName;
        return @selfRef;
    }

}
