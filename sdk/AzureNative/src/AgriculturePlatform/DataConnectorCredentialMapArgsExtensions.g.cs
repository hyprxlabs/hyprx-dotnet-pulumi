// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AgriculturePlatform.Inputs;

namespace Pulumi.AzureNative.AgriculturePlatform;

public static partial class DataConnectorCredentialMapArgsExtensions
{
    public static global::Pulumi.AzureNative.AgriculturePlatform.Inputs.DataConnectorCredentialMapArgs WithKey(this global::Pulumi.AzureNative.AgriculturePlatform.Inputs.DataConnectorCredentialMapArgs @selfRef, global::System.String key)
    {
        @selfRef.Key = key;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AgriculturePlatform.Inputs.DataConnectorCredentialMapArgs WithValue(this global::Pulumi.AzureNative.AgriculturePlatform.Inputs.DataConnectorCredentialMapArgs @selfRef, global::Pulumi.AzureNative.AgriculturePlatform.Inputs.DataConnectorCredentialsArgs value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AgriculturePlatform.Inputs.DataConnectorCredentialMapArgs WithValue(this global::Pulumi.AzureNative.AgriculturePlatform.Inputs.DataConnectorCredentialMapArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AgriculturePlatform.Inputs.DataConnectorCredentialsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AgriculturePlatform.Inputs.DataConnectorCredentialsArgs();
        @configure(@item);
        @selfRef.Value = @item;
        return @selfRef;
    }

}
