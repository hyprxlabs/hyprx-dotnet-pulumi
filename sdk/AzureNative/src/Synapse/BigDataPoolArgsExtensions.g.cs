// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.Synapse;

public static partial class BigDataPoolArgsExtensions
{
    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithAutoPause(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::Pulumi.AzureNative.Synapse.Inputs.AutoPausePropertiesArgs autoPause)
    {
        @selfRef.AutoPause = autoPause;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithAutoPause(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Synapse.Inputs.AutoPausePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Synapse.Inputs.AutoPausePropertiesArgs();
        @configure(@item);
        @selfRef.AutoPause = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithAutoScale(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::Pulumi.AzureNative.Synapse.Inputs.AutoScalePropertiesArgs autoScale)
    {
        @selfRef.AutoScale = autoScale;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithAutoScale(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Synapse.Inputs.AutoScalePropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Synapse.Inputs.AutoScalePropertiesArgs();
        @configure(@item);
        @selfRef.AutoScale = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithBigDataPoolName(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.String bigDataPoolName)
    {
        @selfRef.BigDataPoolName = bigDataPoolName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithCacheSize(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Int32 cacheSize)
    {
        @selfRef.CacheSize = cacheSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithCustomLibraries(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.Synapse.Inputs.LibraryInfoArgs> customLibraries)
    {
        @selfRef.CustomLibraries = customLibraries;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithCustomLibraries(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.Synapse.Inputs.LibraryInfoArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.Synapse.Inputs.LibraryInfoArgs>();
        @configure(@list);
        @selfRef.CustomLibraries = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithCustomLibraries(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.Synapse.Inputs.LibraryInfoArgs>> @create)
    {
        @selfRef.CustomLibraries = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithDefaultSparkLogFolder(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.String defaultSparkLogFolder)
    {
        @selfRef.DefaultSparkLogFolder = defaultSparkLogFolder;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithDynamicExecutorAllocation(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::Pulumi.AzureNative.Synapse.Inputs.DynamicExecutorAllocationArgs dynamicExecutorAllocation)
    {
        @selfRef.DynamicExecutorAllocation = dynamicExecutorAllocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithDynamicExecutorAllocation(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Synapse.Inputs.DynamicExecutorAllocationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Synapse.Inputs.DynamicExecutorAllocationArgs();
        @configure(@item);
        @selfRef.DynamicExecutorAllocation = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithForce(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, bool force = true)
    {
        @selfRef.Force = force;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithIsAutotuneEnabled(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, bool isAutotuneEnabled = true)
    {
        @selfRef.IsAutotuneEnabled = isAutotuneEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithIsComputeIsolationEnabled(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, bool isComputeIsolationEnabled = true)
    {
        @selfRef.IsComputeIsolationEnabled = isComputeIsolationEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithLibraryRequirements(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::Pulumi.AzureNative.Synapse.Inputs.LibraryRequirementsArgs libraryRequirements)
    {
        @selfRef.LibraryRequirements = libraryRequirements;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithLibraryRequirements(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Synapse.Inputs.LibraryRequirementsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Synapse.Inputs.LibraryRequirementsArgs();
        @configure(@item);
        @selfRef.LibraryRequirements = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithLocation(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.String location)
    {
        @selfRef.Location = location;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithNodeCount(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Int32 nodeCount)
    {
        @selfRef.NodeCount = nodeCount;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithNodeSize(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Synapse.NodeSize> nodeSize)
    {
        @selfRef.NodeSize = nodeSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithNodeSizeFamily(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.Synapse.NodeSizeFamily> nodeSizeFamily)
    {
        @selfRef.NodeSizeFamily = nodeSizeFamily;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithProvisioningState(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.String provisioningState)
    {
        @selfRef.ProvisioningState = provisioningState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithResourceGroupName(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithSessionLevelPackagesEnabled(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, bool sessionLevelPackagesEnabled = true)
    {
        @selfRef.SessionLevelPackagesEnabled = sessionLevelPackagesEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithSparkConfigProperties(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::Pulumi.AzureNative.Synapse.Inputs.SparkConfigPropertiesArgs sparkConfigProperties)
    {
        @selfRef.SparkConfigProperties = sparkConfigProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithSparkConfigProperties(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.Synapse.Inputs.SparkConfigPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.Synapse.Inputs.SparkConfigPropertiesArgs();
        @configure(@item);
        @selfRef.SparkConfigProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithSparkEventsFolder(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.String sparkEventsFolder)
    {
        @selfRef.SparkEventsFolder = sparkEventsFolder;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithSparkVersion(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.String sparkVersion)
    {
        @selfRef.SparkVersion = sparkVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithTags(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithTags(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithTags(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.Synapse.BigDataPoolArgs WithWorkspaceName(this global::Pulumi.AzureNative.Synapse.BigDataPoolArgs @selfRef, global::System.String workspaceName)
    {
        @selfRef.WorkspaceName = workspaceName;
        return @selfRef;
    }

}
