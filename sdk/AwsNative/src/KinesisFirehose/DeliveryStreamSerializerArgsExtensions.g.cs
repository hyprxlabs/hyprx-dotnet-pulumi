// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.KinesisFirehose.Inputs;

namespace Pulumi.AwsNative.KinesisFirehose;

public static partial class DeliveryStreamSerializerArgsExtensions
{
    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamSerializerArgs WithOrcSerDe(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamSerializerArgs @selfRef, global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamOrcSerDeArgs orcSerDe)
    {
        @selfRef.OrcSerDe = orcSerDe;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamSerializerArgs WithOrcSerDe(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamSerializerArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamOrcSerDeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamOrcSerDeArgs();
        @configure(@item);
        @selfRef.OrcSerDe = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamSerializerArgs WithParquetSerDe(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamSerializerArgs @selfRef, global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamParquetSerDeArgs parquetSerDe)
    {
        @selfRef.ParquetSerDe = parquetSerDe;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamSerializerArgs WithParquetSerDe(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamSerializerArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamParquetSerDeArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamParquetSerDeArgs();
        @configure(@item);
        @selfRef.ParquetSerDe = @item;
        return @selfRef;
    }

}
