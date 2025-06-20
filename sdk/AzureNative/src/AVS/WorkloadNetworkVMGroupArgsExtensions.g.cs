// <auto-generated/>
// Do not edit any code this file. Create or edit the partial class instead in a different file.

#nullable enable

namespace Pulumi.AzureNative.AVS;

public static partial class WorkloadNetworkVMGroupArgsExtensions
{
    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs WithDisplayName(this global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs @selfRef, global::System.String displayName)
    {
        @selfRef.DisplayName = displayName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs WithMembers(this global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs @selfRef, global::System.Collections.Generic.List<global::System.String> members)
    {
        @selfRef.Members = members;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs WithMembers(this global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs @selfRef, global::System.Action<global::System.Collections.Generic.List<global::System.String>> @configure)
    {
        var @list = new global::System.Collections.Generic.List<global::System.String>();
        @configure(@list);
        @selfRef.Members = @list;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs WithMembers(this global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs @selfRef, global::System.Func<global::System.Collections.Generic.IEnumerable<global::System.String>> @create)
    {
        @selfRef.Members = global::Pulumi.Output.Create(@create());
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs WithPrivateCloudName(this global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs @selfRef, global::System.String privateCloudName)
    {
        @selfRef.PrivateCloudName = privateCloudName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs WithResourceGroupName(this global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs @selfRef, global::System.String resourceGroupName)
    {
        @selfRef.ResourceGroupName = resourceGroupName;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs WithRevision(this global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs @selfRef, global::System.Double revision)
    {
        @selfRef.Revision = revision;
        return @selfRef;
    }

    public static global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs WithVmGroupId(this global::Pulumi.AzureNative.AVS.WorkloadNetworkVMGroupArgs @selfRef, global::System.String vmGroupId)
    {
        @selfRef.VmGroupId = vmGroupId;
        return @selfRef;
    }

}
