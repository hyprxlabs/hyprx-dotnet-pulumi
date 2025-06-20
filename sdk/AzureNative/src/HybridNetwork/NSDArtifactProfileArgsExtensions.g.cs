// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridNetwork.Inputs;

namespace Pulumi.AzureNative.HybridNetwork;

public static partial class NSDArtifactProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.NSDArtifactProfileArgs WithArtifactName(this global::Pulumi.AzureNative.HybridNetwork.Inputs.NSDArtifactProfileArgs @selfRef, global::System.String artifactName)
    {
        @selfRef.ArtifactName = artifactName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.NSDArtifactProfileArgs WithArtifactStoreReference(this global::Pulumi.AzureNative.HybridNetwork.Inputs.NSDArtifactProfileArgs @selfRef, global::Pulumi.AzureNative.HybridNetwork.Inputs.ReferencedResourceArgs artifactStoreReference)
    {
        @selfRef.ArtifactStoreReference = artifactStoreReference;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.NSDArtifactProfileArgs WithArtifactStoreReference(this global::Pulumi.AzureNative.HybridNetwork.Inputs.NSDArtifactProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridNetwork.Inputs.ReferencedResourceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridNetwork.Inputs.ReferencedResourceArgs();
        @configure(@item);
        @selfRef.ArtifactStoreReference = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.NSDArtifactProfileArgs WithArtifactVersion(this global::Pulumi.AzureNative.HybridNetwork.Inputs.NSDArtifactProfileArgs @selfRef, global::System.String artifactVersion)
    {
        @selfRef.ArtifactVersion = artifactVersion;
        return @selfRef;
    }

}
