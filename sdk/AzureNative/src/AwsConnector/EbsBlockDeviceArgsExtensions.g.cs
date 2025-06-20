// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class EbsBlockDeviceArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs WithDeleteOnTermination(this global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs @selfRef, bool deleteOnTermination = true)
    {
        @selfRef.DeleteOnTermination = deleteOnTermination;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs WithEncrypted(this global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs @selfRef, bool encrypted = true)
    {
        @selfRef.Encrypted = encrypted;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs WithIops(this global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs @selfRef, global::System.Int32 iops)
    {
        @selfRef.Iops = iops;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs WithKmsKeyId(this global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs @selfRef, global::System.String kmsKeyId)
    {
        @selfRef.KmsKeyId = kmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs WithOutpostArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs @selfRef, global::System.String outpostArn)
    {
        @selfRef.OutpostArn = outpostArn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs WithSnapshotId(this global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs @selfRef, global::System.String snapshotId)
    {
        @selfRef.SnapshotId = snapshotId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs WithThroughput(this global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs @selfRef, global::System.Int32 throughput)
    {
        @selfRef.Throughput = throughput;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs WithVolumeSize(this global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs @selfRef, global::System.Int32 volumeSize)
    {
        @selfRef.VolumeSize = volumeSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs WithVolumeType(this global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.VolumeTypeEnumValueArgs volumeType)
    {
        @selfRef.VolumeType = volumeType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs WithVolumeType(this global::Pulumi.AzureNative.AwsConnector.Inputs.EbsBlockDeviceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.VolumeTypeEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.VolumeTypeEnumValueArgs();
        @configure(@item);
        @selfRef.VolumeType = @item;
        return @selfRef;
    }

}
