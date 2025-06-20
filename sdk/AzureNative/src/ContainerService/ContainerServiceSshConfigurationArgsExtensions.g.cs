// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerService.Inputs;

namespace Pulumi.AzureNative.ContainerService;

public static partial class ContainerServiceSshConfigurationArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerService.Inputs.ContainerServiceSshConfigurationArgs WithPublicKeys(this global::Pulumi.AzureNative.ContainerService.Inputs.ContainerServiceSshConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.ContainerServiceSshPublicKeyArgs> publicKeys)
    {
        @selfRef.PublicKeys = publicKeys;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ContainerServiceSshConfigurationArgs WithPublicKeys(this global::Pulumi.AzureNative.ContainerService.Inputs.ContainerServiceSshConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.ContainerServiceSshPublicKeyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ContainerService.Inputs.ContainerServiceSshPublicKeyArgs>();
        @configure(@list);
        @selfRef.PublicKeys = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerService.Inputs.ContainerServiceSshConfigurationArgs WithPublicKeys(this global::Pulumi.AzureNative.ContainerService.Inputs.ContainerServiceSshConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ContainerService.Inputs.ContainerServiceSshPublicKeyArgs>> @create)
    {
        @selfRef.PublicKeys = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
