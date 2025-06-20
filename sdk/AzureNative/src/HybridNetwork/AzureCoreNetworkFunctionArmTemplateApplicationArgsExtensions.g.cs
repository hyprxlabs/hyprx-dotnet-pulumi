// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridNetwork.Inputs;

namespace Pulumi.AzureNative.HybridNetwork;

public static partial class AzureCoreNetworkFunctionArmTemplateApplicationArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs WithArtifactProfile(this global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs @selfRef, global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreArmTemplateArtifactProfileArgs artifactProfile)
    {
        @selfRef.ArtifactProfile = artifactProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs WithArtifactProfile(this global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreArmTemplateArtifactProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreArmTemplateArtifactProfileArgs();
        @configure(@item);
        @selfRef.ArtifactProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs WithArtifactType(this global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs @selfRef, global::System.String artifactType)
    {
        @selfRef.ArtifactType = artifactType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs WithDependsOnProfile(this global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs @selfRef, global::Pulumi.AzureNative.HybridNetwork.Inputs.DependsOnProfileArgs dependsOnProfile)
    {
        @selfRef.DependsOnProfile = dependsOnProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs WithDependsOnProfile(this global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridNetwork.Inputs.DependsOnProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridNetwork.Inputs.DependsOnProfileArgs();
        @configure(@item);
        @selfRef.DependsOnProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs WithDeployParametersMappingRuleProfile(this global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs @selfRef, global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreArmTemplateDeployMappingRuleProfileArgs deployParametersMappingRuleProfile)
    {
        @selfRef.DeployParametersMappingRuleProfile = deployParametersMappingRuleProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs WithDeployParametersMappingRuleProfile(this global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreArmTemplateDeployMappingRuleProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreArmTemplateDeployMappingRuleProfileArgs();
        @configure(@item);
        @selfRef.DeployParametersMappingRuleProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs WithName(this global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureCoreNetworkFunctionArmTemplateApplicationArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
