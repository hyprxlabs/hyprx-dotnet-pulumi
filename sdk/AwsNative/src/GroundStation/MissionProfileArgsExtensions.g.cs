// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.GroundStation;

public static partial class MissionProfileArgsExtensions
{
    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithContactPostPassDurationSeconds(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.Int32 contactPostPassDurationSeconds)
    {
        @selfRef.ContactPostPassDurationSeconds = contactPostPassDurationSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithContactPrePassDurationSeconds(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.Int32 contactPrePassDurationSeconds)
    {
        @selfRef.ContactPrePassDurationSeconds = contactPrePassDurationSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithDataflowEdges(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.GroundStation.Inputs.MissionProfileDataflowEdgeArgs> dataflowEdges)
    {
        @selfRef.DataflowEdges = dataflowEdges;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithDataflowEdges(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.GroundStation.Inputs.MissionProfileDataflowEdgeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.GroundStation.Inputs.MissionProfileDataflowEdgeArgs>();
        @configure(@list);
        @selfRef.DataflowEdges = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithDataflowEdges(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.GroundStation.Inputs.MissionProfileDataflowEdgeArgs>> @create)
    {
        @selfRef.DataflowEdges = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithMinimumViableContactDurationSeconds(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.Int32 minimumViableContactDurationSeconds)
    {
        @selfRef.MinimumViableContactDurationSeconds = minimumViableContactDurationSeconds;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithName(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithStreamsKmsKey(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::Pulumi.AwsNative.GroundStation.Inputs.MissionProfileStreamsKmsKeyArgs streamsKmsKey)
    {
        @selfRef.StreamsKmsKey = streamsKmsKey;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithStreamsKmsKey(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.GroundStation.Inputs.MissionProfileStreamsKmsKeyArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.GroundStation.Inputs.MissionProfileStreamsKmsKeyArgs();
        @configure(@item);
        @selfRef.StreamsKmsKey = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithStreamsKmsRole(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.String streamsKmsRole)
    {
        @selfRef.StreamsKmsRole = streamsKmsRole;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithTags(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithTags(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithTags(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.GroundStation.MissionProfileArgs WithTrackingConfigArn(this global::Pulumi.AwsNative.GroundStation.MissionProfileArgs @selfRef, global::System.String trackingConfigArn)
    {
        @selfRef.TrackingConfigArn = trackingConfigArn;
        return @selfRef;
    }

}
