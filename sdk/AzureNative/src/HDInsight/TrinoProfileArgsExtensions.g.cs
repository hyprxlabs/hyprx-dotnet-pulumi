// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HDInsight.Inputs;

namespace Pulumi.AzureNative.HDInsight;

public static partial class TrinoProfileArgsExtensions
{
    public static global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs WithCatalogOptions(this global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs @selfRef, global::Pulumi.AzureNative.HDInsight.Inputs.CatalogOptionsArgs catalogOptions)
    {
        @selfRef.CatalogOptions = catalogOptions;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs WithCatalogOptions(this global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HDInsight.Inputs.CatalogOptionsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HDInsight.Inputs.CatalogOptionsArgs();
        @configure(@item);
        @selfRef.CatalogOptions = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs WithCoordinator(this global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs @selfRef, global::Pulumi.AzureNative.HDInsight.Inputs.TrinoCoordinatorArgs coordinator)
    {
        @selfRef.Coordinator = coordinator;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs WithCoordinator(this global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HDInsight.Inputs.TrinoCoordinatorArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HDInsight.Inputs.TrinoCoordinatorArgs();
        @configure(@item);
        @selfRef.Coordinator = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs WithUserPluginsSpec(this global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs @selfRef, global::Pulumi.AzureNative.HDInsight.Inputs.TrinoUserPluginsArgs userPluginsSpec)
    {
        @selfRef.UserPluginsSpec = userPluginsSpec;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs WithUserPluginsSpec(this global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HDInsight.Inputs.TrinoUserPluginsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HDInsight.Inputs.TrinoUserPluginsArgs();
        @configure(@item);
        @selfRef.UserPluginsSpec = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs WithUserTelemetrySpec(this global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs @selfRef, global::Pulumi.AzureNative.HDInsight.Inputs.TrinoUserTelemetryArgs userTelemetrySpec)
    {
        @selfRef.UserTelemetrySpec = userTelemetrySpec;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs WithUserTelemetrySpec(this global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HDInsight.Inputs.TrinoUserTelemetryArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HDInsight.Inputs.TrinoUserTelemetryArgs();
        @configure(@item);
        @selfRef.UserTelemetrySpec = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs WithWorker(this global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs @selfRef, global::Pulumi.AzureNative.HDInsight.Inputs.TrinoWorkerArgs worker)
    {
        @selfRef.Worker = worker;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs WithWorker(this global::Pulumi.AzureNative.HDInsight.Inputs.TrinoProfileArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HDInsight.Inputs.TrinoWorkerArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HDInsight.Inputs.TrinoWorkerArgs();
        @configure(@item);
        @selfRef.Worker = @item;
        return @selfRef;
    }

}
