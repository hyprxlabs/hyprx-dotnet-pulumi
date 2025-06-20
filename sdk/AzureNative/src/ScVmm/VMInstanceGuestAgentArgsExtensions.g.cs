// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ScVmm;

public static partial class VMInstanceGuestAgentArgsExtensions
{
    public static global::Pulumi.AzureNative.ScVmm.VMInstanceGuestAgentArgs WithCredentials(this global::Pulumi.AzureNative.ScVmm.VMInstanceGuestAgentArgs @selfRef, global::Pulumi.AzureNative.ScVmm.Inputs.GuestCredentialArgs credentials)
    {
        @selfRef.Credentials = credentials;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ScVmm.VMInstanceGuestAgentArgs WithCredentials(this global::Pulumi.AzureNative.ScVmm.VMInstanceGuestAgentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ScVmm.Inputs.GuestCredentialArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ScVmm.Inputs.GuestCredentialArgs();
        @configure(@item);
        @selfRef.Credentials = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ScVmm.VMInstanceGuestAgentArgs WithHttpProxyConfig(this global::Pulumi.AzureNative.ScVmm.VMInstanceGuestAgentArgs @selfRef, global::Pulumi.AzureNative.ScVmm.Inputs.HttpProxyConfigurationArgs httpProxyConfig)
    {
        @selfRef.HttpProxyConfig = httpProxyConfig;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ScVmm.VMInstanceGuestAgentArgs WithHttpProxyConfig(this global::Pulumi.AzureNative.ScVmm.VMInstanceGuestAgentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ScVmm.Inputs.HttpProxyConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ScVmm.Inputs.HttpProxyConfigurationArgs();
        @configure(@item);
        @selfRef.HttpProxyConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ScVmm.VMInstanceGuestAgentArgs WithProvisioningAction(this global::Pulumi.AzureNative.ScVmm.VMInstanceGuestAgentArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ScVmm.ProvisioningAction> provisioningAction)
    {
        @selfRef.ProvisioningAction = provisioningAction;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ScVmm.VMInstanceGuestAgentArgs WithResourceUri(this global::Pulumi.AzureNative.ScVmm.VMInstanceGuestAgentArgs @selfRef, global::System.String resourceUri)
    {
        @selfRef.ResourceUri = resourceUri;
        return @selfRef;
    }

}
