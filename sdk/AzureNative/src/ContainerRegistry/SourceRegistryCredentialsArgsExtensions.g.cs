// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ContainerRegistry.Inputs;

namespace Pulumi.AzureNative.ContainerRegistry;

public static partial class SourceRegistryCredentialsArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerRegistry.Inputs.SourceRegistryCredentialsArgs WithLoginMode(this global::Pulumi.AzureNative.ContainerRegistry.Inputs.SourceRegistryCredentialsArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ContainerRegistry.SourceRegistryLoginMode> loginMode)
    {
        @selfRef.LoginMode = loginMode;
        return @selfRef;
    }

}
