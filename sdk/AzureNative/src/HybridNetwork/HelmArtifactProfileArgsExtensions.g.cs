// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridNetwork.Inputs;

namespace Pulumi.AzureNative.HybridNetwork;

public static partial class HelmArtifactProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs WithHelmPackageName(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs @selfRef, global::System.String helmPackageName)
    {
        @selfRef.HelmPackageName = helmPackageName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs WithHelmPackageVersionRange(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs @selfRef, global::System.String helmPackageVersionRange)
    {
        @selfRef.HelmPackageVersionRange = helmPackageVersionRange;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs WithImagePullSecretsValuesPaths(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs @selfRef, global::System.Collections.Generic.List<global::System.String> imagePullSecretsValuesPaths)
    {
        @selfRef.ImagePullSecretsValuesPaths = imagePullSecretsValuesPaths;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs WithImagePullSecretsValuesPaths(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ImagePullSecretsValuesPaths = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs WithImagePullSecretsValuesPaths(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ImagePullSecretsValuesPaths = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs WithRegistryValuesPaths(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs @selfRef, global::System.Collections.Generic.List<global::System.String> registryValuesPaths)
    {
        @selfRef.RegistryValuesPaths = registryValuesPaths;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs WithRegistryValuesPaths(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.RegistryValuesPaths = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs WithRegistryValuesPaths(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmArtifactProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.RegistryValuesPaths = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
