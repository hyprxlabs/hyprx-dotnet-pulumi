// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Omics;

public static partial class SequenceStoreArgsExtensions
{
    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithAccessLogLocation(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.String accessLogLocation)
    {
        @selfRef.AccessLogLocation = accessLogLocation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithDescription(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithETagAlgorithmFamily(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::Pulumi.AwsNative.Omics.SequenceStoreETagAlgorithmFamily eTagAlgorithmFamily)
    {
        @selfRef.ETagAlgorithmFamily = eTagAlgorithmFamily;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithETagAlgorithmFamily(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Omics.SequenceStoreETagAlgorithmFamily> @configure)
    {
        var @item = global::System.Activator.CreateInstance<global::Pulumi.AwsNative.Omics.SequenceStoreETagAlgorithmFamily>();
        @configure(@item);
        @selfRef.ETagAlgorithmFamily = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithFallbackLocation(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.String fallbackLocation)
    {
        @selfRef.FallbackLocation = fallbackLocation;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithName(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.String name)
    {
        @selfRef.Name = name;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithPropagatedSetLevelTags(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.Collections.Generic.List<global::System.String> propagatedSetLevelTags)
    {
        @selfRef.PropagatedSetLevelTags = propagatedSetLevelTags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithPropagatedSetLevelTags(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.PropagatedSetLevelTags = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithPropagatedSetLevelTags(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.PropagatedSetLevelTags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithS3AccessPolicy(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.Object s3AccessPolicy)
    {
        @selfRef.S3AccessPolicy = s3AccessPolicy;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithS3AccessPolicy(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.S3AccessPolicy = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithSseConfig(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::Pulumi.AwsNative.Omics.Inputs.SequenceStoreSseConfigArgs sseConfig)
    {
        @selfRef.SseConfig = sseConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithSseConfig(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Omics.Inputs.SequenceStoreSseConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Omics.Inputs.SequenceStoreSseConfigArgs();
        @configure(@item);
        @selfRef.SseConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithTags(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithTags(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Omics.SequenceStoreArgs WithTags(this global::Pulumi.AwsNative.Omics.SequenceStoreArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
