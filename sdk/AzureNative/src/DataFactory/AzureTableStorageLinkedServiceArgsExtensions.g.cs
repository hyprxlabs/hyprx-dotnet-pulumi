// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class AzureTableStorageLinkedServiceArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithAccountKey(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs accountKey)
    {
        @selfRef.AccountKey = accountKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithAccountKey(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs();
        @configure(@item);
        @selfRef.AccountKey = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> annotations)
    {
        @selfRef.Annotations = annotations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.Annotations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.Annotations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs connectVia)
    {
        @selfRef.ConnectVia = connectVia;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs();
        @configure(@item);
        @selfRef.ConnectVia = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithConnectionString(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Object connectionString)
    {
        @selfRef.ConnectionString = connectionString;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithConnectionString(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ConnectionString = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.CredentialReferenceArgs credential)
    {
        @selfRef.Credential = credential;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.CredentialReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.CredentialReferenceArgs();
        @configure(@item);
        @selfRef.Credential = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithEncryptedCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.String encryptedCredential)
    {
        @selfRef.EncryptedCredential = encryptedCredential;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithSasToken(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs sasToken)
    {
        @selfRef.SasToken = sasToken;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithSasToken(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs();
        @configure(@item);
        @selfRef.SasToken = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithSasUri(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Object sasUri)
    {
        @selfRef.SasUri = sasUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithSasUri(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SasUri = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithServiceEndpoint(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Object serviceEndpoint)
    {
        @selfRef.ServiceEndpoint = serviceEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithServiceEndpoint(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ServiceEndpoint = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs WithVersion(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureTableStorageLinkedServiceArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
