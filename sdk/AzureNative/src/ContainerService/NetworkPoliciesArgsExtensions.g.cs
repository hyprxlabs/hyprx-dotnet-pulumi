// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class NetworkPoliciesArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.NetworkPoliciesArgs WithEgress(this global::Pulumi.AzureNative.ContainerService.Inputs.NetworkPoliciesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ContainerService.PolicyRule> egress)
    {
        @selfRef.Egress = egress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.NetworkPoliciesArgs WithIngress(this global::Pulumi.AzureNative.ContainerService.Inputs.NetworkPoliciesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ContainerService.PolicyRule> ingress)
    {
        @selfRef.Ingress = ingress;
        return @selfRef;
    }

}
