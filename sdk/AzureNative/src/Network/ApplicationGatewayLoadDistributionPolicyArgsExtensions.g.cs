// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Network.Inputs;

namespace Pulumi.AzureNative.Network;

public static partial class ApplicationGatewayLoadDistributionPolicyArgsExtensions
{
    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionPolicyArgs WithId(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionPolicyArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionPolicyArgs WithLoadDistributionAlgorithm(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionPolicyArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Network.ApplicationGatewayLoadDistributionAlgorithm> loadDistributionAlgorithm)
    {
        @selfRef.LoadDistributionAlgorithm = loadDistributionAlgorithm;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionPolicyArgs WithLoadDistributionTargets(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionPolicyArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionTargetArgs> loadDistributionTargets)
    {
        @selfRef.LoadDistributionTargets = loadDistributionTargets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionPolicyArgs WithLoadDistributionTargets(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionPolicyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionTargetArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionTargetArgs>();
        @configure(@list);
        @selfRef.LoadDistributionTargets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionPolicyArgs WithLoadDistributionTargets(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionPolicyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionTargetArgs>> @create)
    {
        @selfRef.LoadDistributionTargets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionPolicyArgs WithName(this global::Pulumi.AzureNative.Network.Inputs.ApplicationGatewayLoadDistributionPolicyArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

}
