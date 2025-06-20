// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class Ec2FleetBlockDeviceMappingArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetBlockDeviceMappingArgs WithDeviceName(this global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetBlockDeviceMappingArgs @selfRef, global::System.String deviceName)
    {
        @selfRef.DeviceName = deviceName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetBlockDeviceMappingArgs WithEbs(this global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetBlockDeviceMappingArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetEbsBlockDeviceArgs ebs)
    {
        @selfRef.Ebs = ebs;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetBlockDeviceMappingArgs WithEbs(this global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetBlockDeviceMappingArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetEbsBlockDeviceArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetEbsBlockDeviceArgs();
        @configure(@item);
        @selfRef.Ebs = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetBlockDeviceMappingArgs WithNoDevice(this global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetBlockDeviceMappingArgs @selfRef, global::System.String noDevice)
    {
        @selfRef.NoDevice = noDevice;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetBlockDeviceMappingArgs WithVirtualName(this global::Pulumi.AwsNative.Ec2.Inputs.Ec2FleetBlockDeviceMappingArgs @selfRef, global::System.String virtualName)
    {
        @selfRef.VirtualName = virtualName;
        return @selfRef;
    }

}
