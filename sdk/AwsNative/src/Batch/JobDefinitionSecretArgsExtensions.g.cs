// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Batch.Inputs;

namespace Pulumi.AwsNative.Batch;

public static partial class JobDefinitionSecretArgsExtensions
{
    public static global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionSecretArgs WithName(this global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionSecretArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionSecretArgs WithValueFrom(this global::Pulumi.AwsNative.Batch.Inputs.JobDefinitionSecretArgs @selfRef, global::System.String valueFrom)
    {
        @selfRef.ValueFrom = valueFrom;
        return @selfRef;
    }

}
