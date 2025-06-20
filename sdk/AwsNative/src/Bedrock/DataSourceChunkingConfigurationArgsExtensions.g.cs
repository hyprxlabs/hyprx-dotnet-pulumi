// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class DataSourceChunkingConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs WithChunkingStrategy(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.DataSourceChunkingStrategy chunkingStrategy)
    {
        @selfRef.ChunkingStrategy = chunkingStrategy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs WithChunkingStrategy(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.DataSourceChunkingStrategy> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Bedrock.DataSourceChunkingStrategy>();
        @configure(@item);
        @selfRef.ChunkingStrategy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs WithFixedSizeChunkingConfiguration(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceFixedSizeChunkingConfigurationArgs fixedSizeChunkingConfiguration)
    {
        @selfRef.FixedSizeChunkingConfiguration = fixedSizeChunkingConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs WithFixedSizeChunkingConfiguration(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceFixedSizeChunkingConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceFixedSizeChunkingConfigurationArgs();
        @configure(@item);
        @selfRef.FixedSizeChunkingConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs WithHierarchicalChunkingConfiguration(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceHierarchicalChunkingConfigurationArgs hierarchicalChunkingConfiguration)
    {
        @selfRef.HierarchicalChunkingConfiguration = hierarchicalChunkingConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs WithHierarchicalChunkingConfiguration(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceHierarchicalChunkingConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceHierarchicalChunkingConfigurationArgs();
        @configure(@item);
        @selfRef.HierarchicalChunkingConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs WithSemanticChunkingConfiguration(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs @selfRef, global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSemanticChunkingConfigurationArgs semanticChunkingConfiguration)
    {
        @selfRef.SemanticChunkingConfiguration = semanticChunkingConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs WithSemanticChunkingConfiguration(this global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceChunkingConfigurationArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSemanticChunkingConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Bedrock.Inputs.DataSourceSemanticChunkingConfigurationArgs();
        @configure(@item);
        @selfRef.SemanticChunkingConfiguration = @item;
        return @selfRef;
    }

}
