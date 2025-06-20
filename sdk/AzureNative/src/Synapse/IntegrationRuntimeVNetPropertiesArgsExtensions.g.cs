// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Synapse.Inputs;

namespace Pulumi.AzureNative.Synapse;

public static partial class IntegrationRuntimeVNetPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeVNetPropertiesArgs WithPublicIPs(this global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeVNetPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> publicIPs)
    {
        @selfRef.PublicIPs = publicIPs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeVNetPropertiesArgs WithPublicIPs(this global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeVNetPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.PublicIPs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeVNetPropertiesArgs WithPublicIPs(this global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeVNetPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.PublicIPs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeVNetPropertiesArgs WithSubnet(this global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeVNetPropertiesArgs @selfRef, global::System.String subnet)
    {
        @selfRef.Subnet = subnet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeVNetPropertiesArgs WithSubnetId(this global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeVNetPropertiesArgs @selfRef, global::System.String subnetId)
    {
        @selfRef.SubnetId = subnetId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeVNetPropertiesArgs WithVNetId(this global::Pulumi.AzureNative.Synapse.Inputs.IntegrationRuntimeVNetPropertiesArgs @selfRef, global::System.String vNetId)
    {
        @selfRef.VNetId = vNetId;
        return @selfRef;
    }

}
