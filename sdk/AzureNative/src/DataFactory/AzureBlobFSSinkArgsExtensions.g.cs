// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class AzureBlobFSSinkArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithCopyBehavior(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Object copyBehavior)
    {
        @selfRef.CopyBehavior = copyBehavior;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithCopyBehavior(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.CopyBehavior = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithDisableMetricsCollection(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Object disableMetricsCollection)
    {
        @selfRef.DisableMetricsCollection = disableMetricsCollection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithDisableMetricsCollection(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.DisableMetricsCollection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithMaxConcurrentConnections(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Object maxConcurrentConnections)
    {
        @selfRef.MaxConcurrentConnections = maxConcurrentConnections;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithMaxConcurrentConnections(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MaxConcurrentConnections = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithMetadata(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.MetadataItemArgs> metadata)
    {
        @selfRef.Metadata = metadata;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithMetadata(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.MetadataItemArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.DataFactory.Inputs.MetadataItemArgs>();
        @configure(@list);
        @selfRef.Metadata = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithMetadata(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.DataFactory.Inputs.MetadataItemArgs>> @create)
    {
        @selfRef.Metadata = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithSinkRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Object sinkRetryCount)
    {
        @selfRef.SinkRetryCount = sinkRetryCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithSinkRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SinkRetryCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithSinkRetryWait(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Object sinkRetryWait)
    {
        @selfRef.SinkRetryWait = sinkRetryWait;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithSinkRetryWait(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SinkRetryWait = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithWriteBatchSize(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Object writeBatchSize)
    {
        @selfRef.WriteBatchSize = writeBatchSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithWriteBatchSize(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.WriteBatchSize = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithWriteBatchTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Object writeBatchTimeout)
    {
        @selfRef.WriteBatchTimeout = writeBatchTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs WithWriteBatchTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureBlobFSSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.WriteBatchTimeout = @item;
        return @selfRef;
    }

}
