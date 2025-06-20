// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.RecoveryServices.Inputs;

namespace Pulumi.AzureNative.RecoveryServices;

public static partial class ReplicationProtectionClusterPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithActiveLocation(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String activeLocation)
    {
        @selfRef.ActiveLocation = activeLocation;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithAgentClusterId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String agentClusterId)
    {
        @selfRef.AgentClusterId = agentClusterId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithAllowedOperations(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> allowedOperations)
    {
        @selfRef.AllowedOperations = allowedOperations;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithAllowedOperations(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.AllowedOperations = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithAllowedOperations(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.AllowedOperations = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithAreAllClusterNodesRegistered(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, bool areAllClusterNodesRegistered = true)
    {
        @selfRef.AreAllClusterNodesRegistered = areAllClusterNodesRegistered;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithClusterFqdn(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String clusterFqdn)
    {
        @selfRef.ClusterFqdn = clusterFqdn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithClusterNodeFqdns(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> clusterNodeFqdns)
    {
        @selfRef.ClusterNodeFqdns = clusterNodeFqdns;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithClusterNodeFqdns(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ClusterNodeFqdns = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithClusterNodeFqdns(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ClusterNodeFqdns = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithClusterProtectedItemIds(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> clusterProtectedItemIds)
    {
        @selfRef.ClusterProtectedItemIds = clusterProtectedItemIds;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithClusterProtectedItemIds(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.ClusterProtectedItemIds = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithClusterProtectedItemIds(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.ClusterProtectedItemIds = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithClusterRegisteredNodes(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.RecoveryServices.Inputs.RegisteredClusterNodesArgs> clusterRegisteredNodes)
    {
        @selfRef.ClusterRegisteredNodes = clusterRegisteredNodes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithClusterRegisteredNodes(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.RecoveryServices.Inputs.RegisteredClusterNodesArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.RecoveryServices.Inputs.RegisteredClusterNodesArgs>();
        @configure(@list);
        @selfRef.ClusterRegisteredNodes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithClusterRegisteredNodes(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.RecoveryServices.Inputs.RegisteredClusterNodesArgs>> @create)
    {
        @selfRef.ClusterRegisteredNodes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithCurrentScenario(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::Pulumi.AzureNative.RecoveryServices.Inputs.CurrentScenarioDetailsArgs currentScenario)
    {
        @selfRef.CurrentScenario = currentScenario;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithCurrentScenario(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.RecoveryServices.Inputs.CurrentScenarioDetailsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.RecoveryServices.Inputs.CurrentScenarioDetailsArgs();
        @configure(@item);
        @selfRef.CurrentScenario = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithHealthErrors(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.RecoveryServices.Inputs.HealthErrorArgs> healthErrors)
    {
        @selfRef.HealthErrors = healthErrors;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithHealthErrors(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.RecoveryServices.Inputs.HealthErrorArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.RecoveryServices.Inputs.HealthErrorArgs>();
        @configure(@list);
        @selfRef.HealthErrors = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithHealthErrors(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.RecoveryServices.Inputs.HealthErrorArgs>> @create)
    {
        @selfRef.HealthErrors = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithLastSuccessfulFailoverTime(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String lastSuccessfulFailoverTime)
    {
        @selfRef.LastSuccessfulFailoverTime = lastSuccessfulFailoverTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithLastSuccessfulTestFailoverTime(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String lastSuccessfulTestFailoverTime)
    {
        @selfRef.LastSuccessfulTestFailoverTime = lastSuccessfulTestFailoverTime;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithPolicyFriendlyName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String policyFriendlyName)
    {
        @selfRef.PolicyFriendlyName = policyFriendlyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithPolicyId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String policyId)
    {
        @selfRef.PolicyId = policyId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithPrimaryFabricFriendlyName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String primaryFabricFriendlyName)
    {
        @selfRef.PrimaryFabricFriendlyName = primaryFabricFriendlyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithPrimaryFabricProvider(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String primaryFabricProvider)
    {
        @selfRef.PrimaryFabricProvider = primaryFabricProvider;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithPrimaryProtectionContainerFriendlyName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String primaryProtectionContainerFriendlyName)
    {
        @selfRef.PrimaryProtectionContainerFriendlyName = primaryProtectionContainerFriendlyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithProtectionClusterType(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String protectionClusterType)
    {
        @selfRef.ProtectionClusterType = protectionClusterType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithProtectionState(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String protectionState)
    {
        @selfRef.ProtectionState = protectionState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithProtectionStateDescription(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String protectionStateDescription)
    {
        @selfRef.ProtectionStateDescription = protectionStateDescription;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithProviderSpecificDetails(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::Pulumi.AzureNative.RecoveryServices.Inputs.A2AReplicationProtectionClusterDetailsArgs providerSpecificDetails)
    {
        @selfRef.ProviderSpecificDetails = providerSpecificDetails;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithProviderSpecificDetails(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.RecoveryServices.Inputs.A2AReplicationProtectionClusterDetailsArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.RecoveryServices.Inputs.A2AReplicationProtectionClusterDetailsArgs();
        @configure(@item);
        @selfRef.ProviderSpecificDetails = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithRecoveryContainerId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String recoveryContainerId)
    {
        @selfRef.RecoveryContainerId = recoveryContainerId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithRecoveryFabricFriendlyName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String recoveryFabricFriendlyName)
    {
        @selfRef.RecoveryFabricFriendlyName = recoveryFabricFriendlyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithRecoveryFabricId(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String recoveryFabricId)
    {
        @selfRef.RecoveryFabricId = recoveryFabricId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithRecoveryProtectionContainerFriendlyName(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String recoveryProtectionContainerFriendlyName)
    {
        @selfRef.RecoveryProtectionContainerFriendlyName = recoveryProtectionContainerFriendlyName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithReplicationHealth(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String replicationHealth)
    {
        @selfRef.ReplicationHealth = replicationHealth;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithSharedDiskProperties(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::Pulumi.AzureNative.RecoveryServices.Inputs.SharedDiskReplicationItemPropertiesArgs sharedDiskProperties)
    {
        @selfRef.SharedDiskProperties = sharedDiskProperties;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithSharedDiskProperties(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.RecoveryServices.Inputs.SharedDiskReplicationItemPropertiesArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.RecoveryServices.Inputs.SharedDiskReplicationItemPropertiesArgs();
        @configure(@item);
        @selfRef.SharedDiskProperties = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithTestFailoverState(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String testFailoverState)
    {
        @selfRef.TestFailoverState = testFailoverState;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs WithTestFailoverStateDescription(this global::Pulumi.AzureNative.RecoveryServices.Inputs.ReplicationProtectionClusterPropertiesArgs @selfRef, global::System.String testFailoverStateDescription)
    {
        @selfRef.TestFailoverStateDescription = testFailoverStateDescription;
        return @selfRef;
    }

}
