// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DynamoDb.Inputs;

namespace Pulumi.AwsNative.DynamoDb;

public static partial class GlobalTableSseSpecificationArgsExtensions
{
    public static global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableSseSpecificationArgs WithSseEnabled(this global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableSseSpecificationArgs @selfRef, bool sseEnabled = true)
    {
        @selfRef.SseEnabled = sseEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableSseSpecificationArgs WithSseType(this global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableSseSpecificationArgs @selfRef, global::System.String sseType)
    {
        @selfRef.SseType = sseType;
        return @selfRef;
    }

}
