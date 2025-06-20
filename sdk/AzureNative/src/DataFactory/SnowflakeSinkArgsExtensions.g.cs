// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class SnowflakeSinkArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithDisableMetricsCollection(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Object disableMetricsCollection)
    {
        @selfRef.DisableMetricsCollection = disableMetricsCollection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithDisableMetricsCollection(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.DisableMetricsCollection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithImportSettings(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeImportCopyCommandArgs importSettings)
    {
        @selfRef.ImportSettings = importSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithImportSettings(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeImportCopyCommandArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeImportCopyCommandArgs();
        @configure(@item);
        @selfRef.ImportSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithMaxConcurrentConnections(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Object maxConcurrentConnections)
    {
        @selfRef.MaxConcurrentConnections = maxConcurrentConnections;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithMaxConcurrentConnections(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MaxConcurrentConnections = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithPreCopyScript(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Object preCopyScript)
    {
        @selfRef.PreCopyScript = preCopyScript;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithPreCopyScript(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.PreCopyScript = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithSinkRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Object sinkRetryCount)
    {
        @selfRef.SinkRetryCount = sinkRetryCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithSinkRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SinkRetryCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithSinkRetryWait(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Object sinkRetryWait)
    {
        @selfRef.SinkRetryWait = sinkRetryWait;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithSinkRetryWait(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SinkRetryWait = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithWriteBatchSize(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Object writeBatchSize)
    {
        @selfRef.WriteBatchSize = writeBatchSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithWriteBatchSize(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.WriteBatchSize = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithWriteBatchTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Object writeBatchTimeout)
    {
        @selfRef.WriteBatchTimeout = writeBatchTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs WithWriteBatchTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.SnowflakeSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.WriteBatchTimeout = @item;
        return @selfRef;
    }

}
