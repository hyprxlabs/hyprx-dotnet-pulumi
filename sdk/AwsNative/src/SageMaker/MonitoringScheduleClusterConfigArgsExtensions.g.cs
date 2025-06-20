// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AwsNative.SageMaker.Inputs;

namespace Pulumi.AwsNative.SageMaker;

public static partial class MonitoringScheduleClusterConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.SageMaker.Inputs.MonitoringScheduleClusterConfigArgs WithInstanceCount(this global::Pulumi.AwsNative.SageMaker.Inputs.MonitoringScheduleClusterConfigArgs @selfRef, global::System.Int32 instanceCount)
    {
        @selfRef.InstanceCount = instanceCount;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.MonitoringScheduleClusterConfigArgs WithInstanceType(this global::Pulumi.AwsNative.SageMaker.Inputs.MonitoringScheduleClusterConfigArgs @selfRef, global::System.String instanceType)
    {
        @selfRef.InstanceType = instanceType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.MonitoringScheduleClusterConfigArgs WithVolumeKmsKeyId(this global::Pulumi.AwsNative.SageMaker.Inputs.MonitoringScheduleClusterConfigArgs @selfRef, global::System.String volumeKmsKeyId)
    {
        @selfRef.VolumeKmsKeyId = volumeKmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.SageMaker.Inputs.MonitoringScheduleClusterConfigArgs WithVolumeSizeInGb(this global::Pulumi.AwsNative.SageMaker.Inputs.MonitoringScheduleClusterConfigArgs @selfRef, global::System.Int32 volumeSizeInGb)
    {
        @selfRef.VolumeSizeInGb = volumeSizeInGb;
        return @selfRef;
    }

}
