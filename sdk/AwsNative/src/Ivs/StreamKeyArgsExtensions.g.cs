// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Ivs;

public static partial class StreamKeyArgsExtensions
{
    public static global::Pulumi.AwsNative.Ivs.StreamKeyArgs WithChannelArn(this global::Pulumi.AwsNative.Ivs.StreamKeyArgs @selfRef, global::System.String channelArn)
    {
        @selfRef.ChannelArn = channelArn;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.StreamKeyArgs WithTags(this global::Pulumi.AwsNative.Ivs.StreamKeyArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.StreamKeyArgs WithTags(this global::Pulumi.AwsNative.Ivs.StreamKeyArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Ivs.StreamKeyArgs WithTags(this global::Pulumi.AwsNative.Ivs.StreamKeyArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
