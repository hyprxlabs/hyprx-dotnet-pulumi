// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class AzureDataLakeStoreSinkArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithCopyBehavior(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Object copyBehavior)
    {
        @selfRef.CopyBehavior = copyBehavior;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithCopyBehavior(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.CopyBehavior = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithDisableMetricsCollection(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Object disableMetricsCollection)
    {
        @selfRef.DisableMetricsCollection = disableMetricsCollection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithDisableMetricsCollection(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.DisableMetricsCollection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithEnableAdlsSingleFileParallel(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Object enableAdlsSingleFileParallel)
    {
        @selfRef.EnableAdlsSingleFileParallel = enableAdlsSingleFileParallel;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithEnableAdlsSingleFileParallel(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.EnableAdlsSingleFileParallel = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithMaxConcurrentConnections(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Object maxConcurrentConnections)
    {
        @selfRef.MaxConcurrentConnections = maxConcurrentConnections;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithMaxConcurrentConnections(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MaxConcurrentConnections = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithSinkRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Object sinkRetryCount)
    {
        @selfRef.SinkRetryCount = sinkRetryCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithSinkRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SinkRetryCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithSinkRetryWait(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Object sinkRetryWait)
    {
        @selfRef.SinkRetryWait = sinkRetryWait;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithSinkRetryWait(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SinkRetryWait = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithWriteBatchSize(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Object writeBatchSize)
    {
        @selfRef.WriteBatchSize = writeBatchSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithWriteBatchSize(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.WriteBatchSize = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithWriteBatchTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Object writeBatchTimeout)
    {
        @selfRef.WriteBatchTimeout = writeBatchTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs WithWriteBatchTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.AzureDataLakeStoreSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.WriteBatchTimeout = @item;
        return @selfRef;
    }

}
