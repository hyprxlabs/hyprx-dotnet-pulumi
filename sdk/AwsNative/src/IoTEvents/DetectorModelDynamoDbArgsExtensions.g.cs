// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTEvents.Inputs;

namespace Pulumi.AwsNative.IoTEvents;

public static partial class DetectorModelDynamoDbArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs WithHashKeyField(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs @selfRef, global::System.String hashKeyField)
    {
        @selfRef.HashKeyField = hashKeyField;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs WithHashKeyType(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs @selfRef, global::System.String hashKeyType)
    {
        @selfRef.HashKeyType = hashKeyType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs WithHashKeyValue(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs @selfRef, global::System.String hashKeyValue)
    {
        @selfRef.HashKeyValue = hashKeyValue;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs WithOperation(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs @selfRef, global::System.String operation)
    {
        @selfRef.Operation = operation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs WithPayload(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs @selfRef, global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelPayloadArgs payload)
    {
        @selfRef.Payload = payload;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs WithPayload(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelPayloadArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelPayloadArgs();
        @configure(@item);
        @selfRef.Payload = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs WithPayloadField(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs @selfRef, global::System.String payloadField)
    {
        @selfRef.PayloadField = payloadField;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs WithRangeKeyField(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs @selfRef, global::System.String rangeKeyField)
    {
        @selfRef.RangeKeyField = rangeKeyField;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs WithRangeKeyType(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs @selfRef, global::System.String rangeKeyType)
    {
        @selfRef.RangeKeyType = rangeKeyType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs WithRangeKeyValue(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs @selfRef, global::System.String rangeKeyValue)
    {
        @selfRef.RangeKeyValue = rangeKeyValue;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs WithTableName(this global::Pulumi.AwsNative.IoTEvents.Inputs.DetectorModelDynamoDbArgs @selfRef, global::System.String tableName)
    {
        @selfRef.TableName = tableName;
        return @selfRef;
    }

}
