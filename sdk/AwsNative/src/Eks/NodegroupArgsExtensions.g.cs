// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AwsNative.Eks;

public static partial class NodegroupArgsExtensions
{
    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithAmiType(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.String amiType)
    {
        @selfRef.AmiType = amiType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithCapacityType(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.String capacityType)
    {
        @selfRef.CapacityType = capacityType;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithClusterName(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.String clusterName)
    {
        @selfRef.ClusterName = clusterName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithDiskSize(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Int32 diskSize)
    {
        @selfRef.DiskSize = diskSize;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithForceUpdateEnabled(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, bool forceUpdateEnabled = true)
    {
        @selfRef.ForceUpdateEnabled = forceUpdateEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithInstanceTypes(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Collections.Generic.List<global::System.String> instanceTypes)
    {
        @selfRef.InstanceTypes = instanceTypes;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithInstanceTypes(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.InstanceTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithInstanceTypes(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.InstanceTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithLabels(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> labels)
    {
        @selfRef.Labels = labels;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithLabels(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Labels = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithLabels(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Labels = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithLaunchTemplate(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::Pulumi.AwsNative.Eks.Inputs.NodegroupLaunchTemplateSpecificationArgs launchTemplate)
    {
        @selfRef.LaunchTemplate = launchTemplate;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithLaunchTemplate(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Eks.Inputs.NodegroupLaunchTemplateSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Eks.Inputs.NodegroupLaunchTemplateSpecificationArgs();
        @configure(@item);
        @selfRef.LaunchTemplate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithNodeRepairConfig(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::Pulumi.AwsNative.Eks.Inputs.NodegroupNodeRepairConfigArgs nodeRepairConfig)
    {
        @selfRef.NodeRepairConfig = nodeRepairConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithNodeRepairConfig(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Eks.Inputs.NodegroupNodeRepairConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Eks.Inputs.NodegroupNodeRepairConfigArgs();
        @configure(@item);
        @selfRef.NodeRepairConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithNodeRole(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.String nodeRole)
    {
        @selfRef.NodeRole = nodeRole;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithNodegroupName(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.String nodegroupName)
    {
        @selfRef.NodegroupName = nodegroupName;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithReleaseVersion(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.String releaseVersion)
    {
        @selfRef.ReleaseVersion = releaseVersion;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithRemoteAccess(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::Pulumi.AwsNative.Eks.Inputs.NodegroupRemoteAccessArgs remoteAccess)
    {
        @selfRef.RemoteAccess = remoteAccess;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithRemoteAccess(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Eks.Inputs.NodegroupRemoteAccessArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Eks.Inputs.NodegroupRemoteAccessArgs();
        @configure(@item);
        @selfRef.RemoteAccess = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithScalingConfig(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::Pulumi.AwsNative.Eks.Inputs.NodegroupScalingConfigArgs scalingConfig)
    {
        @selfRef.ScalingConfig = scalingConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithScalingConfig(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Eks.Inputs.NodegroupScalingConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Eks.Inputs.NodegroupScalingConfigArgs();
        @configure(@item);
        @selfRef.ScalingConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithSubnets(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnets)
    {
        @selfRef.Subnets = subnets;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithSubnets(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Subnets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithSubnets(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Subnets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithTags(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithTags(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithTags(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithTaints(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AwsNative.Eks.Inputs.NodegroupTaintArgs> taints)
    {
        @selfRef.Taints = taints;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithTaints(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AwsNative.Eks.Inputs.NodegroupTaintArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AwsNative.Eks.Inputs.NodegroupTaintArgs>();
        @configure(@list);
        @selfRef.Taints = @list;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithTaints(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AwsNative.Eks.Inputs.NodegroupTaintArgs>> @create)
    {
        @selfRef.Taints = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithUpdateConfig(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::Pulumi.AwsNative.Eks.Inputs.NodegroupUpdateConfigArgs updateConfig)
    {
        @selfRef.UpdateConfig = updateConfig;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithUpdateConfig(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.Action<global::Pulumi.AwsNative.Eks.Inputs.NodegroupUpdateConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AwsNative.Eks.Inputs.NodegroupUpdateConfigArgs();
        @configure(@item);
        @selfRef.UpdateConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AwsNative.Eks.NodegroupArgs WithVersion(this global::Pulumi.AwsNative.Eks.NodegroupArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
