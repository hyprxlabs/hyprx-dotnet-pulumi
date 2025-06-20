// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.KeyVault;

public static partial class KeyArgsExtensions
{
    public static global::Pulumi.AzureNative.KeyVault.KeyArgs WithKeyName(this global::Pulumi.AzureNative.KeyVault.KeyArgs @selfRef, global::System.String keyName)
    {
        @selfRef.KeyName = keyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.KeyArgs WithProperties(this global::Pulumi.AzureNative.KeyVault.KeyArgs @selfRef, global::Pulumi.AzureNative.KeyVault.Inputs.KeyPropertiesArgs properties)
    {
        @selfRef.Properties = properties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.KeyArgs WithProperties(this global::Pulumi.AzureNative.KeyVault.KeyArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.KeyVault.Inputs.KeyPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.KeyVault.Inputs.KeyPropertiesArgs();
        @configure(@item);
        @selfRef.Properties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.KeyArgs WithResourceGroupName(this global::Pulumi.AzureNative.KeyVault.KeyArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.KeyArgs WithTags(this global::Pulumi.AzureNative.KeyVault.KeyArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.KeyArgs WithTags(this global::Pulumi.AzureNative.KeyVault.KeyArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.KeyArgs WithTags(this global::Pulumi.AzureNative.KeyVault.KeyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.KeyVault.KeyArgs WithVaultName(this global::Pulumi.AzureNative.KeyVault.KeyArgs @selfRef, global::System.String vaultName)
    {
        @selfRef.VaultName = vaultName;
        return @selfRef;
    }

}
