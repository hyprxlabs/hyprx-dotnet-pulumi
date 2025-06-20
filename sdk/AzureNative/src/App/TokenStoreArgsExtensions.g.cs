// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.App.Inputs;

namespace Pulumi.AzureNative.App;

public static partial class TokenStoreArgsExtensions
{
    public static global::Pulumi.AzureNative.App.Inputs.TokenStoreArgs WithAzureBlobStorage(this global::Pulumi.AzureNative.App.Inputs.TokenStoreArgs @selfRef, global::Pulumi.AzureNative.App.Inputs.BlobStorageTokenStoreArgs azureBlobStorage)
    {
        @selfRef.AzureBlobStorage = azureBlobStorage;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TokenStoreArgs WithAzureBlobStorage(this global::Pulumi.AzureNative.App.Inputs.TokenStoreArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.App.Inputs.BlobStorageTokenStoreArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.App.Inputs.BlobStorageTokenStoreArgs();
        @configure(@item);
        @selfRef.AzureBlobStorage = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TokenStoreArgs WithEnabled(this global::Pulumi.AzureNative.App.Inputs.TokenStoreArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.App.Inputs.TokenStoreArgs WithTokenRefreshExtensionHours(this global::Pulumi.AzureNative.App.Inputs.TokenStoreArgs @selfRef, global::System.Double tokenRefreshExtensionHours)
    {
        @selfRef.TokenRefreshExtensionHours = tokenRefreshExtensionHours;
        return @selfRef;
    }

}
