// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Automation;

public static partial class RunbookArgsExtensions
{
    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithAutomationAccountName(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::System.String automationAccountName)
    {
        @selfRef.AutomationAccountName = automationAccountName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithDescription(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithDraft(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs draft)
    {
        @selfRef.Draft = draft;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithDraft(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Automation.Inputs.RunbookDraftArgs();
        @configure(@item);
        @selfRef.Draft = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithLocation(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithLogActivityTrace(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::System.Int32 logActivityTrace)
    {
        @selfRef.LogActivityTrace = logActivityTrace;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithLogProgress(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, bool logProgress = true)
    {
        @selfRef.LogProgress = logProgress;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithLogVerbose(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, bool logVerbose = true)
    {
        @selfRef.LogVerbose = logVerbose;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithName(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithPublishContentLink(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::Pulumi.AzureNative.Automation.Inputs.ContentLinkArgs publishContentLink)
    {
        @selfRef.PublishContentLink = publishContentLink;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithPublishContentLink(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Automation.Inputs.ContentLinkArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Automation.Inputs.ContentLinkArgs();
        @configure(@item);
        @selfRef.PublishContentLink = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithResourceGroupName(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithRunbookName(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::System.String runbookName)
    {
        @selfRef.RunbookName = runbookName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithRunbookType(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Automation.RunbookTypeEnum> runbookType)
    {
        @selfRef.RunbookType = runbookType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithTags(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithTags(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Automation.RunbookArgs WithTags(this global::Pulumi.AzureNative.Automation.RunbookArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
