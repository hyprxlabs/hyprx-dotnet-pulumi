// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.CloudTrail;

public static partial class ChannelArgsExtensions
{
    public static global::Pulumi.AwsNative.CloudTrail.ChannelArgs WithDestinations(this global::Pulumi.AwsNative.CloudTrail.ChannelArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudTrail.Inputs.ChannelDestinationArgs> destinations)
    {
        @selfRef.Destinations = destinations;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.ChannelArgs WithDestinations(this global::Pulumi.AwsNative.CloudTrail.ChannelArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudTrail.Inputs.ChannelDestinationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.CloudTrail.Inputs.ChannelDestinationArgs>();
        @configure(@list);
        @selfRef.Destinations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.ChannelArgs WithDestinations(this global::Pulumi.AwsNative.CloudTrail.ChannelArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.CloudTrail.Inputs.ChannelDestinationArgs>> @create)
    {
        @selfRef.Destinations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.ChannelArgs WithName(this global::Pulumi.AwsNative.CloudTrail.ChannelArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.ChannelArgs WithSource(this global::Pulumi.AwsNative.CloudTrail.ChannelArgs @selfRef, global::System.String source)
    {
        @selfRef.Source = source;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.ChannelArgs WithTags(this global::Pulumi.AwsNative.CloudTrail.ChannelArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.ChannelArgs WithTags(this global::Pulumi.AwsNative.CloudTrail.ChannelArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Inputs.TagArgs>();
        @configure(@list);
        @selfRef.Tags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.CloudTrail.ChannelArgs WithTags(this global::Pulumi.AwsNative.CloudTrail.ChannelArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Inputs.TagArgs>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
