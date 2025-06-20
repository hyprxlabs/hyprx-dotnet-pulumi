// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

using Pulumi.AzureNative.AwsConnector.Inputs;

namespace Pulumi.AzureNative.AwsConnector;

public static partial class AwsDaxClusterPropertiesArgsExtensions
{
    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithActiveNodes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Int32 activeNodes)
    {
        @selfRef.ActiveNodes = activeNodes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithClusterArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.String clusterArn)
    {
        @selfRef.ClusterArn = clusterArn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithClusterDiscoveryEndpoint(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.DaxClusterEndpointArgs clusterDiscoveryEndpoint)
    {
        @selfRef.ClusterDiscoveryEndpoint = clusterDiscoveryEndpoint;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithClusterDiscoveryEndpoint(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.DaxClusterEndpointArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.DaxClusterEndpointArgs();
        @configure(@item);
        @selfRef.ClusterDiscoveryEndpoint = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithClusterEndpointEncryptionType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ClusterEndpointEncryptionTypeEnumValueArgs clusterEndpointEncryptionType)
    {
        @selfRef.ClusterEndpointEncryptionType = clusterEndpointEncryptionType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithClusterEndpointEncryptionType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ClusterEndpointEncryptionTypeEnumValueArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ClusterEndpointEncryptionTypeEnumValueArgs();
        @configure(@item);
        @selfRef.ClusterEndpointEncryptionType = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithClusterName(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.String clusterName)
    {
        @selfRef.ClusterName = clusterName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithDescription(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.String description)
    {
        @selfRef.Description = description;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithIamRoleArn(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.String iamRoleArn)
    {
        @selfRef.IamRoleArn = iamRoleArn;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithNodeIdsToRemove(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::System.String> nodeIdsToRemove)
    {
        @selfRef.NodeIdsToRemove = nodeIdsToRemove;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithNodeIdsToRemove(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.NodeIdsToRemove = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithNodeIdsToRemove(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.NodeIdsToRemove = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithNodeType(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.String nodeType)
    {
        @selfRef.NodeType = nodeType;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithNodes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.NodeArgs> nodes)
    {
        @selfRef.Nodes = nodes;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithNodes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.NodeArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.NodeArgs>();
        @configure(@list);
        @selfRef.Nodes = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithNodes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.NodeArgs>> @create)
    {
        @selfRef.Nodes = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithNotificationConfiguration(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.DaxClusterNotificationConfigurationArgs notificationConfiguration)
    {
        @selfRef.NotificationConfiguration = notificationConfiguration;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithNotificationConfiguration(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.DaxClusterNotificationConfigurationArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.DaxClusterNotificationConfigurationArgs();
        @configure(@item);
        @selfRef.NotificationConfiguration = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithParameterGroup(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.ParameterGroupStatusArgs parameterGroup)
    {
        @selfRef.ParameterGroup = parameterGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithParameterGroup(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.ParameterGroupStatusArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.ParameterGroupStatusArgs();
        @configure(@item);
        @selfRef.ParameterGroup = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithPreferredMaintenanceWindow(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.String preferredMaintenanceWindow)
    {
        @selfRef.PreferredMaintenanceWindow = preferredMaintenanceWindow;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithSecurityGroups(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.SecurityGroupMembershipArgs> securityGroups)
    {
        @selfRef.SecurityGroups = securityGroups;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithSecurityGroups(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.SecurityGroupMembershipArgs>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::Pulumi.AzureNative.AwsConnector.Inputs.SecurityGroupMembershipArgs>();
        @configure(@list);
        @selfRef.SecurityGroups = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithSecurityGroups(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::Pulumi.AzureNative.AwsConnector.Inputs.SecurityGroupMembershipArgs>> @create)
    {
        @selfRef.SecurityGroups = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithSseDescription(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::Pulumi.AzureNative.AwsConnector.Inputs.SSEDescriptionArgs sseDescription)
    {
        @selfRef.SseDescription = sseDescription;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithSseDescription(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AwsConnector.Inputs.SSEDescriptionArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AwsConnector.Inputs.SSEDescriptionArgs();
        @configure(@item);
        @selfRef.SseDescription = @item;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithStatus(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.String status)
    {
        @selfRef.Status = status;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithSubnetGroup(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.String subnetGroup)
    {
        @selfRef.SubnetGroup = subnetGroup;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs WithTotalNodes(this global::Pulumi.AzureNative.AwsConnector.Inputs.AwsDaxClusterPropertiesArgs @selfRef, global::System.Int32 totalNodes)
    {
        @selfRef.TotalNodes = totalNodes;
        return @selfRef;
    }

}
