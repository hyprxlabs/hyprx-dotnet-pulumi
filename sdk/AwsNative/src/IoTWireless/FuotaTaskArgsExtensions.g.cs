// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.IoTWireless;

public static partial class FuotaTaskArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithAssociateMulticastGroup(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::System.String associateMulticastGroup)
    {
        @selfRef.AssociateMulticastGroup = associateMulticastGroup;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithAssociateWirelessDevice(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::System.String associateWirelessDevice)
    {
        @selfRef.AssociateWirelessDevice = associateWirelessDevice;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithDescription(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithDisassociateMulticastGroup(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::System.String disassociateMulticastGroup)
    {
        @selfRef.DisassociateMulticastGroup = disassociateMulticastGroup;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithDisassociateWirelessDevice(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::System.String disassociateWirelessDevice)
    {
        @selfRef.DisassociateWirelessDevice = disassociateWirelessDevice;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithFirmwareUpdateImage(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::System.String firmwareUpdateImage)
    {
        @selfRef.FirmwareUpdateImage = firmwareUpdateImage;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithFirmwareUpdateRole(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::System.String firmwareUpdateRole)
    {
        @selfRef.FirmwareUpdateRole = firmwareUpdateRole;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithLoRaWan(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::Pulumi.AwsNative.IoTWireless.Inputs.FuotaTaskLoRaWanArgs loRaWan)
    {
        @selfRef.LoRaWan = loRaWan;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithLoRaWan(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTWireless.Inputs.FuotaTaskLoRaWanArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTWireless.Inputs.FuotaTaskLoRaWanArgs();
        @configure(@item);
        @selfRef.LoRaWan = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithName(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithTags(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithTags(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs WithTags(this global::Pulumi.AwsNative.IoTWireless.FuotaTaskArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
