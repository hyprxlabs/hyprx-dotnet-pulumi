// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.DynamoDb.Inputs;

namespace Pulumi.AwsNative.DynamoDb;

public static partial class TableWarmThroughputArgsExtensions
{
    public static global::Pulumi.AwsNative.DynamoDb.Inputs.TableWarmThroughputArgs WithReadUnitsPerSecond(this global::Pulumi.AwsNative.DynamoDb.Inputs.TableWarmThroughputArgs @selfRef, global::System.Int32 readUnitsPerSecond)
    {
        @selfRef.ReadUnitsPerSecond = readUnitsPerSecond;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.DynamoDb.Inputs.TableWarmThroughputArgs WithWriteUnitsPerSecond(this global::Pulumi.AwsNative.DynamoDb.Inputs.TableWarmThroughputArgs @selfRef, global::System.Int32 writeUnitsPerSecond)
    {
        @selfRef.WriteUnitsPerSecond = writeUnitsPerSecond;
        return @selfRef;
    }

}
