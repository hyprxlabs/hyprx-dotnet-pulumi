// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.KinesisFirehose.Inputs;

namespace Pulumi.AwsNative.KinesisFirehose;

public static partial class DeliveryStreamEncryptionConfigurationInputArgsExtensions
{
    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamEncryptionConfigurationInputArgs WithKeyArn(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamEncryptionConfigurationInputArgs @selfRef, global::System.String keyArn)
    {
        @selfRef.KeyArn = keyArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamEncryptionConfigurationInputArgs WithKeyType(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamEncryptionConfigurationInputArgs @selfRef, global::Pulumi.AwsNative.KinesisFirehose.DeliveryStreamEncryptionConfigurationInputKeyType keyType)
    {
        @selfRef.KeyType = keyType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamEncryptionConfigurationInputArgs WithKeyType(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamEncryptionConfigurationInputArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.KinesisFirehose.DeliveryStreamEncryptionConfigurationInputKeyType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.KinesisFirehose.DeliveryStreamEncryptionConfigurationInputKeyType>();
        @configure(@item);
        @selfRef.KeyType = @item;
        return @selfRef;
    }

}
