// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Wisdom.Inputs;

namespace Pulumi.AwsNative.Wisdom;

public static partial class KnowledgeBaseHierarchicalChunkingConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseHierarchicalChunkingConfigurationArgs WithLevelConfigurations(this global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseHierarchicalChunkingConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseHierarchicalChunkingLevelConfigurationArgs> levelConfigurations)
    {
        @selfRef.LevelConfigurations = levelConfigurations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseHierarchicalChunkingConfigurationArgs WithLevelConfigurations(this global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseHierarchicalChunkingConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseHierarchicalChunkingLevelConfigurationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseHierarchicalChunkingLevelConfigurationArgs>();
        @configure(@list);
        @selfRef.LevelConfigurations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseHierarchicalChunkingConfigurationArgs WithLevelConfigurations(this global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseHierarchicalChunkingConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseHierarchicalChunkingLevelConfigurationArgs>> @create)
    {
        @selfRef.LevelConfigurations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseHierarchicalChunkingConfigurationArgs WithOverlapTokens(this global::Pulumi.AwsNative.Wisdom.Inputs.KnowledgeBaseHierarchicalChunkingConfigurationArgs @selfRef, global::System.Double overlapTokens)
    {
        @selfRef.OverlapTokens = overlapTokens;
        return @selfRef;
    }

}
