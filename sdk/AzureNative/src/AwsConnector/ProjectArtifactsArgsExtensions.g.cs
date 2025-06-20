// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class ProjectArtifactsArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithArtifactIdentifier(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, global::System.String artifactIdentifier)
    {
        @selfRef.ArtifactIdentifier = artifactIdentifier;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithBucketOwnerAccess(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.BucketOwnerAccessEnumValueArgs bucketOwnerAccess)
    {
        @selfRef.BucketOwnerAccess = bucketOwnerAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithBucketOwnerAccess(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.BucketOwnerAccessEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.BucketOwnerAccessEnumValueArgs();
        @configure(@item);
        @selfRef.BucketOwnerAccess = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithEncryptionDisabled(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, bool encryptionDisabled = true)
    {
        @selfRef.EncryptionDisabled = encryptionDisabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithLocation(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithName(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithNamespaceType(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ArtifactNamespaceEnumValueArgs namespaceType)
    {
        @selfRef.NamespaceType = namespaceType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithNamespaceType(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ArtifactNamespaceEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ArtifactNamespaceEnumValueArgs();
        @configure(@item);
        @selfRef.NamespaceType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithOverrideArtifactName(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, bool overrideArtifactName = true)
    {
        @selfRef.OverrideArtifactName = overrideArtifactName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithPackaging(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ArtifactPackagingEnumValueArgs packaging)
    {
        @selfRef.Packaging = packaging;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithPackaging(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ArtifactPackagingEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ArtifactPackagingEnumValueArgs();
        @configure(@item);
        @selfRef.Packaging = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithPath(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, global::System.String path)
    {
        @selfRef.Path = path;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithType(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ArtifactsTypeEnumValueArgs type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs WithType(this global::Pulumi.AzureNative.AwsConnector.Inputs.ProjectArtifactsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ArtifactsTypeEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ArtifactsTypeEnumValueArgs();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
