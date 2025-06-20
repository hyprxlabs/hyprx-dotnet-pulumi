// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.ServiceFabric.Inputs;

namespace Pulumi.AzureNative.ServiceFabric;

public static partial class StatefulServicePropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithCorrelationScheme(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.ServiceCorrelationArgs> correlationScheme)
    {
        @selfRef.CorrelationScheme = correlationScheme;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithCorrelationScheme(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.ServiceCorrelationArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.ServiceCorrelationArgs>();
        @configure(@list);
        @selfRef.CorrelationScheme = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithCorrelationScheme(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.ServiceCorrelationArgs>> @create)
    {
        @selfRef.CorrelationScheme = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithDefaultMoveCost(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceFabric.MoveCost> defaultMoveCost)
    {
        @selfRef.DefaultMoveCost = defaultMoveCost;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithHasPersistedState(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, bool hasPersistedState = true)
    {
        @selfRef.HasPersistedState = hasPersistedState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithMinReplicaSetSize(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Int32 minReplicaSetSize)
    {
        @selfRef.MinReplicaSetSize = minReplicaSetSize;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithPlacementConstraints(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.String placementConstraints)
    {
        @selfRef.PlacementConstraints = placementConstraints;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithQuorumLossWaitDuration(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.String quorumLossWaitDuration)
    {
        @selfRef.QuorumLossWaitDuration = quorumLossWaitDuration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithReplicaRestartWaitDuration(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.String replicaRestartWaitDuration)
    {
        @selfRef.ReplicaRestartWaitDuration = replicaRestartWaitDuration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithScalingPolicies(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.ScalingPolicyArgs> scalingPolicies)
    {
        @selfRef.ScalingPolicies = scalingPolicies;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithScalingPolicies(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.ScalingPolicyArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.ScalingPolicyArgs>();
        @configure(@list);
        @selfRef.ScalingPolicies = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithScalingPolicies(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.ScalingPolicyArgs>> @create)
    {
        @selfRef.ScalingPolicies = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithServiceDnsName(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.String serviceDnsName)
    {
        @selfRef.ServiceDnsName = serviceDnsName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithServiceKind(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.String serviceKind)
    {
        @selfRef.ServiceKind = serviceKind;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithServiceLoadMetrics(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.ServiceLoadMetricArgs> serviceLoadMetrics)
    {
        @selfRef.ServiceLoadMetrics = serviceLoadMetrics;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithServiceLoadMetrics(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.ServiceLoadMetricArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.ServiceFabric.Inputs.ServiceLoadMetricArgs>();
        @configure(@list);
        @selfRef.ServiceLoadMetrics = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithServiceLoadMetrics(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.ServiceFabric.Inputs.ServiceLoadMetricArgs>> @create)
    {
        @selfRef.ServiceLoadMetrics = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithServicePackageActivationMode(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::Pulumi.Union<global::System.String, global::Pulumi.AzureNative.ServiceFabric.ServicePackageActivationMode> servicePackageActivationMode)
    {
        @selfRef.ServicePackageActivationMode = servicePackageActivationMode;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithServicePlacementPolicies(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.Object> servicePlacementPolicies)
    {
        @selfRef.ServicePlacementPolicies = servicePlacementPolicies;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithServicePlacementPolicies(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.Object>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.Object>();
        @configure(@list);
        @selfRef.ServicePlacementPolicies = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithServicePlacementPolicies(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.Object>> @create)
    {
        @selfRef.ServicePlacementPolicies = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithServicePlacementTimeLimit(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.String servicePlacementTimeLimit)
    {
        @selfRef.ServicePlacementTimeLimit = servicePlacementTimeLimit;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithServiceTypeName(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.String serviceTypeName)
    {
        @selfRef.ServiceTypeName = serviceTypeName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithStandByReplicaKeepDuration(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.String standByReplicaKeepDuration)
    {
        @selfRef.StandByReplicaKeepDuration = standByReplicaKeepDuration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs WithTargetReplicaSetSize(this global::Pulumi.AzureNative.ServiceFabric.Inputs.StatefulServicePropertiesArgs @selfRef, global::System.Int32 targetReplicaSetSize)
    {
        @selfRef.TargetReplicaSetSize = targetReplicaSetSize;
        return @selfRef;
    }

}
