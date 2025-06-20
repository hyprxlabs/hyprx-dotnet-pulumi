// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Web.Inputs;

namespace Pulumi.AzureNative.Web;

public static partial class TokenStoreArgsExtensions
{
    public static global::Pulumi.AzureNative.Web.Inputs.TokenStoreArgs WithAzureBlobStorage(this global::Pulumi.AzureNative.Web.Inputs.TokenStoreArgs @selfRef, global::Pulumi.AzureNative.Web.Inputs.BlobStorageTokenStoreArgs azureBlobStorage)
    {
        @selfRef.AzureBlobStorage = azureBlobStorage;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.TokenStoreArgs WithAzureBlobStorage(this global::Pulumi.AzureNative.Web.Inputs.TokenStoreArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.Inputs.BlobStorageTokenStoreArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Web.Inputs.BlobStorageTokenStoreArgs();
        @configure(@item);
        @selfRef.AzureBlobStorage = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.TokenStoreArgs WithEnabled(this global::Pulumi.AzureNative.Web.Inputs.TokenStoreArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.TokenStoreArgs WithFileSystem(this global::Pulumi.AzureNative.Web.Inputs.TokenStoreArgs @selfRef, global::Pulumi.AzureNative.Web.Inputs.FileSystemTokenStoreArgs fileSystem)
    {
        @selfRef.FileSystem = fileSystem;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.TokenStoreArgs WithFileSystem(this global::Pulumi.AzureNative.Web.Inputs.TokenStoreArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Web.Inputs.FileSystemTokenStoreArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Web.Inputs.FileSystemTokenStoreArgs();
        @configure(@item);
        @selfRef.FileSystem = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Web.Inputs.TokenStoreArgs WithTokenRefreshExtensionHours(this global::Pulumi.AzureNative.Web.Inputs.TokenStoreArgs @selfRef, global::System.Double tokenRefreshExtensionHours)
    {
        @selfRef.TokenRefreshExtensionHours = tokenRefreshExtensionHours;
        return @selfRef;
    }

}
