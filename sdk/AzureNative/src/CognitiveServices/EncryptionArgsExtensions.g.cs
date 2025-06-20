// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.CognitiveServices.Inputs;

namespace Pulumi.AzureNative.CognitiveServices;

public static partial class EncryptionArgsExtensions
{
    public static global::Pulumi.AzureNative.CognitiveServices.Inputs.EncryptionArgs WithKeySource(this global::Pulumi.AzureNative.CognitiveServices.Inputs.EncryptionArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.CognitiveServices.KeySource> keySource)
    {
        @selfRef.KeySource = keySource;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.Inputs.EncryptionArgs WithKeyVaultProperties(this global::Pulumi.AzureNative.CognitiveServices.Inputs.EncryptionArgs @selfRef, global::Pulumi.AzureNative.CognitiveServices.Inputs.KeyVaultPropertiesArgs keyVaultProperties)
    {
        @selfRef.KeyVaultProperties = keyVaultProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.CognitiveServices.Inputs.EncryptionArgs WithKeyVaultProperties(this global::Pulumi.AzureNative.CognitiveServices.Inputs.EncryptionArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.CognitiveServices.Inputs.KeyVaultPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.CognitiveServices.Inputs.KeyVaultPropertiesArgs();
        @configure(@item);
        @selfRef.KeyVaultProperties = @item;
        return @selfRef;
    }

}
