// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ec2.Inputs;

namespace Pulumi.AwsNative.Ec2;

public static partial class LaunchTemplateBlockDeviceMappingArgsExtensions
{
    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBlockDeviceMappingArgs WithDeviceName(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBlockDeviceMappingArgs @selfRef, global::System.String deviceName)
    {
        @selfRef.DeviceName = deviceName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBlockDeviceMappingArgs WithEbs(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBlockDeviceMappingArgs @selfRef, global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateEbsArgs ebs)
    {
        @selfRef.Ebs = ebs;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBlockDeviceMappingArgs WithEbs(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBlockDeviceMappingArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateEbsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateEbsArgs();
        @configure(@item);
        @selfRef.Ebs = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBlockDeviceMappingArgs WithNoDevice(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBlockDeviceMappingArgs @selfRef, global::System.String noDevice)
    {
        @selfRef.NoDevice = noDevice;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBlockDeviceMappingArgs WithVirtualName(this global::Pulumi.AwsNative.Ec2.Inputs.LaunchTemplateBlockDeviceMappingArgs @selfRef, global::System.String virtualName)
    {
        @selfRef.VirtualName = virtualName;
        return @selfRef;
    }

}
