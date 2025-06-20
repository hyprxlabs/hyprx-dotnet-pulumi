// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Rekognition;

public static partial class StreamProcessorArgsExtensions
{
    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithBoundingBoxRegionsOfInterest(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorBoundingBoxArgs> boundingBoxRegionsOfInterest)
    {
        @selfRef.BoundingBoxRegionsOfInterest = boundingBoxRegionsOfInterest;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithBoundingBoxRegionsOfInterest(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorBoundingBoxArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorBoundingBoxArgs>();
        @configure(@list);
        @selfRef.BoundingBoxRegionsOfInterest = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithBoundingBoxRegionsOfInterest(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorBoundingBoxArgs>> @create)
    {
        @selfRef.BoundingBoxRegionsOfInterest = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithConnectedHomeSettings(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorConnectedHomeSettingsArgs connectedHomeSettings)
    {
        @selfRef.ConnectedHomeSettings = connectedHomeSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithConnectedHomeSettings(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorConnectedHomeSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorConnectedHomeSettingsArgs();
        @configure(@item);
        @selfRef.ConnectedHomeSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithDataSharingPreference(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorDataSharingPreferenceArgs dataSharingPreference)
    {
        @selfRef.DataSharingPreference = dataSharingPreference;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithDataSharingPreference(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorDataSharingPreferenceArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorDataSharingPreferenceArgs();
        @configure(@item);
        @selfRef.DataSharingPreference = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithFaceSearchSettings(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorFaceSearchSettingsArgs faceSearchSettings)
    {
        @selfRef.FaceSearchSettings = faceSearchSettings;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithFaceSearchSettings(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorFaceSearchSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorFaceSearchSettingsArgs();
        @configure(@item);
        @selfRef.FaceSearchSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithKinesisDataStream(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorKinesisDataStreamArgs kinesisDataStream)
    {
        @selfRef.KinesisDataStream = kinesisDataStream;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithKinesisDataStream(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorKinesisDataStreamArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorKinesisDataStreamArgs();
        @configure(@item);
        @selfRef.KinesisDataStream = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithKinesisVideoStream(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorKinesisVideoStreamArgs kinesisVideoStream)
    {
        @selfRef.KinesisVideoStream = kinesisVideoStream;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithKinesisVideoStream(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorKinesisVideoStreamArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorKinesisVideoStreamArgs();
        @configure(@item);
        @selfRef.KinesisVideoStream = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithKmsKeyId(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.String kmsKeyId)
    {
        @selfRef.KmsKeyId = kmsKeyId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithName(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithNotificationChannel(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorNotificationChannelArgs notificationChannel)
    {
        @selfRef.NotificationChannel = notificationChannel;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithNotificationChannel(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorNotificationChannelArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorNotificationChannelArgs();
        @configure(@item);
        @selfRef.NotificationChannel = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithPolygonRegionsOfInterest(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Collections.Generic.List<global::System.Collections.Immutable.ImmutableArray<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorPointArgs>> polygonRegionsOfInterest)
    {
        @selfRef.PolygonRegionsOfInterest = polygonRegionsOfInterest;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithPolygonRegionsOfInterest(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Collections.Immutable.ImmutableArray<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorPointArgs>>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Collections.Immutable.ImmutableArray<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorPointArgs>>();
        @configure(@list);
        @selfRef.PolygonRegionsOfInterest = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithPolygonRegionsOfInterest(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Collections.Immutable.ImmutableArray<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorPointArgs>>> @create)
    {
        @selfRef.PolygonRegionsOfInterest = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithRoleArn(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.String roleArn)
    {
        @selfRef.RoleArn = roleArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithS3Destination(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorS3DestinationArgs s3Destination)
    {
        @selfRef.S3Destination = s3Destination;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithS3Destination(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorS3DestinationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Rekognition.Inputs.StreamProcessorS3DestinationArgs();
        @configure(@item);
        @selfRef.S3Destination = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithTags(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithTags(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs WithTags(this global::Pulumi.AwsNative.Rekognition.StreamProcessorArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
