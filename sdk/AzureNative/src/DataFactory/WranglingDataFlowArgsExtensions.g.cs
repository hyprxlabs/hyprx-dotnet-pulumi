// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class WranglingDataFlowArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> annotations)
    {
        @selfRef.Annotations = annotations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.Annotations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs WithAnnotations(this global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.Annotations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs WithDescription(this global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs WithDocumentLocale(this global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs @selfRef, global::System.String documentLocale)
    {
        @selfRef.DocumentLocale = documentLocale;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs WithFolder(this global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.DataFlowFolderArgs folder)
    {
        @selfRef.Folder = folder;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs WithFolder(this global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.DataFlowFolderArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.DataFlowFolderArgs();
        @configure(@item);
        @selfRef.Folder = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs WithScript(this global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs @selfRef, global::System.String script)
    {
        @selfRef.Script = script;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs WithSources(this global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.PowerQuerySourceArgs> sources)
    {
        @selfRef.Sources = sources;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs WithSources(this global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.PowerQuerySourceArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.PowerQuerySourceArgs>();
        @configure(@list);
        @selfRef.Sources = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs WithSources(this global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataFactory.Inputs.PowerQuerySourceArgs>> @create)
    {
        @selfRef.Sources = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.WranglingDataFlowArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
