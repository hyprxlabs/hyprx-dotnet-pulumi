// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Logic;

public static partial class IntegrationAccountMapArgsExtensions
{
    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithContent(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::System.String content)
    {
        @selfRef.Content = content;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithContentType(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::System.String contentType)
    {
        @selfRef.ContentType = contentType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithIntegrationAccountName(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::System.String integrationAccountName)
    {
        @selfRef.IntegrationAccountName = integrationAccountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithLocation(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithMapName(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::System.String mapName)
    {
        @selfRef.MapName = mapName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithMapType(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Logic.MapType> mapType)
    {
        @selfRef.MapType = mapType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithMetadata(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::System.Object metadata)
    {
        @selfRef.Metadata = metadata;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithMetadata(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Metadata = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithParametersSchema(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::Pulumi.AzureNative.Logic.Inputs.IntegrationAccountMapPropertiesParametersSchemaArgs parametersSchema)
    {
        @selfRef.ParametersSchema = parametersSchema;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithParametersSchema(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Logic.Inputs.IntegrationAccountMapPropertiesParametersSchemaArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Logic.Inputs.IntegrationAccountMapPropertiesParametersSchemaArgs();
        @configure(@item);
        @selfRef.ParametersSchema = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithResourceGroupName(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithTags(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithTags(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs WithTags(this global::Pulumi.AzureNative.Logic.IntegrationAccountMapArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
