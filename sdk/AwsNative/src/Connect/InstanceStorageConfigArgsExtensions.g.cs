// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Connect;

public static partial class InstanceStorageConfigArgsExtensions
{
    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithInstanceArn(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::System.String instanceArn)
    {
        @selfRef.InstanceArn = instanceArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithKinesisFirehoseConfig(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::Pulumi.AwsNative.Connect.Inputs.InstanceStorageConfigKinesisFirehoseConfigArgs kinesisFirehoseConfig)
    {
        @selfRef.KinesisFirehoseConfig = kinesisFirehoseConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithKinesisFirehoseConfig(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Connect.Inputs.InstanceStorageConfigKinesisFirehoseConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Connect.Inputs.InstanceStorageConfigKinesisFirehoseConfigArgs();
        @configure(@item);
        @selfRef.KinesisFirehoseConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithKinesisStreamConfig(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::Pulumi.AwsNative.Connect.Inputs.InstanceStorageConfigKinesisStreamConfigArgs kinesisStreamConfig)
    {
        @selfRef.KinesisStreamConfig = kinesisStreamConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithKinesisStreamConfig(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Connect.Inputs.InstanceStorageConfigKinesisStreamConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Connect.Inputs.InstanceStorageConfigKinesisStreamConfigArgs();
        @configure(@item);
        @selfRef.KinesisStreamConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithKinesisVideoStreamConfig(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::Pulumi.AwsNative.Connect.Inputs.InstanceStorageConfigKinesisVideoStreamConfigArgs kinesisVideoStreamConfig)
    {
        @selfRef.KinesisVideoStreamConfig = kinesisVideoStreamConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithKinesisVideoStreamConfig(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Connect.Inputs.InstanceStorageConfigKinesisVideoStreamConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Connect.Inputs.InstanceStorageConfigKinesisVideoStreamConfigArgs();
        @configure(@item);
        @selfRef.KinesisVideoStreamConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithResourceType(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::Pulumi.AwsNative.Connect.InstanceStorageConfigInstanceStorageResourceType resourceType)
    {
        @selfRef.ResourceType = resourceType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithResourceType(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Connect.InstanceStorageConfigInstanceStorageResourceType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Connect.InstanceStorageConfigInstanceStorageResourceType>();
        @configure(@item);
        @selfRef.ResourceType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithS3Config(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::Pulumi.AwsNative.Connect.Inputs.InstanceStorageConfigS3ConfigArgs s3Config)
    {
        @selfRef.S3Config = s3Config;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithS3Config(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Connect.Inputs.InstanceStorageConfigS3ConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Connect.Inputs.InstanceStorageConfigS3ConfigArgs();
        @configure(@item);
        @selfRef.S3Config = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithStorageType(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::Pulumi.AwsNative.Connect.InstanceStorageConfigStorageType storageType)
    {
        @selfRef.StorageType = storageType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs WithStorageType(this global::Pulumi.AwsNative.Connect.InstanceStorageConfigArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Connect.InstanceStorageConfigStorageType> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Connect.InstanceStorageConfigStorageType>();
        @configure(@item);
        @selfRef.StorageType = @item;
        return @selfRef;
    }

}
