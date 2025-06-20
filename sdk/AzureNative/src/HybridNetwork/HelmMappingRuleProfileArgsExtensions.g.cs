// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridNetwork.Inputs;

namespace Pulumi.AzureNative.HybridNetwork;

public static partial class HelmMappingRuleProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileArgs WithHelmPackageVersion(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileArgs @selfRef, global::System.String helmPackageVersion)
    {
        @selfRef.HelmPackageVersion = helmPackageVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileArgs WithOptions(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileArgs @selfRef, global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileOptionsArgs options)
    {
        @selfRef.Options = options;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileArgs WithOptions(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileOptionsArgs();
        @configure(@item);
        @selfRef.Options = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileArgs WithReleaseName(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileArgs @selfRef, global::System.String releaseName)
    {
        @selfRef.ReleaseName = releaseName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileArgs WithReleaseNamespace(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileArgs @selfRef, global::System.String releaseNamespace)
    {
        @selfRef.ReleaseNamespace = releaseNamespace;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileArgs WithValues(this global::Pulumi.AzureNative.HybridNetwork.Inputs.HelmMappingRuleProfileArgs @selfRef, global::System.String values)
    {
        @selfRef.Values = values;
        return @selfRef;
    }

}
