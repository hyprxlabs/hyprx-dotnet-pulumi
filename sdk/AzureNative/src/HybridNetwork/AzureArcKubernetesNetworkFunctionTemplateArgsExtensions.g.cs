// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridNetwork.Inputs;

namespace Pulumi.AzureNative.HybridNetwork;

public static partial class AzureArcKubernetesNetworkFunctionTemplateArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureArcKubernetesNetworkFunctionTemplateArgs WithNetworkFunctionApplications(this global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureArcKubernetesNetworkFunctionTemplateArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureArcKubernetesHelmApplicationArgs> networkFunctionApplications)
    {
        @selfRef.NetworkFunctionApplications = networkFunctionApplications;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureArcKubernetesNetworkFunctionTemplateArgs WithNetworkFunctionApplications(this global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureArcKubernetesNetworkFunctionTemplateArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureArcKubernetesHelmApplicationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureArcKubernetesHelmApplicationArgs>();
        @configure(@list);
        @selfRef.NetworkFunctionApplications = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureArcKubernetesNetworkFunctionTemplateArgs WithNetworkFunctionApplications(this global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureArcKubernetesNetworkFunctionTemplateArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureArcKubernetesHelmApplicationArgs>> @create)
    {
        @selfRef.NetworkFunctionApplications = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureArcKubernetesNetworkFunctionTemplateArgs WithNfviType(this global::Pulumi.AzureNative.HybridNetwork.Inputs.AzureArcKubernetesNetworkFunctionTemplateArgs @selfRef, global::System.String nfviType)
    {
        @selfRef.NfviType = nfviType;
        return @selfRef;
    }

}
