// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.MediaTailor;

public static partial class ChannelArgsExtensions
{
    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithAudiences(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Collections.Generic.List<global::System.String> audiences)
    {
        @selfRef.Audiences = audiences;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithAudiences(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Audiences = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithAudiences(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Audiences = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithChannelName(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.String channelName)
    {
        @selfRef.ChannelName = channelName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithFillerSlate(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelSlateSourceArgs fillerSlate)
    {
        @selfRef.FillerSlate = fillerSlate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithFillerSlate(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelSlateSourceArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelSlateSourceArgs();
        @configure(@item);
        @selfRef.FillerSlate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithLogConfiguration(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelLogConfigurationForChannelArgs logConfiguration)
    {
        @selfRef.LogConfiguration = logConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithLogConfiguration(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelLogConfigurationForChannelArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelLogConfigurationForChannelArgs();
        @configure(@item);
        @selfRef.LogConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithOutputs(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelRequestOutputItemArgs> outputs)
    {
        @selfRef.Outputs = outputs;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithOutputs(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelRequestOutputItemArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelRequestOutputItemArgs>();
        @configure(@list);
        @selfRef.Outputs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithOutputs(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelRequestOutputItemArgs>> @create)
    {
        @selfRef.Outputs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithPlaybackMode(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::Pulumi.AwsNative.MediaTailor.ChannelPlaybackMode playbackMode)
    {
        @selfRef.PlaybackMode = playbackMode;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithPlaybackMode(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaTailor.ChannelPlaybackMode> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.MediaTailor.ChannelPlaybackMode>();
        @configure(@item);
        @selfRef.PlaybackMode = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithTags(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithTags(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithTags(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithTier(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::Pulumi.AwsNative.MediaTailor.ChannelTier tier)
    {
        @selfRef.Tier = tier;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithTier(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaTailor.ChannelTier> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.MediaTailor.ChannelTier>();
        @configure(@item);
        @selfRef.Tier = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithTimeShiftConfiguration(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelTimeShiftConfigurationArgs timeShiftConfiguration)
    {
        @selfRef.TimeShiftConfiguration = timeShiftConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.MediaTailor.ChannelArgs WithTimeShiftConfiguration(this global::Pulumi.AwsNative.MediaTailor.ChannelArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelTimeShiftConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.MediaTailor.Inputs.ChannelTimeShiftConfigurationArgs();
        @configure(@item);
        @selfRef.TimeShiftConfiguration = @item;
        return @selfRef;
    }

}
