// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.Ecs.Inputs;

namespace Pulumi.AwsNative.Ecs;

public static partial class ServiceManagedEbsVolumeConfigurationArgsExtensions
{
    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithEncrypted(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, bool encrypted = true)
    {
        @selfRef.Encrypted = encrypted;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithFilesystemType(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, global::System.String filesystemType)
    {
        @selfRef.FilesystemType = filesystemType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithIops(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, global::System.Int32 iops)
    {
        @selfRef.Iops = iops;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithKmsKeyId(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, global::System.String kmsKeyId)
    {
        @selfRef.KmsKeyId = kmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithRoleArn(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithSizeInGiB(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, global::System.Int32 sizeInGiB)
    {
        @selfRef.SizeInGiB = sizeInGiB;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithSnapshotId(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, global::System.String snapshotId)
    {
        @selfRef.SnapshotId = snapshotId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithTagSpecifications(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ecs.Inputs.ServiceEbsTagSpecificationArgs> tagSpecifications)
    {
        @selfRef.TagSpecifications = tagSpecifications;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithTagSpecifications(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ecs.Inputs.ServiceEbsTagSpecificationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Ecs.Inputs.ServiceEbsTagSpecificationArgs>();
        @configure(@list);
        @selfRef.TagSpecifications = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithTagSpecifications(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Ecs.Inputs.ServiceEbsTagSpecificationArgs>> @create)
    {
        @selfRef.TagSpecifications = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithThroughput(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, global::System.Int32 throughput)
    {
        @selfRef.Throughput = throughput;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithVolumeInitializationRate(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, global::System.Int32 volumeInitializationRate)
    {
        @selfRef.VolumeInitializationRate = volumeInitializationRate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs WithVolumeType(this global::Pulumi.AwsNative.Ecs.Inputs.ServiceManagedEbsVolumeConfigurationArgs @selfRef, global::System.String volumeType)
    {
        @selfRef.VolumeType = volumeType;
        return @selfRef;
    }

}
