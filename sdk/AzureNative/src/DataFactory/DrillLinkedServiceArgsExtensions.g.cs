// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class DrillLinkedServiceArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> annotations)
    {
        @selfRef.Annotations = annotations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.Annotations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.Annotations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs connectVia)
    {
        @selfRef.ConnectVia = connectVia;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithConnectVia(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.IntegrationRuntimeReferenceArgs();
        @configure(@item);
        @selfRef.ConnectVia = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithConnectionString(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.Object connectionString)
    {
        @selfRef.ConnectionString = connectionString;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithConnectionString(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.ConnectionString = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithEncryptedCredential(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.String encryptedCredential)
    {
        @selfRef.EncryptedCredential = encryptedCredential;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithPwd(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs pwd)
    {
        @selfRef.Pwd = pwd;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithPwd(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.AzureKeyVaultSecretReferenceArgs();
        @configure(@item);
        @selfRef.Pwd = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs WithVersion(this global::Pulumi.AzureNative.DataFactory.Inputs.DrillLinkedServiceArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
