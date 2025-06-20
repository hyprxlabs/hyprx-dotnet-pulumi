// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.IoTWireless.Inputs;

namespace Pulumi.AwsNative.IoTWireless;

public static partial class DeviceProfileLoRaWanDeviceProfileArgsExtensions
{
    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithClassBTimeout(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Int32 classBTimeout)
    {
        @selfRef.ClassBTimeout = classBTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithClassCTimeout(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Int32 classCTimeout)
    {
        @selfRef.ClassCTimeout = classCTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithFactoryPresetFreqsList(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Collections.Generic.List<global::System.Int32> factoryPresetFreqsList)
    {
        @selfRef.FactoryPresetFreqsList = factoryPresetFreqsList;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithFactoryPresetFreqsList(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Int32>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Int32>();
        @configure(@list);
        @selfRef.FactoryPresetFreqsList = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithFactoryPresetFreqsList(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Int32>> @create)
    {
        @selfRef.FactoryPresetFreqsList = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithMacVersion(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.String macVersion)
    {
        @selfRef.MacVersion = macVersion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithMaxDutyCycle(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Int32 maxDutyCycle)
    {
        @selfRef.MaxDutyCycle = maxDutyCycle;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithMaxEirp(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Int32 maxEirp)
    {
        @selfRef.MaxEirp = maxEirp;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithPingSlotDr(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Int32 pingSlotDr)
    {
        @selfRef.PingSlotDr = pingSlotDr;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithPingSlotFreq(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Int32 pingSlotFreq)
    {
        @selfRef.PingSlotFreq = pingSlotFreq;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithPingSlotPeriod(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Int32 pingSlotPeriod)
    {
        @selfRef.PingSlotPeriod = pingSlotPeriod;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithRegParamsRevision(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.String regParamsRevision)
    {
        @selfRef.RegParamsRevision = regParamsRevision;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithRfRegion(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.String rfRegion)
    {
        @selfRef.RfRegion = rfRegion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithRxDataRate2(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Int32 rxDataRate2)
    {
        @selfRef.RxDataRate2 = rxDataRate2;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithRxDelay1(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Int32 rxDelay1)
    {
        @selfRef.RxDelay1 = rxDelay1;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithRxDrOffset1(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Int32 rxDrOffset1)
    {
        @selfRef.RxDrOffset1 = rxDrOffset1;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithRxFreq2(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, global::System.Int32 rxFreq2)
    {
        @selfRef.RxFreq2 = rxFreq2;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithSupports32BitFCnt(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, bool supports32BitFCnt = true)
    {
        @selfRef.Supports32BitFCnt = supports32BitFCnt;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithSupportsClassB(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, bool supportsClassB = true)
    {
        @selfRef.SupportsClassB = supportsClassB;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithSupportsClassC(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, bool supportsClassC = true)
    {
        @selfRef.SupportsClassC = supportsClassC;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs WithSupportsJoin(this global::Pulumi.AwsNative.IoTWireless.Inputs.DeviceProfileLoRaWanDeviceProfileArgs @selfRef, bool supportsJoin = true)
    {
        @selfRef.SupportsJoin = supportsJoin;
        return @selfRef;
    }

}
