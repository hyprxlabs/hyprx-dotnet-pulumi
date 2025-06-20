// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.Monitor.Inputs;

namespace Pulumi.AzureNative.Monitor;

public static partial class DataCollectionRuleDestinationsArgsExtensions
{
    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithAzureMonitorMetrics(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::Pulumi.AzureNative.Monitor.Inputs.DestinationsSpecAzureMonitorMetricsArgs azureMonitorMetrics)
    {
        @selfRef.AzureMonitorMetrics = azureMonitorMetrics;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithAzureMonitorMetrics(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Monitor.Inputs.DestinationsSpecAzureMonitorMetricsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Monitor.Inputs.DestinationsSpecAzureMonitorMetricsArgs();
        @configure(@item);
        @selfRef.AzureMonitorMetrics = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithEventHubs(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.EventHubDestinationArgs> eventHubs)
    {
        @selfRef.EventHubs = eventHubs;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithEventHubs(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.EventHubDestinationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.EventHubDestinationArgs>();
        @configure(@list);
        @selfRef.EventHubs = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithEventHubs(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Monitor.Inputs.EventHubDestinationArgs>> @create)
    {
        @selfRef.EventHubs = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithEventHubsDirect(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.EventHubDirectDestinationArgs> eventHubsDirect)
    {
        @selfRef.EventHubsDirect = eventHubsDirect;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithEventHubsDirect(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.EventHubDirectDestinationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.EventHubDirectDestinationArgs>();
        @configure(@list);
        @selfRef.EventHubsDirect = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithEventHubsDirect(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Monitor.Inputs.EventHubDirectDestinationArgs>> @create)
    {
        @selfRef.EventHubsDirect = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithLogAnalytics(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.LogAnalyticsDestinationArgs> logAnalytics)
    {
        @selfRef.LogAnalytics = logAnalytics;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithLogAnalytics(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.LogAnalyticsDestinationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.LogAnalyticsDestinationArgs>();
        @configure(@list);
        @selfRef.LogAnalytics = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithLogAnalytics(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Monitor.Inputs.LogAnalyticsDestinationArgs>> @create)
    {
        @selfRef.LogAnalytics = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithMonitoringAccounts(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.MonitoringAccountDestinationArgs> monitoringAccounts)
    {
        @selfRef.MonitoringAccounts = monitoringAccounts;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithMonitoringAccounts(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.MonitoringAccountDestinationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.MonitoringAccountDestinationArgs>();
        @configure(@list);
        @selfRef.MonitoringAccounts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithMonitoringAccounts(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Monitor.Inputs.MonitoringAccountDestinationArgs>> @create)
    {
        @selfRef.MonitoringAccounts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithStorageAccounts(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.StorageBlobDestinationArgs> storageAccounts)
    {
        @selfRef.StorageAccounts = storageAccounts;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithStorageAccounts(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.StorageBlobDestinationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.StorageBlobDestinationArgs>();
        @configure(@list);
        @selfRef.StorageAccounts = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithStorageAccounts(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Monitor.Inputs.StorageBlobDestinationArgs>> @create)
    {
        @selfRef.StorageAccounts = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithStorageBlobsDirect(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.StorageBlobDestinationArgs> storageBlobsDirect)
    {
        @selfRef.StorageBlobsDirect = storageBlobsDirect;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithStorageBlobsDirect(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.StorageBlobDestinationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.StorageBlobDestinationArgs>();
        @configure(@list);
        @selfRef.StorageBlobsDirect = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithStorageBlobsDirect(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Monitor.Inputs.StorageBlobDestinationArgs>> @create)
    {
        @selfRef.StorageBlobsDirect = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithStorageTablesDirect(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.StorageTableDestinationArgs> storageTablesDirect)
    {
        @selfRef.StorageTablesDirect = storageTablesDirect;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithStorageTablesDirect(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.StorageTableDestinationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Monitor.Inputs.StorageTableDestinationArgs>();
        @configure(@list);
        @selfRef.StorageTablesDirect = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs WithStorageTablesDirect(this global::Pulumi.AzureNative.Monitor.Inputs.DataCollectionRuleDestinationsArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Monitor.Inputs.StorageTableDestinationArgs>> @create)
    {
        @selfRef.StorageTablesDirect = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
