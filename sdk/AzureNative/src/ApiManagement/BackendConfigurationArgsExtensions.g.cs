// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ApiManagement.Inputs;

namespace Pulumi.AzureNative.ApiManagement;

public static partial class BackendConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.ApiManagement.Inputs.BackendConfigurationArgs WithSubnet(this global::Pulumi.AzureNative.ApiManagement.Inputs.BackendConfigurationArgs @selfRef, global::Pulumi.AzureNative.ApiManagement.Inputs.BackendSubnetConfigurationArgs subnet)
    {
        @selfRef.Subnet = subnet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.Inputs.BackendConfigurationArgs WithSubnet(this global::Pulumi.AzureNative.ApiManagement.Inputs.BackendConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ApiManagement.Inputs.BackendSubnetConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ApiManagement.Inputs.BackendSubnetConfigurationArgs();
        @configure(@item);
        @selfRef.Subnet = @item;
        return @selfRef;
    }

}
