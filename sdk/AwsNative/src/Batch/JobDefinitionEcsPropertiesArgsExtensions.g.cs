// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Batch.Inputs;

namespace Pulumi.AwsNative.Batch;

public static partial class JobDefinitionEcsPropertiesArgsExtensions
{
    public static global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionEcsPropertiesArgs WithTaskProperties(this global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionEcsPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionEcsTaskPropertiesArgs> taskProperties)
    {
        @selfRef.TaskProperties = taskProperties;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionEcsPropertiesArgs WithTaskProperties(this global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionEcsPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionEcsTaskPropertiesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionEcsTaskPropertiesArgs>();
        @configure(@list);
        @selfRef.TaskProperties = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionEcsPropertiesArgs WithTaskProperties(this global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionEcsPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionEcsTaskPropertiesArgs>> @create)
    {
        @selfRef.TaskProperties = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
