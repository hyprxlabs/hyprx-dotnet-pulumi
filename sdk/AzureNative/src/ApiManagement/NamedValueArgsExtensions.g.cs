// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.ApiManagement;

public static partial class NamedValueArgsExtensions
{
    public static global::Pulumi.AzureNative.ApiManagement.NamedValueArgs WithDisplayName(this global::Pulumi.AzureNative.ApiManagement.NamedValueArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.NamedValueArgs WithKeyVault(this global::Pulumi.AzureNative.ApiManagement.NamedValueArgs @selfRef, global::Pulumi.AzureNative.ApiManagement.Inputs.KeyVaultContractCreatePropertiesArgs keyVault)
    {
        @selfRef.KeyVault = keyVault;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.NamedValueArgs WithKeyVault(this global::Pulumi.AzureNative.ApiManagement.NamedValueArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.ApiManagement.Inputs.KeyVaultContractCreatePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.ApiManagement.Inputs.KeyVaultContractCreatePropertiesArgs();
        @configure(@item);
        @selfRef.KeyVault = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.NamedValueArgs WithNamedValueId(this global::Pulumi.AzureNative.ApiManagement.NamedValueArgs @selfRef, global::System.String namedValueId)
    {
        @selfRef.NamedValueId = namedValueId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.NamedValueArgs WithResourceGroupName(this global::Pulumi.AzureNative.ApiManagement.NamedValueArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.NamedValueArgs WithSecret(this global::Pulumi.AzureNative.ApiManagement.NamedValueArgs @selfRef, bool secret = true)
    {
        @selfRef.Secret = secret;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.NamedValueArgs WithServiceName(this global::Pulumi.AzureNative.ApiManagement.NamedValueArgs @selfRef, global::System.String serviceName)
    {
        @selfRef.ServiceName = serviceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.NamedValueArgs WithTags(this global::Pulumi.AzureNative.ApiManagement.NamedValueArgs @selfRef, global::System.Collections.Generic.List<global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.NamedValueArgs WithTags(this global::Pulumi.AzureNative.ApiManagement.NamedValueArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.NamedValueArgs WithTags(this global::Pulumi.AzureNative.ApiManagement.NamedValueArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ApiManagement.NamedValueArgs WithValue(this global::Pulumi.AzureNative.ApiManagement.NamedValueArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
