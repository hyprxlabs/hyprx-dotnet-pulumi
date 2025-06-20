// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.IoTWireless;

public static partial class MulticastGroupArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs WithAssociateWirelessDevice(this global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs @selfRef, global::System.String associateWirelessDevice)
    {
        @selfRef.AssociateWirelessDevice = associateWirelessDevice;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs WithDescription(this global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs WithDisassociateWirelessDevice(this global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs @selfRef, global::System.String disassociateWirelessDevice)
    {
        @selfRef.DisassociateWirelessDevice = disassociateWirelessDevice;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs WithLoRaWan(this global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs @selfRef, global::Pulumi.AwsNative.IoTWireless.Inputs.MulticastGroupLoRaWanArgs loRaWan)
    {
        @selfRef.LoRaWan = loRaWan;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs WithLoRaWan(this global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTWireless.Inputs.MulticastGroupLoRaWanArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTWireless.Inputs.MulticastGroupLoRaWanArgs();
        @configure(@item);
        @selfRef.LoRaWan = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs WithName(this global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs WithTags(this global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs WithTags(this global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs WithTags(this global::Pulumi.AwsNative.IoTWireless.MulticastGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
