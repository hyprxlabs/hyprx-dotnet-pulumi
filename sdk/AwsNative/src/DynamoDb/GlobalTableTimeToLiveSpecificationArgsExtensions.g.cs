// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DynamoDb.Inputs;

namespace Pulumi.AwsNative.DynamoDb;

public static partial class GlobalTableTimeToLiveSpecificationArgsExtensions
{
    public static global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableTimeToLiveSpecificationArgs WithAttributeName(this global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableTimeToLiveSpecificationArgs @selfRef, global::System.String attributeName)
    {
        @selfRef.AttributeName = attributeName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableTimeToLiveSpecificationArgs WithEnabled(this global::Pulumi.AwsNative.DynamoDb.Inputs.GlobalTableTimeToLiveSpecificationArgs @selfRef, bool enabled = true)
    {
        @selfRef.Enabled = enabled;
        return @selfRef;
    }

}
