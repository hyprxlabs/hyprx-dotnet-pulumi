// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Migrate.Inputs;

namespace Pulumi.AzureNative.Migrate;

public static partial class AKSDeploymentSpecificationArgsExtensions
{
    public static global::Pulumi.AzureNative.Migrate.Inputs.AKSDeploymentSpecificationArgs WithKubernetesObjectsYaml(this global::Pulumi.AzureNative.Migrate.Inputs.AKSDeploymentSpecificationArgs @selfRef, global::System.String kubernetesObjectsYaml)
    {
        @selfRef.KubernetesObjectsYaml = kubernetesObjectsYaml;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.AKSDeploymentSpecificationArgs WithLoadBalancerType(this global::Pulumi.AzureNative.Migrate.Inputs.AKSDeploymentSpecificationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Migrate.LoadBalancerType> loadBalancerType)
    {
        @selfRef.LoadBalancerType = loadBalancerType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Migrate.Inputs.AKSDeploymentSpecificationArgs WithReplicaCount(this global::Pulumi.AzureNative.Migrate.Inputs.AKSDeploymentSpecificationArgs @selfRef, global::System.String replicaCount)
    {
        @selfRef.ReplicaCount = replicaCount;
        return @selfRef;
    }

}
