// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Security.Inputs;

namespace Pulumi.AzureNative.Security;

public static partial class DefenderForServersGcpOfferingVaAutoProvisioningArgsExtensions
{
    public static global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingVaAutoProvisioningArgs WithConfiguration(this global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingVaAutoProvisioningArgs @selfRef, global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingConfigurationArgs configuration)
    {
        @selfRef.Configuration = configuration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingVaAutoProvisioningArgs WithConfiguration(this global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingVaAutoProvisioningArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingConfigurationArgs();
        @configure(@item);
        @selfRef.Configuration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingVaAutoProvisioningArgs WithEnabled(this global::Pulumi.AzureNative.Security.Inputs.DefenderForServersGcpOfferingVaAutoProvisioningArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

}
