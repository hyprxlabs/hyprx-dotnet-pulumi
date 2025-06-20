// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.HDInsight;

public static partial class ClusterPoolClusterArgsExtensions
{
    public static global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs WithClusterName(this global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs @selfRef, global::System.String clusterName)
    {
        @selfRef.ClusterName = clusterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs WithClusterPoolName(this global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs @selfRef, global::System.String clusterPoolName)
    {
        @selfRef.ClusterPoolName = clusterPoolName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs WithClusterProfile(this global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs @selfRef, global::Pulumi.AzureNative.HDInsight.Inputs.ClusterProfileArgs clusterProfile)
    {
        @selfRef.ClusterProfile = clusterProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs WithClusterProfile(this global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HDInsight.Inputs.ClusterProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HDInsight.Inputs.ClusterProfileArgs();
        @configure(@item);
        @selfRef.ClusterProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs WithClusterType(this global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs @selfRef, global::System.String clusterType)
    {
        @selfRef.ClusterType = clusterType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs WithComputeProfile(this global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs @selfRef, global::Pulumi.AzureNative.HDInsight.Inputs.ClusterPoolComputeProfileArgs computeProfile)
    {
        @selfRef.ComputeProfile = computeProfile;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs WithComputeProfile(this global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.HDInsight.Inputs.ClusterPoolComputeProfileArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.HDInsight.Inputs.ClusterPoolComputeProfileArgs();
        @configure(@item);
        @selfRef.ComputeProfile = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs WithLocation(this global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs WithResourceGroupName(this global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs WithTags(this global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs WithTags(this global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs WithTags(this global::Pulumi.AzureNative.HDInsight.ClusterPoolClusterArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

}
