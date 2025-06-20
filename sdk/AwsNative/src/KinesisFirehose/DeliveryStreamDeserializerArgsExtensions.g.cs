// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.KinesisFirehose.Inputs;

namespace Pulumi.AwsNative.KinesisFirehose;

public static partial class DeliveryStreamDeserializerArgsExtensions
{
    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamDeserializerArgs WithHiveJsonSerDe(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamDeserializerArgs @selfRef, global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamHiveJsonSerDeArgs hiveJsonSerDe)
    {
        @selfRef.HiveJsonSerDe = hiveJsonSerDe;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamDeserializerArgs WithHiveJsonSerDe(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamDeserializerArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamHiveJsonSerDeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamHiveJsonSerDeArgs();
        @configure(@item);
        @selfRef.HiveJsonSerDe = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamDeserializerArgs WithOpenXJsonSerDe(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamDeserializerArgs @selfRef, global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamOpenXJsonSerDeArgs openXJsonSerDe)
    {
        @selfRef.OpenXJsonSerDe = openXJsonSerDe;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamDeserializerArgs WithOpenXJsonSerDe(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamDeserializerArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamOpenXJsonSerDeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamOpenXJsonSerDeArgs();
        @configure(@item);
        @selfRef.OpenXJsonSerDe = @item;
        return @selfRef;
    }

}
