// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AwsEksNodegroupPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithAmiType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.String amiType)
    {
        @selfRef.AmiType = amiType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.String arn)
    {
        @selfRef.Arn = arn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithCapacityType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.String capacityType)
    {
        @selfRef.CapacityType = capacityType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithClusterName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.String clusterName)
    {
        @selfRef.ClusterName = clusterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithDiskSize(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Int32 diskSize)
    {
        @selfRef.DiskSize = diskSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithForceUpdateEnabled(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, bool forceUpdateEnabled = true)
    {
        @selfRef.ForceUpdateEnabled = forceUpdateEnabled;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithId(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.String id)
    {
        @selfRef.Id = id;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithInstanceTypes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> instanceTypes)
    {
        @selfRef.InstanceTypes = instanceTypes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithInstanceTypes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.InstanceTypes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithInstanceTypes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.InstanceTypes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithLabels(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> labels)
    {
        @selfRef.Labels = labels;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithLabels(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Labels = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithLabels(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Labels = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithLaunchTemplate(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.LaunchTemplateSpecificationArgs launchTemplate)
    {
        @selfRef.LaunchTemplate = launchTemplate;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithLaunchTemplate(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.LaunchTemplateSpecificationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.LaunchTemplateSpecificationArgs();
        @configure(@item);
        @selfRef.LaunchTemplate = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithNodeRole(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.String nodeRole)
    {
        @selfRef.NodeRole = nodeRole;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithNodegroupName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.String nodegroupName)
    {
        @selfRef.NodegroupName = nodegroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithReleaseVersion(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.String releaseVersion)
    {
        @selfRef.ReleaseVersion = releaseVersion;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithRemoteAccess(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.RemoteAccessArgs remoteAccess)
    {
        @selfRef.RemoteAccess = remoteAccess;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithRemoteAccess(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.RemoteAccessArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.RemoteAccessArgs();
        @configure(@item);
        @selfRef.RemoteAccess = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithScalingConfig(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigArgs scalingConfig)
    {
        @selfRef.ScalingConfig = scalingConfig;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithScalingConfig(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ScalingConfigArgs();
        @configure(@item);
        @selfRef.ScalingConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithSubnets(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> subnets)
    {
        @selfRef.Subnets = subnets;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithSubnets(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Subnets = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithSubnets(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Subnets = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Collections.Generic.Dictionary<string, global::System.String> tags)
    {
        @selfRef.Tags = tags;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.Dictionary<string, global::System.String>> @configure)
    {
        var @dict = new global::System.Collections.Generic.Dictionary<string, global::System.String>();
        @configure(@dict);
        @selfRef.Tags = @dict;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithTags(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IDictionary<string, global::System.String>> @create)
    {
        @selfRef.Tags = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithTaints(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TaintArgs> taints)
    {
        @selfRef.Taints = taints;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithTaints(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TaintArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.TaintArgs>();
        @configure(@list);
        @selfRef.Taints = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithTaints(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.TaintArgs>> @create)
    {
        @selfRef.Taints = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithUpdateConfig(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.UpdateConfigArgs updateConfig)
    {
        @selfRef.UpdateConfig = updateConfig;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithUpdateConfig(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.UpdateConfigArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.UpdateConfigArgs();
        @configure(@item);
        @selfRef.UpdateConfig = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs WithVersion(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsEksNodegroupPropertiesArgs @selfRef, global::System.String version)
    {
        @selfRef.Version = version;
        return @selfRef;
    }

}
