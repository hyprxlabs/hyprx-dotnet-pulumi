// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.KinesisFirehose.Inputs;

namespace Pulumi.AwsNative.KinesisFirehose;

public static partial class DeliveryStreamProcessorArgsExtensions
{
    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorArgs WithParameters(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorParameterArgs> parameters)
    {
        @selfRef.Parameters = parameters;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorArgs WithParameters(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorParameterArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorParameterArgs>();
        @configure(@list);
        @selfRef.Parameters = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorArgs WithParameters(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorParameterArgs>> @create)
    {
        @selfRef.Parameters = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorArgs WithType(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorArgs @selfRef, global::Pulumi.AwsNative.KinesisFirehose.DeliveryStreamProcessorType type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorArgs WithType(this global::Pulumi.AwsNative.KinesisFirehose.Inputs.DeliveryStreamProcessorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.KinesisFirehose.DeliveryStreamProcessorType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.KinesisFirehose.DeliveryStreamProcessorType>();
        @configure(@item);
        @selfRef.Type = @item;
        return @selfRef;
    }

}
