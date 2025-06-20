// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class AzureFileStorageLinkedServiceArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithAccountKey(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs accountKey)
    {
        @selfRef.AccountKey = accountKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithAccountKey(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs();
        @configure(@item);
        @selfRef.AccountKey = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> annotations)
    {
        @selfRef.Annotations = annotations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.Annotations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.Annotations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs connectVia)
    {
        @selfRef.ConnectVia = connectVia;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs();
        @configure(@item);
        @selfRef.ConnectVia = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithConnectionString(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Object connectionString)
    {
        @selfRef.ConnectionString = connectionString;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithConnectionString(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ConnectionString = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.CredentialReferenceArgs credential)
    {
        @selfRef.Credential = credential;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.CredentialReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.CredentialReferenceArgs();
        @configure(@item);
        @selfRef.Credential = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithEncryptedCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.String encryptedCredential)
    {
        @selfRef.EncryptedCredential = encryptedCredential;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithFileShare(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Object fileShare)
    {
        @selfRef.FileShare = fileShare;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithFileShare(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.FileShare = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithHost(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Object host)
    {
        @selfRef.Host = host;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithHost(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Host = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithPassword(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs, global::Pulumi.AzureNative.DataFactory.Inputs.SecureStringArgs> password)
    {
        @selfRef.Password = password;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithSasToken(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs sasToken)
    {
        @selfRef.SasToken = sasToken;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithSasToken(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs();
        @configure(@item);
        @selfRef.SasToken = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithSasUri(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Object sasUri)
    {
        @selfRef.SasUri = sasUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithSasUri(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SasUri = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithServiceEndpoint(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Object serviceEndpoint)
    {
        @selfRef.ServiceEndpoint = serviceEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithServiceEndpoint(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ServiceEndpoint = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithSnapshot(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Object snapshot)
    {
        @selfRef.Snapshot = snapshot;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithSnapshot(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Snapshot = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithUserId(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Object userId)
    {
        @selfRef.UserId = userId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithUserId(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.UserId = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs WithVersion(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFileStorageLinkedServiceArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
