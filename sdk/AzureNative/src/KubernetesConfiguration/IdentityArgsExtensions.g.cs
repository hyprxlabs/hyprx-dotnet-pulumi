// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.KubernetesConfiguration.Inputs;

namespace Pulumi.AzureNative.KubernetesConfiguration;

public static partial class IdentityArgsExtensions
{
    public static global::Pulumi.AzureNative.KubernetesConfiguration.Inputs.IdentityArgs WithType(this global::Pulumi.AzureNative.KubernetesConfiguration.Inputs.IdentityArgs @selfRef, global::Pulumi.AzureNative.KubernetesConfiguration.ResourceIdentityType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KubernetesConfiguration.Inputs.IdentityArgs WithType(this global::Pulumi.AzureNative.KubernetesConfiguration.Inputs.IdentityArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.KubernetesConfiguration.ResourceIdentityType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AzureNative.KubernetesConfiguration.ResourceIdentityType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
