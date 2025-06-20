// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class AzureStorageLinkedServiceArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithAccountKey(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs accountKey)
    {
        @selfRef.AccountKey = accountKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithAccountKey(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs();
        @configure(@item);
        @selfRef.AccountKey = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> annotations)
    {
        @selfRef.Annotations = annotations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.Annotations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.Annotations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs connectVia)
    {
        @selfRef.ConnectVia = connectVia;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs();
        @configure(@item);
        @selfRef.ConnectVia = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithConnectionString(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Object connectionString)
    {
        @selfRef.ConnectionString = connectionString;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithConnectionString(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ConnectionString = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithEncryptedCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.String encryptedCredential)
    {
        @selfRef.EncryptedCredential = encryptedCredential;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithSasToken(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs sasToken)
    {
        @selfRef.SasToken = sasToken;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithSasToken(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs();
        @configure(@item);
        @selfRef.SasToken = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithSasUri(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Object sasUri)
    {
        @selfRef.SasUri = sasUri;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithSasUri(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SasUri = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs WithVersion(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureStorageLinkedServiceArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
