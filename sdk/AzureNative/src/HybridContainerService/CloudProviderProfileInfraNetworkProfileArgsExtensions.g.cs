// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HybridContainerService.Inputs;

namespace Pulumi.AzureNative.HybridContainerService;

public static partial class CloudProviderProfileInfraNetworkProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.CloudProviderProfileInfraNetworkProfileArgs WithVnetSubnetIds(this global::Pulumi.AzureNative.HybridContainerService.Inputs.CloudProviderProfileInfraNetworkProfileArgs @selfRef, global::System.Collections.Generic.List<global::System.String> vnetSubnetIds)
    {
        @selfRef.VnetSubnetIds = vnetSubnetIds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.CloudProviderProfileInfraNetworkProfileArgs WithVnetSubnetIds(this global::Pulumi.AzureNative.HybridContainerService.Inputs.CloudProviderProfileInfraNetworkProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.VnetSubnetIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HybridContainerService.Inputs.CloudProviderProfileInfraNetworkProfileArgs WithVnetSubnetIds(this global::Pulumi.AzureNative.HybridContainerService.Inputs.CloudProviderProfileInfraNetworkProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.VnetSubnetIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
