// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Security.Inputs;

namespace Pulumi.AzureNative.Security;

public static partial class DefenderForServersGcpOfferingMdeAutoProvisioningArgsExtensions
{
    public static global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingMdeAutoProvisioningArgs WithConfiguration(this global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingMdeAutoProvisioningArgs @selfRef, global::System.Object configuration)
    {
        @selfRef.Configuration = configuration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingMdeAutoProvisioningArgs WithConfiguration(this global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingMdeAutoProvisioningArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Configuration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingMdeAutoProvisioningArgs WithEnabled(this global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingMdeAutoProvisioningArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

}
