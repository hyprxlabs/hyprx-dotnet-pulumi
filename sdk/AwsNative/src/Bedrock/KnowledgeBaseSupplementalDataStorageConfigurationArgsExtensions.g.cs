// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Bedrock.Inputs;

namespace Pulumi.AwsNative.Bedrock;

public static partial class KnowledgeBaseSupplementalDataStorageConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseSupplementalDataStorageConfigurationArgs WithSupplementalDataStorageLocations(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseSupplementalDataStorageConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseSupplementalDataStorageLocationArgs> supplementalDataStorageLocations)
    {
        @selfRef.SupplementalDataStorageLocations = supplementalDataStorageLocations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseSupplementalDataStorageConfigurationArgs WithSupplementalDataStorageLocations(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseSupplementalDataStorageConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseSupplementalDataStorageLocationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseSupplementalDataStorageLocationArgs>();
        @configure(@list);
        @selfRef.SupplementalDataStorageLocations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseSupplementalDataStorageConfigurationArgs WithSupplementalDataStorageLocations(this global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseSupplementalDataStorageConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Bedrock.Inputs.KnowledgeBaseSupplementalDataStorageLocationArgs>> @create)
    {
        @selfRef.SupplementalDataStorageLocations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
