// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Confluent.Inputs;

namespace Pulumi.AzureNative.Confluent;

public static partial class TopicsInputConfigArgsExtensions
{
    public static global::Pulumi.AzureNative.Confluent.Inputs.TopicsInputConfigArgs WithName(this global::Pulumi.AzureNative.Confluent.Inputs.TopicsInputConfigArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Confluent.Inputs.TopicsInputConfigArgs WithValue(this global::Pulumi.AzureNative.Confluent.Inputs.TopicsInputConfigArgs @selfRef, global::System.String value)
    {
        @selfRef.Value = value;
        return @selfRef;
    }

}
