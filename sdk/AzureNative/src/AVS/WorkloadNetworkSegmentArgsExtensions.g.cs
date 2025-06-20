// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AVS;

public static partial class WorkloadNetworkSegmentArgsExtensions
{
    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs WithConnectedGateway(this global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs @selfRef, global::System.String connectedGateway)
    {
        @selfRef.ConnectedGateway = connectedGateway;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs WithDisplayName(this global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs WithPrivateCloudName(this global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs @selfRef, global::System.String privateCloudName)
    {
        @selfRef.PrivateCloudName = privateCloudName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs WithResourceGroupName(this global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs WithRevision(this global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs @selfRef, global::System.Double revision)
    {
        @selfRef.Revision = revision;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs WithSegmentId(this global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs @selfRef, global::System.String segmentId)
    {
        @selfRef.SegmentId = segmentId;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs WithSubnet(this global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs @selfRef, global::Pulumi.AzureNative.AVS.Inputs.WorkloadNetworkSegmentSubnetArgs subnet)
    {
        @selfRef.Subnet = subnet;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs WithSubnet(this global::Pulumi.AzureNative.AVS.WorkloadNetworkSegmentArgs @selfRef, global::System.Action<global::Pulumi.AzureNative.AVS.Inputs.WorkloadNetworkSegmentSubnetArgs> @configure)
    {
        var @item = new global::Pulumi.AzureNative.AVS.Inputs.WorkloadNetworkSegmentSubnetArgs();
        @configure(@item);
        @selfRef.Subnet = @item;
        return @selfRef;
    }

}
