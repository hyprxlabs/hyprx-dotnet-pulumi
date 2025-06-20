// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Wisdom.Inputs;

namespace Pulumi.AwsNative.Wisdom;

public static partial class AiAgentKnowledgeBaseAssociationConfigurationDataArgsExtensions
{
    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentKnowledgeBaseAssociationConfigurationDataArgs WithMaxResults(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentKnowledgeBaseAssociationConfigurationDataArgs @selfRef, global::System.Double maxResults)
    {
        @selfRef.MaxResults = maxResults;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentKnowledgeBaseAssociationConfigurationDataArgs WithOverrideKnowledgeBaseSearchType(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentKnowledgeBaseAssociationConfigurationDataArgs @selfRef, global::Pulumi.AwsNative.Wisdom.AiAgentKnowledgeBaseSearchType overrideKnowledgeBaseSearchType)
    {
        @selfRef.OverrideKnowledgeBaseSearchType = overrideKnowledgeBaseSearchType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentKnowledgeBaseAssociationConfigurationDataArgs WithOverrideKnowledgeBaseSearchType(this global::Pulumi.AwsNative.Wisdom.Inputs.AiAgentKnowledgeBaseAssociationConfigurationDataArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Wisdom.AiAgentKnowledgeBaseSearchType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Wisdom.AiAgentKnowledgeBaseSearchType>();
        @configure(@item);
        @selfRef.OverrideKnowledgeBaseSearchType = @item;
        return @selfRef;
    }

}
