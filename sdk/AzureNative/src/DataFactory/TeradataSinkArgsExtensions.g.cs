// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class TeradataSinkArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithDisableMetricsCollection(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Object disableMetricsCollection)
    {
        @selfRef.DisableMetricsCollection = disableMetricsCollection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithDisableMetricsCollection(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.DisableMetricsCollection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithImportSettings(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.TeradataImportCommandArgs importSettings)
    {
        @selfRef.ImportSettings = importSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithImportSettings(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.TeradataImportCommandArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.TeradataImportCommandArgs();
        @configure(@item);
        @selfRef.ImportSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithMaxConcurrentConnections(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Object maxConcurrentConnections)
    {
        @selfRef.MaxConcurrentConnections = maxConcurrentConnections;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithMaxConcurrentConnections(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MaxConcurrentConnections = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithSinkRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Object sinkRetryCount)
    {
        @selfRef.SinkRetryCount = sinkRetryCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithSinkRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SinkRetryCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithSinkRetryWait(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Object sinkRetryWait)
    {
        @selfRef.SinkRetryWait = sinkRetryWait;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithSinkRetryWait(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SinkRetryWait = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithWriteBatchSize(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Object writeBatchSize)
    {
        @selfRef.WriteBatchSize = writeBatchSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithWriteBatchSize(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.WriteBatchSize = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithWriteBatchTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Object writeBatchTimeout)
    {
        @selfRef.WriteBatchTimeout = writeBatchTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs WithWriteBatchTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.WriteBatchTimeout = @item;
        return @selfRef;
    }

}
