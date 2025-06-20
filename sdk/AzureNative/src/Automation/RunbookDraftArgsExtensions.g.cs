// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Automation.Inputs;

namespace Pulumi.AzureNative.Automation;

public static partial class RunbookDraftArgsExtensions
{
    public static global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs WithCreationTime(this global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs @selfRef, global::System.String creationTime)
    {
        @selfRef.CreationTime = creationTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs WithDraftContentLink(this global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs @selfRef, global::Pulumi.AzureNative.Automation.Inputs.ContentLinkArgs draftContentLink)
    {
        @selfRef.DraftContentLink = draftContentLink;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs WithDraftContentLink(this global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Automation.Inputs.ContentLinkArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Automation.Inputs.ContentLinkArgs();
        @configure(@item);
        @selfRef.DraftContentLink = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs WithInEdit(this global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs @selfRef, bool inEdit = true)
    {
        @selfRef.InEdit = inEdit;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs WithLastModifiedTime(this global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs @selfRef, global::System.String lastModifiedTime)
    {
        @selfRef.LastModifiedTime = lastModifiedTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs WithOutputTypes(this global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs @selfRef, global::System.Collections.Generic.List<global::System.String> outputTypes)
    {
        @selfRef.OutputTypes = outputTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs WithOutputTypes(this global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.OutputTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs WithOutputTypes(this global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.OutputTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs WithParameters(this global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.Automation.Inputs.RunbookParameterArgs> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs WithParameters(this global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.Automation.Inputs.RunbookParameterArgs>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::Pulumi.AzureNative.Automation.Inputs.RunbookParameterArgs>();
        @configure(@dict);
        @selfRef.Parameters = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs WithParameters(this global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::Pulumi.AzureNative.Automation.Inputs.RunbookParameterArgs>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
