// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridNetwork.Inputs;

namespace Pulumi.AzureNative.HybridNetwork;

public static partial class VhdImageArtifactProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.VhdImageArtifactProfileArgs WithVhdName(this global::Pulumi.AzureNative.HybridNetwork.Inputs.VhdImageArtifactProfileArgs @selfRef, global::System.String vhdName)
    {
        @selfRef.VhdName = vhdName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.VhdImageArtifactProfileArgs WithVhdVersion(this global::Pulumi.AzureNative.HybridNetwork.Inputs.VhdImageArtifactProfileArgs @selfRef, global::System.String vhdVersion)
    {
        @selfRef.VhdVersion = vhdVersion;
        return @selfRef;
    }

}
