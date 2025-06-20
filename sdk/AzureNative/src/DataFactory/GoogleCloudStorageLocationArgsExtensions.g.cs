// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class GoogleCloudStorageLocationArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs WithBucketName(this global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs @selfRef, global::System.Object bucketName)
    {
        @selfRef.BucketName = bucketName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs WithBucketName(this global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.BucketName = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs WithFileName(this global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs @selfRef, global::System.Object fileName)
    {
        @selfRef.FileName = fileName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs WithFileName(this global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.FileName = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs WithFolderPath(this global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs @selfRef, global::System.Object folderPath)
    {
        @selfRef.FolderPath = folderPath;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs WithFolderPath(this global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.FolderPath = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs WithVersion(this global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs @selfRef, global::System.Object version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs WithVersion(this global::Pulumi.AzureNative.DataFactory.Inputs.GoogleCloudStorageLocationArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Version = @item;
        return @selfRef;
    }

}
