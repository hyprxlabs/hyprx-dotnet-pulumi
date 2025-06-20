// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ssm;

public static partial class ResourceDataSyncArgsExtensions
{
    public static global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs WithBucketName(this global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs @selfRef, global::System.String bucketName)
    {
        @selfRef.BucketName = bucketName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs WithBucketPrefix(this global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs @selfRef, global::System.String bucketPrefix)
    {
        @selfRef.BucketPrefix = bucketPrefix;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs WithBucketRegion(this global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs @selfRef, global::System.String bucketRegion)
    {
        @selfRef.BucketRegion = bucketRegion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs WithKmsKeyArn(this global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs @selfRef, global::System.String kmsKeyArn)
    {
        @selfRef.KmsKeyArn = kmsKeyArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs WithS3Destination(this global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs @selfRef, global::Pulumi.AwsNative.Ssm.Inputs.ResourceDataSyncS3DestinationArgs s3Destination)
    {
        @selfRef.S3Destination = s3Destination;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs WithS3Destination(this global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ssm.Inputs.ResourceDataSyncS3DestinationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ssm.Inputs.ResourceDataSyncS3DestinationArgs();
        @configure(@item);
        @selfRef.S3Destination = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs WithSyncFormat(this global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs @selfRef, global::System.String syncFormat)
    {
        @selfRef.SyncFormat = syncFormat;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs WithSyncName(this global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs @selfRef, global::System.String syncName)
    {
        @selfRef.SyncName = syncName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs WithSyncSource(this global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs @selfRef, global::Pulumi.AwsNative.Ssm.Inputs.ResourceDataSyncSyncSourceArgs syncSource)
    {
        @selfRef.SyncSource = syncSource;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs WithSyncSource(this global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Ssm.Inputs.ResourceDataSyncSyncSourceArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Ssm.Inputs.ResourceDataSyncSyncSourceArgs();
        @configure(@item);
        @selfRef.SyncSource = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs WithSyncType(this global::Pulumi.AwsNative.Ssm.ResourceDataSyncArgs @selfRef, global::System.String syncType)
    {
        @selfRef.SyncType = syncType;
        return @selfRef;
    }

}
