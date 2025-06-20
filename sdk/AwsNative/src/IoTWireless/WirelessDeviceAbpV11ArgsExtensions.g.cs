// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTWireless.Inputs;

namespace Pulumi.AwsNative.IoTWireless;

public static partial class WirelessDeviceAbpV11ArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTWireless.Inputs.WirelessDeviceAbpV11Args WithDevAddr(this global::Pulumi.AwsNative.IoTWireless.Inputs.WirelessDeviceAbpV11Args @selfRef, global::System.String devAddr)
    {
        @selfRef.DevAddr = devAddr;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.WirelessDeviceAbpV11Args WithSessionKeys(this global::Pulumi.AwsNative.IoTWireless.Inputs.WirelessDeviceAbpV11Args @selfRef, global::Pulumi.AwsNative.IoTWireless.Inputs.WirelessDeviceSessionKeysAbpV11Args sessionKeys)
    {
        @selfRef.SessionKeys = sessionKeys;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.WirelessDeviceAbpV11Args WithSessionKeys(this global::Pulumi.AwsNative.IoTWireless.Inputs.WirelessDeviceAbpV11Args @selfRef, global::System.Action<global::Pulumi.AwsNative.IoTWireless.Inputs.WirelessDeviceSessionKeysAbpV11Args> @configure)
    {
        var @item = new global::Pulumi.AwsNative.IoTWireless.Inputs.WirelessDeviceSessionKeysAbpV11Args();
        @configure(@item);
        @selfRef.SessionKeys = @item;
        return @selfRef;
    }

}
