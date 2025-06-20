// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class TeradataLinkedServiceArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> annotations)
    {
        @selfRef.Annotations = annotations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.Annotations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.Annotations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithAuthenticationType(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.DataFactory.TeradataAuthenticationType> authenticationType)
    {
        @selfRef.AuthenticationType = authenticationType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithCharacterSet(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Object characterSet)
    {
        @selfRef.CharacterSet = characterSet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithCharacterSet(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.CharacterSet = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs connectVia)
    {
        @selfRef.ConnectVia = connectVia;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs();
        @configure(@item);
        @selfRef.ConnectVia = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithConnectionString(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Object connectionString)
    {
        @selfRef.ConnectionString = connectionString;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithConnectionString(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ConnectionString = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithEncryptedCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.String encryptedCredential)
    {
        @selfRef.EncryptedCredential = encryptedCredential;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithHttpsPortNumber(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Object httpsPortNumber)
    {
        @selfRef.HttpsPortNumber = httpsPortNumber;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithHttpsPortNumber(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.HttpsPortNumber = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithMaxRespSize(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Object maxRespSize)
    {
        @selfRef.MaxRespSize = maxRespSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithMaxRespSize(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MaxRespSize = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithPassword(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs, global::Pulumi.AzureNative.DataFactory.Inputs.SecureStringArgs> password)
    {
        @selfRef.Password = password;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithPortNumber(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Object portNumber)
    {
        @selfRef.PortNumber = portNumber;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithPortNumber(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.PortNumber = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithServer(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Object server)
    {
        @selfRef.Server = server;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithServer(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Server = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithSslMode(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Object sslMode)
    {
        @selfRef.SslMode = sslMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithSslMode(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SslMode = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithUseDataEncryption(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Object useDataEncryption)
    {
        @selfRef.UseDataEncryption = useDataEncryption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithUseDataEncryption(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.UseDataEncryption = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithUsername(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Object username)
    {
        @selfRef.Username = username;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithUsername(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Username = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs WithVersion(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataLinkedServiceArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
