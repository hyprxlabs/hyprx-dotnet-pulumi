// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ContainerRegistry;

public static partial class TokenArgsExtensions
{
    public static global::Pulumi.AzureNative.ContainerRegistry.TokenArgs WithCredentials(this global::Pulumi.AzureNative.ContainerRegistry.TokenArgs @selfRef, global::Pulumi.AzureNative.ContainerRegistry.Inputs.TokenCredentialsPropertiesArgs credentials)
    {
        @selfRef.Credentials = credentials;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.TokenArgs WithCredentials(this global::Pulumi.AzureNative.ContainerRegistry.TokenArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ContainerRegistry.Inputs.TokenCredentialsPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ContainerRegistry.Inputs.TokenCredentialsPropertiesArgs();
        @configure(@item);
        @selfRef.Credentials = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.TokenArgs WithRegistryName(this global::Pulumi.AzureNative.ContainerRegistry.TokenArgs @selfRef, global::System.String registryName)
    {
        @selfRef.RegistryName = registryName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.TokenArgs WithResourceGroupName(this global::Pulumi.AzureNative.ContainerRegistry.TokenArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.TokenArgs WithScopeMapId(this global::Pulumi.AzureNative.ContainerRegistry.TokenArgs @selfRef, global::System.String scopeMapId)
    {
        @selfRef.ScopeMapId = scopeMapId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.TokenArgs WithStatus(this global::Pulumi.AzureNative.ContainerRegistry.TokenArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ContainerRegistry.TokenStatus> status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ContainerRegistry.TokenArgs WithTokenName(this global::Pulumi.AzureNative.ContainerRegistry.TokenArgs @selfRef, global::System.String tokenName)
    {
        @selfRef.TokenName = tokenName;
        return @selfRef;
    }

}
