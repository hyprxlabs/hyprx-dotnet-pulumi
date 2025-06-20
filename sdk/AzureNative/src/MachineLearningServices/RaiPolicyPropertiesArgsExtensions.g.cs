// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.MachineLearningServices.Inputs;

namespace Pulumi.AzureNative.MachineLearningServices;

public static partial class RaiPolicyPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs WithBasePolicyName(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs @selfRef, global::System.String basePolicyName)
    {
        @selfRef.BasePolicyName = basePolicyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs WithCompletionBlocklists(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiBlocklistConfigArgs> completionBlocklists)
    {
        @selfRef.CompletionBlocklists = completionBlocklists;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs WithCompletionBlocklists(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiBlocklistConfigArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiBlocklistConfigArgs>();
        @configure(@list);
        @selfRef.CompletionBlocklists = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs WithCompletionBlocklists(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiBlocklistConfigArgs>> @create)
    {
        @selfRef.CompletionBlocklists = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs WithContentFilters(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyContentFilterArgs> contentFilters)
    {
        @selfRef.ContentFilters = contentFilters;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs WithContentFilters(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyContentFilterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyContentFilterArgs>();
        @configure(@list);
        @selfRef.ContentFilters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs WithContentFilters(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyContentFilterArgs>> @create)
    {
        @selfRef.ContentFilters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs WithMode(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.RaiPolicyMode> mode)
    {
        @selfRef.Mode = mode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs WithPromptBlocklists(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiBlocklistConfigArgs> promptBlocklists)
    {
        @selfRef.PromptBlocklists = promptBlocklists;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs WithPromptBlocklists(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiBlocklistConfigArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiBlocklistConfigArgs>();
        @configure(@list);
        @selfRef.PromptBlocklists = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs WithPromptBlocklists(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiBlocklistConfigArgs>> @create)
    {
        @selfRef.PromptBlocklists = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs WithType(this global::Pulumi.AzureNative.MachineLearningServices.Inputs.RaiPolicyPropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.MachineLearningServices.RaiPolicyType> type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
