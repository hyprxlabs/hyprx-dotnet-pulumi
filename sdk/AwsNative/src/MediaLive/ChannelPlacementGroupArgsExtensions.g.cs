// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.MediaLive;

public static partial class ChannelPlacementGroupArgsExtensions
{
    public static global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs WithClusterId(this global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs @selfRef, global::System.String clusterId)
    {
        @selfRef.ClusterId = clusterId;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs WithName(this global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs WithNodes(this global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs @selfRef, global::System.Collections.Generic.List<global::System.String> nodes)
    {
        @selfRef.Nodes = nodes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs WithNodes(this global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Nodes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs WithNodes(this global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Nodes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs WithTags(this global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs WithTags(this global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs WithTags(this global::Pulumi.AwsNative.MediaLive.ChannelPlacementGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
