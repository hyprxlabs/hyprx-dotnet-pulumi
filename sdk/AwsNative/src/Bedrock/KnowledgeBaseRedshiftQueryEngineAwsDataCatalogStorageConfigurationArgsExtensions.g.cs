// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class KnowledgeBaseRedshiftQueryEngineAwsDataCatalogStorageConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineAwsDataCatalogStorageConfigurationArgs WithTableNames(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineAwsDataCatalogStorageConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::System.String> tableNames)
    {
        @selfRef.TableNames = tableNames;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineAwsDataCatalogStorageConfigurationArgs WithTableNames(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineAwsDataCatalogStorageConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.TableNames = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineAwsDataCatalogStorageConfigurationArgs WithTableNames(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseRedshiftQueryEngineAwsDataCatalogStorageConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.TableNames = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
