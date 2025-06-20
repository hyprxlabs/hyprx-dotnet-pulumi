// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class AzureFunctionLinkedServiceArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> annotations)
    {
        @selfRef.Annotations = annotations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.Annotations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.Annotations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithAuthentication(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Object authentication)
    {
        @selfRef.Authentication = authentication;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithAuthentication(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Authentication = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs connectVia)
    {
        @selfRef.ConnectVia = connectVia;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs();
        @configure(@item);
        @selfRef.ConnectVia = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.CredentialReferenceArgs credential)
    {
        @selfRef.Credential = credential;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.CredentialReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.CredentialReferenceArgs();
        @configure(@item);
        @selfRef.Credential = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithEncryptedCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.String encryptedCredential)
    {
        @selfRef.EncryptedCredential = encryptedCredential;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithFunctionAppUrl(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Object functionAppUrl)
    {
        @selfRef.FunctionAppUrl = functionAppUrl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithFunctionAppUrl(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.FunctionAppUrl = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithFunctionKey(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::Pulumi.Union<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs, global::Pulumi.AzureNative.DataFactory.Inputs.SecureStringArgs> functionKey)
    {
        @selfRef.FunctionKey = functionKey;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithResourceId(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Object resourceId)
    {
        @selfRef.ResourceId = resourceId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithResourceId(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ResourceId = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs WithVersion(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureFunctionLinkedServiceArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
