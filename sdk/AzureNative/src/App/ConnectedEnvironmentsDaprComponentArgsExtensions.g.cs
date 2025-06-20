// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.App;

public static partial class ConnectedEnvironmentsDaprComponentArgsExtensions
{
    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithComponentName(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.String componentName)
    {
        @selfRef.ComponentName = componentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithComponentType(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.String componentType)
    {
        @selfRef.ComponentType = componentType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithConnectedEnvironmentName(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.String connectedEnvironmentName)
    {
        @selfRef.ConnectedEnvironmentName = connectedEnvironmentName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithIgnoreErrors(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, bool ignoreErrors = true)
    {
        @selfRef.IgnoreErrors = ignoreErrors;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithInitTimeout(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.String initTimeout)
    {
        @selfRef.InitTimeout = initTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithMetadata(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.DaprMetadataArgs> metadata)
    {
        @selfRef.Metadata = metadata;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithMetadata(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.DaprMetadataArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.DaprMetadataArgs>();
        @configure(@list);
        @selfRef.Metadata = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithMetadata(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.App.Inputs.DaprMetadataArgs>> @create)
    {
        @selfRef.Metadata = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithResourceGroupName(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithScopes(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.Collections.Generic.List<global::System.String> scopes)
    {
        @selfRef.Scopes = scopes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithScopes(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Scopes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithScopes(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Scopes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithSecretStoreComponent(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.String secretStoreComponent)
    {
        @selfRef.SecretStoreComponent = secretStoreComponent;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithSecrets(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.SecretArgs> secrets)
    {
        @selfRef.Secrets = secrets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithSecrets(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.SecretArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.App.Inputs.SecretArgs>();
        @configure(@list);
        @selfRef.Secrets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithSecrets(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.App.Inputs.SecretArgs>> @create)
    {
        @selfRef.Secrets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs WithVersion(this global::Pulumi.AzureNative.App.ConnectedEnvironmentsDaprComponentArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
