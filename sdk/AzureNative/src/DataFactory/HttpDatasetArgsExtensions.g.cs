// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class HttpDatasetArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithAdditionalHeaders(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Object additionalHeaders)
    {
        @selfRef.AdditionalHeaders = additionalHeaders;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithAdditionalHeaders(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.AdditionalHeaders = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> annotations)
    {
        @selfRef.Annotations = annotations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.Annotations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.Annotations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithCompression(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.DatasetCompressionArgs compression)
    {
        @selfRef.Compression = compression;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithCompression(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.DatasetCompressionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.DatasetCompressionArgs();
        @configure(@item);
        @selfRef.Compression = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithFolder(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.DatasetFolderArgs folder)
    {
        @selfRef.Folder = folder;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithFolder(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.DatasetFolderArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.DatasetFolderArgs();
        @configure(@item);
        @selfRef.Folder = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithLinkedServiceName(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs linkedServiceName)
    {
        @selfRef.LinkedServiceName = linkedServiceName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithLinkedServiceName(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.LinkedServiceReferenceArgs();
        @configure(@item);
        @selfRef.LinkedServiceName = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithParameters(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.DataFactory.Inputs.ParameterSpecificationArgs>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithRelativeUrl(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Object relativeUrl)
    {
        @selfRef.RelativeUrl = relativeUrl;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithRelativeUrl(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.RelativeUrl = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithRequestBody(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Object requestBody)
    {
        @selfRef.RequestBody = requestBody;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithRequestBody(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.RequestBody = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithRequestMethod(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Object requestMethod)
    {
        @selfRef.RequestMethod = requestMethod;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithRequestMethod(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.RequestMethod = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithSchema(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Object schema)
    {
        @selfRef.Schema = schema;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithSchema(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Schema = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithStructure(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Object structure)
    {
        @selfRef.Structure = structure;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithStructure(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Structure = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.HttpDatasetArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
