// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.EdgeOrder.Inputs;

namespace Pulumi.AzureNative.EdgeOrder;

public static partial class TermCommitmentPreferencesArgsExtensions
{
    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.TermCommitmentPreferencesArgs WithPreferredTermCommitmentDuration(this global::Pulumi.AzureNative.EdgeOrder.Inputs.TermCommitmentPreferencesArgs @selfRef, global::System.String preferredTermCommitmentDuration)
    {
        @selfRef.PreferredTermCommitmentDuration = preferredTermCommitmentDuration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.EdgeOrder.Inputs.TermCommitmentPreferencesArgs WithPreferredTermCommitmentType(this global::Pulumi.AzureNative.EdgeOrder.Inputs.TermCommitmentPreferencesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.EdgeOrder.TermCommitmentType> preferredTermCommitmentType)
    {
        @selfRef.PreferredTermCommitmentType = preferredTermCommitmentType;
        return @selfRef;
    }

}
