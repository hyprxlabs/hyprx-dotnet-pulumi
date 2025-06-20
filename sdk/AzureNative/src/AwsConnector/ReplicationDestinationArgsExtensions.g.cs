// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class ReplicationDestinationArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithAccessControlTranslation(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.AccessControlTranslationArgs accessControlTranslation)
    {
        @selfRef.AccessControlTranslation = accessControlTranslation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithAccessControlTranslation(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.AccessControlTranslationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.AccessControlTranslationArgs();
        @configure(@item);
        @selfRef.AccessControlTranslation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithAccount(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::System.String account)
    {
        @selfRef.Account = account;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithAvailabilityZoneName(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::System.String availabilityZoneName)
    {
        @selfRef.AvailabilityZoneName = availabilityZoneName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithBucket(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::System.String bucket)
    {
        @selfRef.Bucket = bucket;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithEncryptionConfiguration(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.EncryptionConfigurationArgs encryptionConfiguration)
    {
        @selfRef.EncryptionConfiguration = encryptionConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithEncryptionConfiguration(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.EncryptionConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.EncryptionConfigurationArgs();
        @configure(@item);
        @selfRef.EncryptionConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithFileSystemId(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::System.String fileSystemId)
    {
        @selfRef.FileSystemId = fileSystemId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithKmsKeyId(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::System.String kmsKeyId)
    {
        @selfRef.KmsKeyId = kmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithMetrics(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsArgs metrics)
    {
        @selfRef.Metrics = metrics;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithMetrics(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.MetricsArgs();
        @configure(@item);
        @selfRef.Metrics = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithRegion(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::System.String region)
    {
        @selfRef.Region = region;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithReplicationTime(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationTimeArgs replicationTime)
    {
        @selfRef.ReplicationTime = replicationTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithReplicationTime(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationTimeArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationTimeArgs();
        @configure(@item);
        @selfRef.ReplicationTime = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs WithStorageClass(this global::Pulumi.AzureNative.AwsConnector.Inputs.ReplicationDestinationArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.AwsConnector.ReplicationDestinationStorageClass> storageClass)
    {
        @selfRef.StorageClass = storageClass;
        return @selfRef;
    }

}
