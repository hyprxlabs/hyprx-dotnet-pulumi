// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.DataFactory.Inputs;

namespace Pulumi.AzureNative.DataFactory;

public static partial class TeradataSourceArgsExtensions
{
    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithAdditionalColumns(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Object additionalColumns)
    {
        @selfRef.AdditionalColumns = additionalColumns;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithAdditionalColumns(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.AdditionalColumns = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithDisableMetricsCollection(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Object disableMetricsCollection)
    {
        @selfRef.DisableMetricsCollection = disableMetricsCollection;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithDisableMetricsCollection(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.DisableMetricsCollection = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithMaxConcurrentConnections(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Object maxConcurrentConnections)
    {
        @selfRef.MaxConcurrentConnections = maxConcurrentConnections;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithMaxConcurrentConnections(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.MaxConcurrentConnections = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithPartitionOption(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Object partitionOption)
    {
        @selfRef.PartitionOption = partitionOption;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithPartitionOption(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.PartitionOption = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithPartitionSettings(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::Pulumi.AzureNative.DataFactory.Inputs.TeradataPartitionSettingsArgs partitionSettings)
    {
        @selfRef.PartitionSettings = partitionSettings;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithPartitionSettings(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.DataFactory.Inputs.TeradataPartitionSettingsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.DataFactory.Inputs.TeradataPartitionSettingsArgs();
        @configure(@item);
        @selfRef.PartitionSettings = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithQuery(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Object query)
    {
        @selfRef.Query = query;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithQuery(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.Query = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithQueryTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Object queryTimeout)
    {
        @selfRef.QueryTimeout = queryTimeout;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithQueryTimeout(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.QueryTimeout = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithSourceRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Object sourceRetryCount)
    {
        @selfRef.SourceRetryCount = sourceRetryCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithSourceRetryCount(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SourceRetryCount = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithSourceRetryWait(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Object sourceRetryWait)
    {
        @selfRef.SourceRetryWait = sourceRetryWait;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithSourceRetryWait(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.Action<global::System.Object> @configure)
    {
        var @item = new global::System.Object();
        @configure(@item);
        @selfRef.SourceRetryWait = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs WithType(this global::Pulumi.AzureNative.DataFactory.Inputs.TeradataSourceArgs @selfRef, global::System.String type)
    {
        @selfRef.Type = type;
        return @selfRef;
    }

}
