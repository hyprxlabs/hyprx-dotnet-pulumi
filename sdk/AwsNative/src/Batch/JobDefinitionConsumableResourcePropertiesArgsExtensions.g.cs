// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Batch.Inputs;

namespace Pulumi.AwsNative.Batch;

public static partial class JobDefinitionConsumableResourcePropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionConsumableResourcePropertiesArgs WithConsumableResourceList(this global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionConsumableResourcePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionConsumableResourceRequirementArgs> consumableResourceList)
    {
        @selfRef.ConsumableResourceList = consumableResourceList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionConsumableResourcePropertiesArgs WithConsumableResourceList(this global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionConsumableResourcePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionConsumableResourceRequirementArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionConsumableResourceRequirementArgs>();
        @configure(@list);
        @selfRef.ConsumableResourceList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionConsumableResourcePropertiesArgs WithConsumableResourceList(this global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionConsumableResourcePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionConsumableResourceRequirementArgs>> @create)
    {
        @selfRef.ConsumableResourceList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
