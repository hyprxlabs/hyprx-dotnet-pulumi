// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.HDInsight.Inputs;

namespace Pulumi.AzureNative.HDInsight;

public static partial class FlinkCatalogOptionsArgsExtensions
{
    public static global::Pulumi.AzureNative.HDInsight.Inputs.FlinkCatalogOptionsArgs WithHive(this global::Pulumi.AzureNative.HDInsight.Inputs.FlinkCatalogOptionsArgs @selfRef, global::Pulumi.AzureNative.HDInsight.Inputs.FlinkHiveCatalogOptionArgs hive)
    {
        @selfRef.Hive = hive;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.Inputs.FlinkCatalogOptionsArgs WithHive(this global::Pulumi.AzureNative.HDInsight.Inputs.FlinkCatalogOptionsArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HDInsight.Inputs.FlinkHiveCatalogOptionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HDInsight.Inputs.FlinkHiveCatalogOptionArgs();
        @configure(@item);
        @selfRef.Hive = @item;
        return @selfRef;
    }

}
