// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class OrcSinkArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithDisableMetricsCollection(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Object disableMetricsCollection)
    {
        @selfRef.DisableMetricsCollection = disableMetricsCollection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithDisableMetricsCollection(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.DisableMetricsCollection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithFormatSettings(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.OrcWriteSettingsArgs formatSettings)
    {
        @selfRef.FormatSettings = formatSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithFormatSettings(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.OrcWriteSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.OrcWriteSettingsArgs();
        @configure(@item);
        @selfRef.FormatSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithMaxConcurrentConnections(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Object maxConcurrentConnections)
    {
        @selfRef.MaxConcurrentConnections = maxConcurrentConnections;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithMaxConcurrentConnections(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MaxConcurrentConnections = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithSinkRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Object sinkRetryCount)
    {
        @selfRef.SinkRetryCount = sinkRetryCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithSinkRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SinkRetryCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithSinkRetryWait(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Object sinkRetryWait)
    {
        @selfRef.SinkRetryWait = sinkRetryWait;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithSinkRetryWait(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SinkRetryWait = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithWriteBatchSize(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Object writeBatchSize)
    {
        @selfRef.WriteBatchSize = writeBatchSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithWriteBatchSize(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.WriteBatchSize = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithWriteBatchTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Object writeBatchTimeout)
    {
        @selfRef.WriteBatchTimeout = writeBatchTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs WithWriteBatchTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.OrcSinkArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.WriteBatchTimeout = @item;
        return @selfRef;
    }

}
